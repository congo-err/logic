using Congo.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Congo.Logic
{
    public partial class Service : IGetServices
    {
        public HttpClient client;
        private string URL = @"http://ec2-34-193-176-76.compute-1.amazonaws.com/congodataservice/";

        /// <summary>
        /// constructor to initlaize HttpClient
        /// </summary>
        public Service()
        {
            client = new HttpClient();
        }



        /// <summary>
        /// Grabs an account from the database api
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public AccountDAO confirmRole(int id)
        {
            return GetObject<AccountDAO>(URL + "Account/" + id);
        }

        /// <summary>
        /// Grabs the list of categories from the database api
        /// </summary>
        /// <returns></returns>
        public List<CategoryDAO> getCategories()
        {
            return GetObject<List<CategoryDAO>>(URL + "category");
        }


        /// <summary>
        /// Grabs a list of products given the category ID
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public List<ProductDAO> getProducts(int ID)
        { 
            return GetObject<List<ProductDAO>>(URL + "Category/" + ID);
        }

        public List<OrderDAO> getAllOrders()
        {
            return GetObject<List<OrderDAO>>(URL + "Order");
        }

        public List<OrderDAO> CustomerOrderHistory(int customerID)
        {
            return GetObject<List<OrderDAO>>(URL + "Order/" + customerID);
        }

        public List<ProductDAO> getProducts()
        {
            return GetObject<List<ProductDAO>>(URL + "Product");
        }
        /// <summary>
        /// Grabs a cart based on the customerID
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public CartDAO getCart(int ID)
        { 
            return GetObject<CartDAO>(URL + "Cart/" + ID);
        }


        /// <summary>
        /// Selects X number of products to return from the database
        /// </summary>
        /// <param name="numberOfItems"></param>
        /// <returns></returns>
        public List<ProductDAO> getFeaturedItems(int numberOfItems)
        {
            Random rnd = new Random();
            List<ProductDAO> featuredProducts = new List<ProductDAO>();
            List<ProductDAO> AllProducts = GetObject<List<ProductDAO>>(URL + "Product");
            int[] ChosenNumbers = new int[numberOfItems];

            for (int i = 0; i < numberOfItems; i++)
            {
                var random = rnd.Next(1, AllProducts.Count +1);
                while (ChosenNumbers.Contains(random))
                {
                    random = rnd.Next(1, AllProducts.Count+1);
                }
                ChosenNumbers[i] = random;
                featuredProducts.Add(AllProducts[random-1]);
            }
            return featuredProducts;
        }


        /// <summary>
        /// Helper method to handle the http get requests. A generic method that takes a URL and data type it returns
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        /// <returns></returns>
        private T GetObject<T>(string url) where T : class, new()
        {
            HttpResponseMessage response = client.GetAsync(url).Result;

            if (response.IsSuccessStatusCode)
            {
                var stream = response.Content.ReadAsStringAsync().Result;
                var serializer = new JavaScriptSerializer();
                return serializer.Deserialize<T>(stream);
            }

            return new T();
        }
    }
}
