using Congo.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Congo.Logic
{
    public class dumbyService : IGetServices
    {
        public bool AddCart(CartDAO cart)
        {
            return true;
        }
        public AccountDAO confirmAccount(AccountDAO account)
        {
            AccountDAO acct = new AccountDAO();
            acct.AccountID = 1;
            acct.UserName = "TestUser";
            acct.Password = "123456";
            acct.Role = "user";
            return acct;
        }
        public List<CategoryDAO> getCategories()
        {
            List<CategoryDAO> cats = new List<CategoryDAO>();
            cats.Add(new CategoryDAO { CategoryID = 1, Name = "tools" });
            cats.Add(new CategoryDAO { CategoryID = 2, Name = "computers" });
            cats.Add(new CategoryDAO { CategoryID = 3, Name = "jewels" });
            return cats;
        }

        public List<ProductDAO> getProducts(int ID)
        {
            List<ProductDAO> products = new List<ProductDAO>();
            products.Add(new ProductDAO { ProductID = 1, Name = "hammer", Description = "this is a hammer", Price = decimal.Parse("12.12") });
            products.Add(new ProductDAO { ProductID = 2, Name = "saw", Description = "this is a saw", Price = decimal.Parse("13.13") });
            return products;
        }


        public CartDAO getCart(int ID)
        {
            CartDAO cart = new CartDAO();
            cart.Customer = new CustomerDAO();
            cart.Products = new List<ProductDAO>();
            cart.Customer.CustomerID = 3;
            cart.Customer.Name = "TestRyan";
            cart.Products.Add(new ProductDAO { ProductID = 1, Name = "hammer", Description = "this is a hammer", Price = decimal.Parse("12.12") });
            return cart;
        }

        public List<ProductDAO> getFeaturedItems(int numberOfItems)
        {
            List<ProductDAO> featured = new List<ProductDAO>();
            featured.Add(new ProductDAO { ProductID = 1, Name = "hammer", Description = "this is a hammer", Price = decimal.Parse("12.12") });
            featured.Add(new ProductDAO { ProductID = 1, Name = "saw", Description = "this is a saw", Price = decimal.Parse("13.13") });
            return featured;
        }
    }
}
