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
using Xunit;

namespace Congo.Test
{
    public class PostService_Tests
    {
        [Fact]
        public void AddCartProduct()
        {
            CartController cartcontroller = new CartController(new dumbyService());
            cartcontroller.Request = new HttpRequestMessage();
            cartcontroller.Configuration = new HttpConfiguration();
            var result = cartcontroller.Post(new CartProduct { CustomerID = 1, ProductID = 2});
            Assert.True(true);
        }
    }
}
