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
        public int CustomerID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public AccountDAO Account { get; set; }
        public AddressDAO Address { get; set; }
    }
}
