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
        // todo : Add url to api
        private string URL;

        /// <summary>
        /// constructor to initlaize HttpClient
        /// </summary>
        public Service()
        {
            client = new HttpClient();
        }

        
        //confirm account exists, login information is correct
        public AccountDAO confirmAccount(AccountDAO account)
        {
            return account;
        }



        public List<CategoryDAO> getCategories()
        {
            return GetObject<List<CategoryDAO>>(URL + "category");
        }


        //Gets the products based on category ID
        public List<ProductDAO> getProducts(int ID)
        { 
            return GetObject<List<ProductDAO>>(URL + "Products/" + ID);
        }

        
        public CartDAO getCart(int ID)
        {
            return GetObject<CartDAO>(URL + "Cart");
        }



        public List<ProductDAO> getFeaturedItems(int numberOfItems)
        {
            Random rnd = new Random();
            List<ProductDAO> featuredProducts = new List<ProductDAO>();

            for (int i = 0; i < numberOfItems; i++)
            {
                rnd.Next(1, 19);
                featuredProducts.Add(GetObject<ProductDAO>(URL + "Products/" + int.Parse(rnd.ToString())));
            }
            return featuredProducts;
        }


        
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
