using Congo.Logic.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Congo.Logic
{
    public partial class Service
    {
        public OrderRequest CreateOrder(OrderRequest order)
        {
            OrderRequest temp = new OrderRequest();
            temp.ProductIDs = new List<int>();
            CartDAO stuff = new CartDAO();
            stuff = getCart(order.CustomerID);
            temp.CustomerID = order.CustomerID;
            temp.StripeID = "OR_123";
            temp.AddressID = stuff.Customer.Address.AddressID;
            foreach (var item in stuff.Products)
            {
                temp.ProductIDs.Add(item.ProductID);
            }
            return PostObject<OrderRequest, OrderRequest>(URL + "Order", temp);
        }
        public CartProduct AddToCart(CartProduct cart)
        {
            return PostObject<CartProduct,CartProduct>(URL + "Cart", cart);
        }

        public bool CreateCustomer(CustomerDAO customer)
        {
            //return PostObject(URL + "Account", customer);
            return true;
        }

        public Login LogIn(AccountDAO account)
        {
            return PostObject<AccountDAO, Login>(URL + "account/try-login", account);
        }

        private X PostObject<T,X>(string url, T extra) where T : class, new()
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
            MemoryStream stream = new MemoryStream();
            serializer.WriteObject(stream, extra);
            stream.Position = 0;
            StreamReader reader = new StreamReader(stream);
            StringContent content = new StringContent(reader.ReadToEnd(), Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync(url, content).Result;
            var decoder = new JavaScriptSerializer();
            return decoder.Deserialize<X>(response.Content.ReadAsStringAsync().Result);
        }
    }
}
