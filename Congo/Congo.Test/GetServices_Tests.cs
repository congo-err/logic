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
using System.Web.Script.Serialization;
using Xunit;

namespace Congo.Test
{
    public class GetServices_Tests
    {
        [Fact]
        public void confirmUserRole_Test()
        {
            UserRoleController controller = new UserRoleController(new dumbyService());
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();
            var result = controller.Get(2);
            var result2 = controller.Get(3);
            var expected = HttpStatusCode.OK;
            var expected2 = HttpStatusCode.NotFound;
            var actual = result.StatusCode;
            var actual2 = result2.StatusCode;

            Assert.Equal(actual, expected);
            Assert.Equal(actual2, expected2);
        }
        [Fact]
        public void GetCart_Test()
        {
            CartController cartcontroller = new CartController(new dumbyService());
            cartcontroller.Request = new HttpRequestMessage();
            cartcontroller.Configuration = new HttpConfiguration();
            var result = cartcontroller.Get(2);
            var expected = HttpStatusCode.OK;
            var actual = result.StatusCode;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetCategories_Test()
        {
            CategoryController controller = new CategoryController(new dumbyService());
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();
            var result = controller.Get();
            var expected = HttpStatusCode.OK;
            var actual = result.StatusCode;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void getFeatured_Test()
        {
            FeaturedController controller = new FeaturedController(new dumbyService());
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();
            var result = controller.Get(2);
            var expected = HttpStatusCode.OK;
            var actual = result.StatusCode;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void getProducts_Test()
        {
            ProductController controller = new ProductController(new dumbyService());
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();
            var result = controller.Get(2);
            var expected = HttpStatusCode.OK;
            var actual = result.StatusCode;
            Assert.Equal(expected, actual);
        }
    }
}
