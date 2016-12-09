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
        public AccountDAO confirmRole(int id)
        {
            if(id == 2)
            {
                return new AccountDAO { UserName = "TestPass", Role = "Customer", AccountID = 2 };
            }
            else
            {
                return new AccountDAO();
            }
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
            featured.Add(new ProductDAO { ProductID = 2, Name = "saw", Description = "this is a saw", Price = decimal.Parse("13.13") });
            return featured;
        }

        public CartProduct AddToCart(CartProduct cart)
        {
            if(cart.CustomerID == 0)
            {
                return new CartProduct { success = false};
            }
            else
            {
                return new CartProduct { success = true};
            }
        }

        public Login LogIn(AccountDAO account)
        {
            if(account.AccountID == 1)
            {
                return new Login { account = account, success = true };
            }
            if(account.AccountID == 2)
            {
                return new Login { account = account, success = false };
            }
            else
            {
                return new Login { };
            }
        }

        public List<ProductDAO> getProducts()
        {
            var x =  new List<ProductDAO>();
            x.Add(new ProductDAO { Name = "123" });
            return x;
        }
        public List<OrderDAO> getAllOrders()
        {
            var x = new List<OrderDAO>();
            x.Add(new OrderDAO { OrderID = 1 });
            return x;
        }
        public List<OrderDAO> CustomerOrderHistory(int customerID)
        {
            var x = new List<OrderDAO>();
            x.Add(new OrderDAO { OrderID = 1 });
            return x;
        }

        public CartProduct deleteCartItem(int cartid, int productid)
        {
            if (cartid == 1)
            {
                CartProduct x = new CartProduct { CustomerID = 1, CartID = 1, ProductID =2, success = true };
                return x;
            }
            else
            {
                CartProduct y = new CartProduct { CartID = 2 };
                return y;
            }

        }


        public CartProduct ClearCart(int customerID)
        {
            return new CartProduct();
        }

        public OrderRequest CreateOrder(OrderRequest order)
        {
            return order;
        }

        public ProductDAO GetSingleProduct(int id)
        {
            return new ProductDAO();
        }
    }
}
