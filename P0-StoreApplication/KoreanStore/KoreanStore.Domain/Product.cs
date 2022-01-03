using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoreanStore.Domain
{
    public class Product
    {
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public string ProductDescription { get; set; }
        public int ProductQuantity { get; set; }
        public int ProductId { get; set; }
        public ICollection<Product> MyProperty { get; set; }


        public Product()
        {

        }
        public Product(int pId, string pName, double pPrice, int pQuantity, string pDescription)
        {
            this.ProductId = pId;
            this.ProductName = pName;
            this.ProductPrice = pPrice;
            this.ProductQuantity = pQuantity;
            this.ProductDescription = pDescription;

        }



        public void ProductShopping(int pId, double pPrice, int pQuantity)
        {
            
        }

        public List<Product> ListProduct()
        {
            List<Product> listProducts = new List<Product>();
            Product product01 = new Product();
            {
                product01.ProductId = 001;
                product01.ProductName = "White Rice";
                product01.ProductPrice = 17.99;
                product01.ProductDescription = "15 lbs of Rheechun Rice bag";
            }

            Product product02 = new Product();
            {
                product02.ProductId = 002;
                product02.ProductName = "Ramen";
                product02.ProductPrice = 4.99;
                product02.ProductDescription = "4 packs of spicy Shin Ramen";
            }

            Product product03 = new Product();
            {
                product03.ProductId = 003;
                product03.ProductName = "Soy Sauce";
                product03.ProductPrice = 10.99;
                product03.ProductDescription = "930 ml of Organic Sempio Soy Sauce";
            }

            Product product04 = new Product();
            {
                product04.ProductId = 004;
                product04.ProductName = "Kimchi";
                product04.ProductPrice = 16.99;
                product04.ProductDescription = "3 lbs of Jongga Korean Cabbage Kimchi";
            }

            Product product05 = new Product();
            {
                product05.ProductId = 005;
                product05.ProductName = "SoyBean Paste";
                product05.ProductPrice = 3.99;
                product05.ProductDescription = "15.9 oz of Sunchang SoyBean Paste";
            }

            Product product06 = new Product();
            {
                product06.ProductId = 006;
                product06.ProductName = "Pancake Powder";
                product06.ProductPrice = 4.99;
                product06.ProductDescription = "2.2 lbs of Korean pancake mix powder";
            }

            Product product07 = new Product();
            {
                product07.ProductId = 007;
                product07.ProductName = "Tofu";
                product07.ProductPrice = 2.99;
                product07.ProductDescription = "14 oz of Pulmuone Organic Tofu";
            }

            Product product08 = new Product();
            {
                product08.ProductId = 008;
                product08.ProductName = "Dumpling";
                product08.ProductPrice = 10.99;
                product08.ProductDescription = "24oz of CJ Beef Vegetable Dumpling";
            }

            Product product09 = new Product();
            {
                product09.ProductId = 009;
                product09.ProductName = "Corn Syrup";
                product09.ProductPrice = 2.99;
                product09.ProductDescription = "24.7oz of Chunjungone Corn syrup";
            }

            Product product10 = new Product();
            {
                product10.ProductId = 010;
                product10.ProductName = "RedPepper Paste";
                product10.ProductPrice = 5.99;
                product10.ProductDescription = "1.1lbs of Sunchang Red Pepper Paste";
            }

            Product product11 = new Product();
            {
                product11.ProductId = 011;
                product11.ProductName = "Sesame Oil";
                product11.ProductPrice = 5.99;
                product11.ProductDescription = "370oz of Ottogi Sesame Oil";
            }
            listProducts.Add(product01);
            listProducts.Add(product02);
            listProducts.Add(product03);
            listProducts.Add(product04);
            listProducts.Add(product05);
            listProducts.Add(product06);
            listProducts.Add(product07);
            listProducts.Add(product08);
            listProducts.Add(product09);
            listProducts.Add(product10);
            listProducts.Add(product11);
            int count = 1;
            foreach (Product product in listProducts) 
            {
                Console.WriteLine("Product " + count + " ID: " + product.ProductId + " Name: " + product.ProductName + " Price: " 
                    + product.ProductPrice + " Description: " + product.ProductDescription);
                count++;
            }
            return listProducts;
        }       
    }
}

