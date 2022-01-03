using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace KoreanStore.Domain
{
     public class ShoppingLogic 
    {

        private readonly SqlConnection connection = new SqlConnection("Data source = LAPTOP-16481HHS\\SQLEXPRESS; initial Catalog = P0 Project; integrated security = true");
        string query;
        
        public ShoppingLogic()
        {
        }

        public List<Customer> GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        public int customerLogin(string cUsername,string cPassword)
        {
            int customerIdFound;
            query = $"SELECT * FROM Customer WHERE CustomerUserName = '{cUsername}' AND CustomerPassWord = '{cPassword}'";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            try
            {
                customerIdFound = Int32.Parse(dr[0].ToString());
            }
            catch(InvalidOperationException) //have to do this if the select gives nothing
            {
                customerIdFound = 0;

            }
            connection.Close();   

            return customerIdFound;
        }

        //Customer Registers
        public void customerRegister(string cFirstname, string cLastname, string cUsername, string cPassword)
        {
           
            query = $"INSERT INTO Customer(CustomerFirstName, CustomerLastName, CustomerUserName, CustomerPassWord) VALUES " +
                $"('{cFirstname}','{cLastname}','{cUsername}','{cPassword}')";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }


      public void storeList()
        {
            int sId = 0;
            string sLocation = null;
            string query = $"SELECT * FROM Store";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                Console.WriteLine(dr[0].ToString() + ": " + dr[1].ToString()); 
              /*  sId = Int32.Parse(dr[0].ToString());
                sLocation = dr[1].ToString();*/
            }
            dr.Close();
            /* try
             {
                 sId = Int32.Parse(dr[0].ToString());
                 sLocation = dr[1].ToString();
             }
             catch (InvalidOperationException) //have to do this if the select gives nothing
             {
                 sId = 0;

             }*/
            
            
            //return sLocation;            
        }

        public string storeLocation(int sId)
        {
            string sLocation = null;
            string query2 = $"SELECT StoreLocation FROM Store WHERE StoreId = {sId}";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query2, connection);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(dr[0].ToString());
                /*  sId = Int32.Parse(dr[0].ToString());
                  sLocation = dr[1].ToString();*/
            }
            dr.Close();
            return sLocation;
        }

        public void productInventory()
        {
            string query = "SELECT * FROM Product";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(dr[0].ToString() + ": " 
                    + dr[1].ToString() + ": " 
                    + dr[2].ToString() + ": "
                    + dr[3].ToString());
            }
            dr.Read();
        }
                
        public void customerPastPurchase()
        {
            
            string query = $"SELECT * FROM Customer left join PastOrders";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {

            }
            dr.Read();

        }    

        public void shoppingCart()
        {
            string query = $"OrderID INT PRIMARY KEY IDENTITY,CustomerID INT FOREIGN KEY REFERENCES Customer(CustomerID),StoreID INT FOREIGN KEY REFERENCES Store(StoreID), ProductID INT FOREIGN KEY REFERENCES Product(ProductID), ProductName nvarchar(25),ProductQuantity INT,ProductPrice DECIMAL(6, 2),ProductTotal AS CONVERT(DECIMAL(6, 2), ProductQuantity * roductPrice)";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

            }
            dr.Read();
        }
       
    }

}