using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace KoreanStore.Domain
{
    internal class Mapper : IMapper
    {
        public List<Customer> EntityToCustomerList(SqlDataReader dr)
        {
            List<Customer> customers = new List<Customer>();
            while(dr.Read())
            {
                Customer c = new Customer()
                {
                    CustomerId = Convert.ToInt32(dr[0].ToString()),
                    CustomerFirstName = dr[1].ToString(),
                    CustomerLastName = dr[2].ToString(),
                    CustomerUsername = dr[3].ToString(),
                    CustomerPassword = dr[4].ToString()
                };
                customers.Add(c);
            }
            return customers;
        }

        public List<Store> EntityToStoreList(SqlDataReader dr)
        {
            List<Store> stores = new List<Store>();
            while(dr.Read())
            {
                Store s = new Store()
                {
                    StoreId = Convert.ToInt32(dr[0].ToString()),
                    StoreLocation = dr[1].ToString()
                };
                stores.Add(s);
            }
            return stores;
        }

        public List<Product> EntityToProductList(SqlDataReader dr)
        {
            List<Product> products = new List<Product>();
            while (dr.Read())
            {
                Product p = new Product()
                {
                    ProductId = Convert.ToInt32(dr[0].ToString()),
                    ProductName = dr[1].ToString(),
                    ProductPrice = Convert.ToInt32(dr[2].ToString()),
                    ProductDescription = dr[3].ToString()
                };
                products.Add(p);
            }
            return products;
        }

        public List<Order> EntityToOrderList(SqlDataReader dr)
        {
            List<Order> orders = new List<Order>();
            while (dr.Read())
            {
                Order o = new Order()
                {
                    OrderId = Convert.ToInt32(dr[0].ToString()),
                    OrderTotalPrice = Convert.ToInt32(dr[3].ToString()),
                    OrderTotalQuantity = Convert.ToInt32(dr[4].ToString()),
                };
                orders.Add(o);
            }
            return orders;
        }
    }
}
