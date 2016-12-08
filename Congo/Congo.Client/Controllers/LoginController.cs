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
    [EnableCors(origins: "*", headers:"*",methods:"*")]
    public class LoginController : ApiController
    {
        IGetServices sv;
        public LoginController(IGetServices sv)
        {
            this.sv = sv;
        }

        // GET: api/Login
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Login/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Login
        public HttpResponseMessage Post(AccountDAO account)
        {
            this.Validate(account);
            
            if (ModelState.IsValid)
            {
                Login login = sv.LogIn(account);
                if (login.success)
                {
                    
                    return Request.CreateResponse(HttpStatusCode.OK, login);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.OK, login);
                }
            }
            return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
        }

        // PUT: api/Login/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Login/5
        public void Delete(int id)
        {
        }
    }
}
