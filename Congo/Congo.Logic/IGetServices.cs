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
        List<ProductDAO> getProducts();
        CartDAO getCart(int ID);
        List<ProductDAO> getFeaturedItems(int numberOfItems);
        CartProduct AddToCart(CartProduct cart);
        AccountDAO confirmRole(int id);
        Login LogIn(AccountDAO account);
        List<OrderDAO> getAllOrders();
        List<OrderDAO> CustomerOrderHistory(int customerID);
    }
}
