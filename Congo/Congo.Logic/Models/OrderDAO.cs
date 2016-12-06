using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Congo.Logic.Models
{
    public class OrderDAO
    {
        public int OrderID { get; set; }
        public CustomerDAO Customer { get; set; }
        public DateTime OrderDate { get; set; }
        public string StripeID { get; set; }
        public AddressDAO ShippingAddress { get; set; }
    }
}
