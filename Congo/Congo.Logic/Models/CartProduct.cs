using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Congo.Logic.Models
{
    public class CartProduct
    {
        [Required]
        public int CustomerID { get; set; }

        [Required]
        public int ProductID { get; set; }
    }
}
