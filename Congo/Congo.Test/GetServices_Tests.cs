using Congo.Client.Controllers;
using Congo.Logic;
using Congo.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Script.Serialization;
using Xunit;

namespace Congo.Test
{
    public class GetServices_Tests
    {
        [Fact]
        public void GetCart_Test()
        {
            CartController cartcontroller = new CartController(new dumbyService());
            cartcontroller.Request = new HttpRequestMessage();
            cartcontroller.Configuration = new HttpConfiguration();
            var result = cartcontroller.Get(2);
            var expected = "hammer";
            var actual = result.Products[0].Name;
            Assert.Equal(expected, actual);

        }
    }
}
