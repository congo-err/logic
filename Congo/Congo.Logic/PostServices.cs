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

namespace Congo.Logic
{
    public partial class Service
    {
        public bool AddCart(CartDAO cart)
        {
            return PostObject(URL + "Cart", cart);
        }

        public bool CreateCustomer(CustomerDAO customer)
        {
            return PostObject(URL + "Account", customer);
        }


        private bool PostObject<T>(string url, T extra) where T : class, new()
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
            MemoryStream stream = new MemoryStream();
            serializer.WriteObject(stream, extra);
            stream.Position = 0;
            StreamReader reader = new StreamReader(stream);
            StringContent content = new StringContent(reader.ReadToEnd(), Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync(url, content).Result;
            return response.IsSuccessStatusCode;
        }
    }
}
