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
        [Required(ErrorMessage = "Field is required")]
        [Range(1,int.MaxValue)]
        public int CustomerID { get; set; }

        [Required(ErrorMessage = "Field is required")]
        [Range(1,int.MaxValue)]
        public int ProductID { get; set; }
    }
}
