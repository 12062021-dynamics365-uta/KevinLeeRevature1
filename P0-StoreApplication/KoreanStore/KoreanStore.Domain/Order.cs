using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoreanStore.Domain
{
    public class Order
    {
        public int OrderTotalQuantity { get; set; } = 0;
        public double OrderTotalPrice { get; set; } = 0.00;
        public int OrderId { get; set; }

        public List<Product> shoppingCartList { get; set; }

        public Order() {
            this.shoppingCartList = new List<Product>();
        }


        public Order(int tQuantity, double tPrice)
        {
            this.OrderTotalQuantity = tQuantity;
            this.OrderTotalPrice = tPrice;
            this.shoppingCartList = new List<Product>();
        }


        //Customer while shopping
       /** public void shopping() //(Credit for Aldo Ramirez)
        {
            bool exitShopping = false;
            //int tQuantity = 0;
            //double tPrice = 0.00;

            do
            {
                Console.WriteLine("Shop till you drop! Select your option while you shop. " +
                    "\n[1]View your shopping cart \n[0]Cancel the shopping and go back to your store option.");
                Product productList = new Product();
                List<Product> listProducts = new List<Product>();
                int userShoppingOption = Convert.ToInt32(Console.ReadLine());
                
                switch (userShoppingOption)
                {
                    //Customer's shopping cart
                    case 1:
                        shoppingCart();
                        break;   

                     //Customer cancels the shop and goes back to the chosen shopping option
                     case 0:
                       // Store chosenStore = new Store();
                        //chosenStore.chosenStoreOption();
                         break;

                     default: 
                         Console.WriteLine("Invalid choice. Please Enter the valid choice(0 or 1)");
                         break;

                 }

             } while (exitShopping != false);

         }

        public void shoppingCart()
        {
            bool exitShoppingCart = false;
            
            do
            {
                //Console.WriteLine("Your shopping cart contains: " + tQuantity + "items and the total cost of $" + tPrice);
                Console.WriteLine("Your shopping cart contains: " + this.OrderTotalQuantity + " items and the total cost of $ " + this.OrderTotalPrice);
                Console.WriteLine("Select your option while you shop. \n[1]add products \n[2]remove products \n[3]Proceed to the checkout " +
                    "\n[0]Cancel the shopping and go back to your store option.");
                int shoppingCartInput = Convert.ToInt32(Console.ReadLine());
                switch (shoppingCartInput)
                {
                    //Customer wants to add product 
                    case 1:
                        addProduct();
                        break;

                    //Customer wants to remove product 
                    case 2:
                        removeProduct();                                    
                        break;
                    //Customer wants to proceed to the checkout
                    case 3:
                        checkout();
                        break;

                    //Customer does not to proceed to the checkout and goes back to the chosen store option
                    case 0:
                        shopping();
                        break;

                    default:
                        Console.WriteLine("Please type the valid input(0 or 1-3)");
                        shoppingCart();
                        break;
                }

            } while (exitShoppingCart == false);
        }

        private void addProduct()
        {

            Console.WriteLine("What is the item you are trying to add?(Type the product ID number)");
            Product addProductList = new Product();
            
            List<Product> pList = addProductList.ListProduct();
            // addProductList.ProductShopping(pId, pPrice, pQuantity);
           // int tQuantity = 0;
           // double tPrice = 0.00;            
            int pId = Convert.ToInt32(Console.ReadLine());
            string pName = pList[pId-1].ProductName;
            Console.WriteLine("You chose product #" + pId + ", " + pName + ". Do you want to add this item?" +
                "\n[1]Yes \n[2]No");
            int userAddProduct = Convert.ToInt32(Console.ReadLine());

            //Customer wants to add item
            
                switch (userAddProduct)
                {
                    case 1:
                    
                        this.OrderTotalQuantity += 1;
                        this.OrderTotalPrice += pList[pId - 1].ProductPrice;
                        this.shoppingCartList.Add(pList[pId - 1]);
                    
                    if(userAddProduct > 11)
                    {
                        Console.WriteLine("Invalid input! Please select the valid number of input (1-11)");
                    }                                 
                        break;
                    //Customer does not wants to add item
                    case 2:
                        shoppingCart();
                        break;
                    default:
                        Console.WriteLine("Invalid input! Please select the correct input! (1 or 2)");
                        break;
                }
        }
                           

        private void removeProduct()
        {
            Console.WriteLine("What is the item you are trying to remove?(Type the product ID number)");
            Product removeProductList = new Product();

            List<Product> pList = removeProductList.ListProduct();
            //removeProductList.ProductShopping(pId, pPrice, pQuantity);
            int pId = Convert.ToInt32(Console.ReadLine());
            string pName = pList[pId - 1].ProductName;
            Console.WriteLine("You chose product #" + pId + ", " + pName + ". Do you want to remove this item?" +
                "\n[1]Yes \n[2]No");
            int userRemoveProduct = Convert.ToInt32(Console.ReadLine());
            switch (userRemoveProduct)
            {
                //Customer wants to remove the item
                case 1:
                    //Customer's cart has no items to remove

                    this.OrderTotalQuantity -= 1;
                    this.OrderTotalPrice -= pList[pId - 1].ProductPrice;
                    this.shoppingCartList.Remove(pList[pId - 1]);

                  if(this.OrderTotalQuantity <= 0 || this.OrderTotalPrice <= 0.00)
                    {
                        Console.WriteLine("You have no item to remove. Please check your cart again.");
                        shoppingCart();
                    }
                  else
                    {
                        shoppingCart();
                    }

                    break;

                    //Customer does not want to remove the item
                    case 2:
                    shoppingCart();
                    break;
                default:
                    Console.WriteLine("Invalid input! Please select the correct input! (1 or 2)");
                    break;
            }
        }
                      
        //Customer's selection to proceed checkout
       public void checkout()
        {
            bool exitCheckout = false;
            do                
            {
                Console.WriteLine("Do you want to proceed the purchase? \n[1]Yes \n[2]No and to go back to shopping cart");
                int checkoutProceed = Convert.ToInt32(Console.ReadLine());
                switch (checkoutProceed)
                {
                    //To proceed to purchase the order
                    case 1:
                       proceedPurchase();
                        break;

                    //Customer not ready to proceed to checkout 
                    case 2:
                        
                        shoppingCart();
                        break;

                    default:
                        Console.WriteLine("Invalid input! Please type the valid input!(0, 1, 2)");
                        checkout();
                        break;

                }
            } while (exitCheckout != false);
        }

        //If the customer selects to proceed to purchase the checkout
       public void proceedPurchase()
        {
            bool exitPurchase = false;
            do
            {
                //If the cart total quantity items exceed 50 items, or total price exceed $500, the program can't proceed the purchase 
                if (this.OrderTotalQuantity > 50 || this.OrderTotalPrice > 500.00)
                {
                    Console.WriteLine("I'm sorry. We can't proceed the purchase with more than 50 items or the total cost at least $500.");
                    shoppingCart();
                }

                //If there is no item in the cart
                else if (this.OrderTotalQuantity <= 0 || this.OrderTotalPrice <= 0.00)
                {
                    Console.WriteLine("I'm sorry. We can't proceed the purchase with an empty cart");
                    shoppingCart();
                }
                //Customer proceed to pay the purchase
                else
                {

                    Console.WriteLine("Type your the card number.");
                    Customer customerCreditCard = new Customer();
                    //customerCreditCard.customerCreditCard(string cCreditCard);  
                    
                   
                }
            } while (exitPurchase != false);
        }**/
    }
}
