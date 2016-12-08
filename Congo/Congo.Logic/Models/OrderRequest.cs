using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Congo.Logic.Models
{
    public class OrderRequest
    {
        [Required]
        public int CustomerID { get; set; }
        public int AddressID { get; set; }
        public string StripeID { get; set; }
        public List<int> ProductIDs { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
        public OrderDAO Order { get; set; }
    }
}
