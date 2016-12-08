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

        // GET: api/Cart/5
        public HttpResponseMessage Get(int id)
        {
            var cart = sv.getCart(id);
            if(cart.Customer == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, new {message = "Not found"});
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, cart);
            }
        }

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
        public void Delete(int id)
        {
        }
    }
}
