using Congo.Logic;
using Congo.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Congo.Client.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CartController : ApiController
    {
        IGetServices sv;
        public CartController(IGetServices sv)
        {
            this.sv = sv;
        }


        // GET: api/Cart
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet]
        // GET: api/Cart/5
        public string Get(int id)
        {
            return string.Empty;
        }

        [HttpPost]
        // POST: api/Cart
        public HttpResponseMessage Post(CartProduct cart)
        {
            this.Validate(cart);
            if (ModelState.IsValid)
            {
                CartProduct c = sv.AddToCart(cart);
                if (c.success)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, c);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.OK, c);
                }
            }

            return Request.CreateErrorResponse(HttpStatusCode.BadRequest,ModelState);
            

        }

        // PUT: api/Cart/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Cart/5
        [HttpDelete]
        public HttpResponseMessage removeCartItem(int cartid, int productid)
        {
            if (ModelState.IsValid)
            {
                CartProduct c = sv.deleteCartItem(cartid, productid);
                if (c.success)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, c);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.OK, c);
                }
            }

            return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);

        }

        [HttpDelete]
        public HttpResponseMessage emptyCart(int customerID)
        {
            if(customerID != 0)
            {
                CartProduct response = sv.ClearCart(customerID);
                if (response.success)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, response);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.OK, response);
                }
            }
            return Request.CreateResponse(HttpStatusCode.BadRequest);
        }
    }
}
