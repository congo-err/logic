using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Congo.Logic.Models
{
    public class CartDAO
    {
        [Required]
        public CustomerDAO Customer { get; set; }
        public List<ProductDAO> Products { get; set; }
    }
}
