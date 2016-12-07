using Congo.Client.Controllers;
using Congo.Logic;
using Congo.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Xunit;

namespace Congo.Test
{
    public class PostService_Tests
    {
        [Fact]
        public void AddToCart_Test()
        {
            CartController cartcontroller = new CartController(new dumbyService());
            cartcontroller.Request = new HttpRequestMessage();
            cartcontroller.Configuration = new HttpConfiguration();
            var result = cartcontroller.Post(new CartProduct { CustomerID = 1, ProductID = 2});
            var actual = result.StatusCode;
            var expected = HttpStatusCode.OK;

            var actual2 = cartcontroller.Post(new CartProduct { CustomerID = 0, ProductID = 2 }).StatusCode;
            var expected2 = HttpStatusCode.BadRequest;

            var actual3 = cartcontroller.Post(new CartProduct { CustomerID = 3 }).StatusCode;
            var expected3 = HttpStatusCode.BadRequest;
            Assert.Equal(actual, expected);
            Assert.Equal(actual2, expected2);
            Assert.Equal(actual3, expected3);
        }
    }
}
