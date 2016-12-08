﻿using Congo.Logic;
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
    public class OrderController : ApiController
    {
        IGetServices sv;
        public OrderController(IGetServices sv)
        {
            this.sv = sv;
        }


        // GET: api/Order
        public HttpResponseMessage Get()
        {
            var orders = sv.getAllOrders();
            if (!orders.Any())
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, new { message = "Not found" });
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, orders);
            }
        }

        // GET: api/Order/5
        public HttpResponseMessage Get(int id)
        {
            var orders = sv.CustomerOrderHistory(id);
            if(!orders.Any())
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, new { message = "Not found" });
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, orders);
            }
        }

        // POST: api/Order
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Order/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Order/5
        public void Delete(int id)
        {
        }
    }
}
