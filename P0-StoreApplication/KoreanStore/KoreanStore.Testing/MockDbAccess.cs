using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using KoreanStore.Domain;

namespace KoreanStore.Testing
{
    public class MockDbAccess : IDataBase
    {

        internal List<Customer> GetAllCustomer()
        {
            List<Customer> customers = new List<Customer>();
            Customer c1 = new Customer()
            {
                CustomerFirstName = "Elinor",
                CustomerLastName = "Peach",
                CustomerUsername = "Opalmarigold",
                CustomerPassword = "10Daegu10"
            };

            Customer c2 = new Customer()
            {
                CustomerFirstName = "Elizabeth",
                CustomerLastName = "Peach",
                CustomerUsername = "Tourmalinecosmos",
                CustomerPassword = "1010Gwangju"
            };

            Customer c3 = new Customer()
            {
                CustomerFirstName = "Emma",
                CustomerLastName = "Scarlet",
                CustomerUsername = "LibraRowantree",
                CustomerPassword = "Daejeon1010"
            };

            customers.Add(c1);
            customers.Add(c2);
            customers.Add(c3);

            return customers;
        }

        internal List<Store> GetAllStore()
        {
            List<Store> stores = new List<Store>();
            Store s1 = new Store()
            {
                StoreLocation = "Washington D.C.",

            };

            Store s2 = new Store()
            {
                StoreLocation = "Philadelphia",

            };

            Store s3 = new Store()
            {
                StoreLocation = "New York City",

            };

            Store s4 = new Store()
            {
                StoreLocation = "Boston",

            };

            stores.Add(s1);
            stores.Add(s2);
            stores.Add(s3);
            stores.Add(s4);

            return stores;

        }


        internal List<Product> GetAllProduct()
        {
            List<Product> products = new List<Product>();
            Product s1 = new Product()
            {
                ProductName = "White Rice",
                ProductPrice = 17.99,
                ProductDescription = "15 lbs of Rheechun Rice bag"

            };

            Product s2 = new Product()
            {
                ProductName = "Ramen",
                ProductPrice = 4.99,
                ProductDescription = "4 packs of spicy Shin Ramen"

            };

            Product s3 = new Product()
            {
                ProductName = "Kimchi",
                ProductPrice = 16.99,
                ProductDescription = "3 lbs of Jongga Korean Cabbage Kimchi"
            };

            Product s4 = new Product()
            {
                ProductName = "Dumpling",
                ProductPrice = 10.99,
                ProductDescription = "24 oz of CJ Beef Vegetable Dumpling"

            };

            products.Add(s1);
            products.Add(s2);
            products.Add(s3);
            products.Add(s4);

            return products;
        }


        internal List<Order> GetAllOrder()
        {
            List<Order> orders = new List<Order>();
            Order o1 = new Order()
            {
                OrderTotalPrice = 34.99,
                OrderTotalQuantity = 2,

            };
            orders.Add(o1);
            return orders;
        }
    }

    public interface IDataBase
    {
    }
}
