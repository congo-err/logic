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
            var result = cartcontroller.Post(new CartProduct { CustomerID = 1, ProductID = 2 , CartID = 1, success = true});
            var actual = result.StatusCode;
            var expected = HttpStatusCode.OK;

            var actual2 = cartcontroller.Post(new CartProduct { CustomerID = 0, ProductID = 2 , CartID = 0, success = false}).StatusCode;
            var expected2 = HttpStatusCode.BadRequest;

            var actual3 = cartcontroller.Post(new CartProduct { CustomerID = 3 , success = false}).StatusCode;
            var expected3 = HttpStatusCode.BadRequest;
            Assert.Equal(actual, expected);
            Assert.Equal(actual2, expected2);
            Assert.Equal(actual3, expected3);
        }

        [Fact]
        public void Login_Test()
        {
            LoginController logincontroller = new LoginController(new dumbyService());
            logincontroller.Request = new HttpRequestMessage();
            logincontroller.Configuration = new HttpConfiguration();

            var result = logincontroller.Post(new AccountDAO { AccountID = 1, UserName = "ryan", Role = "admin", Password = "123456" });
            var actual = result.StatusCode;
            var expected = HttpStatusCode.OK;
            Assert.Equal(actual, expected);

            var result2 = logincontroller.Post(new AccountDAO { AccountID = 2, Role = "admin", Password = "123456" });
            var actual2 = result.StatusCode;
            var expected2 = HttpStatusCode.OK;
            Assert.Equal(actual2, expected2);

            var result3 = logincontroller.Post(new AccountDAO { AccountID = 4 });
            var actual3 = result.StatusCode;
            var expected3 = HttpStatusCode.OK;
            Assert.Equal(actual3, expected3);

        }

        
    }
}
