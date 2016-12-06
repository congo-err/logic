using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Congo.Logic.Models
{
    public class ProductDAO
    {
        public int ProductID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImaginePath { get; set; }
        public string Name { get; set; }
    }
}
