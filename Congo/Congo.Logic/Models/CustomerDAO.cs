using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Congo.Logic.Models
{
    public class CustomerDAO
    {
        [Required]
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public AccountDAO Account { get; set; }
        public AddressDAO Address { get; set; }
    }
}
