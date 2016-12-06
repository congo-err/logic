using Congo.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Congo.Logic
{
    public interface IGetServices
    {
        List<CategoryDAO> getCategories();
        List<ProductDAO> getProducts(int ID);
        CartDAO getCart(int ID);
        List<ProductDAO> getFeaturedItems(int numberOfItems);
        bool AddCart(CartProduct cart);
        AccountDAO confirmRole(int id);
    }
}
