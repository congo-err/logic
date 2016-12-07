using Congo.Logic.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Congo.Logic
{
    public partial class Service : IGetServices
    {

        /// <summary>
        /// Takes a CartProduct object, and passes to another API to handle deleteing an item from the card
        /// </summary>
        /// <param name="cart"></param>
        /// <returns></returns>
        public bool deleteCartItem(CartProduct cart)
        {
            return DeleteObject<CartProduct>(URL + "Cart", cart);
        }



        /// <summary>
        /// Generic helper method to do http delete operations
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        /// <param name="extra"></param>
        /// <returns></returns>
        private bool DeleteObject<T>(string url, T extra) where T : class, new()
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
            MemoryStream stream = new MemoryStream();
            serializer.WriteObject(stream, extra);
            stream.Position = 0;
            StreamReader reader = new StreamReader(stream);
            HttpResponseMessage response = client.DeleteAsync(url).Result;
            return response.IsSuccessStatusCode;
        }
    }
}
