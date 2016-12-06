using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Congo.Logic.Models
{
    public class CategoryDAO
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public List<ProductDAO> Products { get; set; }
    }
}
