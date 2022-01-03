using System;
using System.Data.SqlClient;
using KoreanStore.Domain;

namespace KoreanStore.Client
{

    class Program
    {
        
        // Customer enters the first menu    
        static void firstMenu()
        {           
            string customerFirstMenuInput;
            bool firstMenuInput = false;
            int firstMenuConvertedNumber = 0;

            do

            {
                Console.WriteLine("Please select of the following: \n[1]To Login \n[2]To Register \n[0]To Exit");
                customerFirstMenuInput = Console.ReadLine();
                firstMenuInput = Int32.TryParse(customerFirstMenuInput, out firstMenuConvertedNumber);

                //Customer types the wrong input
                if (!firstMenuInput || firstMenuConvertedNumber < 0 || firstMenuConvertedNumber > 2)
                {
                    Console.WriteLine("Invalid input! Please type the input (0 or 1 - 2)");
                }

            } while (!firstMenuInput || firstMenuConvertedNumber < 0 || firstMenuConvertedNumber > 2);

            switch (firstMenuConvertedNumber)
            {
                //Customer login
                case 1:
                    login();
                    break;

                //Customer register
                case 2:
                   registerMenu();
                    break;

                //Customer exits the program
                case 0:
                    Console.WriteLine("Thank You! have a nice day!");
                    Environment.Exit(0);
                    break;
            }
        }

        //Customer logs in (Credit for Robert Sharp and Jamie Schwartz)
        static int login()
        {
            int customerIdFound = 0;
            ShoppingLogic shoppingLogic = new ShoppingLogic();
             
              //Customer types the username 
              Console.WriteLine("Type the username");
              Console.WriteLine("-----------------");
              string cUsername = Console.ReadLine();

               //Customer types the password
               Console.WriteLine("Type the password");
               Console.WriteLine("-----------------");
               string cPassword = Console.ReadLine();
               customerIdFound = shoppingLogic.customerLogin(cUsername, cPassword);


            //If the customer id is not found
            if (customerIdFound == 0)
            {
                loginFailedMenu();

            }
            //Else, the system lets you to the storeMainMenu.
            else
            {
                storeMainMenu();
                
            }
            return customerIdFound;
        }

        //When the login failed 
        static void loginFailedMenu()
        {
            string customerLoginFailedMenuInput;
            bool loginFailedMenuInput = false;
            int loginFailedMenuConvertedNumber = 0;

            do

            {
                Console.WriteLine("Login failed! Please select of the following: \n[1]To Register \n[0]To go back to first menu");
                customerLoginFailedMenuInput = Console.ReadLine();
                loginFailedMenuInput = Int32.TryParse(customerLoginFailedMenuInput, out loginFailedMenuConvertedNumber);

                //Customer types the wrong input
                if (!loginFailedMenuInput || loginFailedMenuConvertedNumber < 0 || loginFailedMenuConvertedNumber > 1)
                {
                    Console.WriteLine("Invalid input! Please type the input (0 or 1)");
                }

            } while (!loginFailedMenuInput || loginFailedMenuConvertedNumber < 0 || loginFailedMenuConvertedNumber > 1);

            switch (loginFailedMenuConvertedNumber)
            {
                //User to register
                case 1:
                    registerMenu();
                    break;

                //Go back to the first menu
                case 0:
                    firstMenu();
                    break;
            }

        }

        //New customer registering 
        static void registerMenu()
        {
            ShoppingLogic customerRegister = new ShoppingLogic();


            Console.WriteLine("Type your first name");
            Console.WriteLine("------------------");
            string cFirstname = Console.ReadLine();

            Console.WriteLine("Type your last name");
            Console.WriteLine("------------------");
            string cLastname = Console.ReadLine();

            Console.WriteLine("Type your username");
            Console.WriteLine("------------------");
            string cUsername = Console.ReadLine();

            Console.WriteLine("Type your password");
            Console.WriteLine("------------------");
            string cPassword = Console.ReadLine();

            customerRegister.customerRegister(cFirstname, cLastname, cUsername, cPassword);
            Console.WriteLine("Your register successed!");

            storeMainMenu();
        }


        //Customer enters MainMenu after successfully logging in or registering.
        static void storeMainMenu() //(Credit for Aldo Ramirez)
        {

            string customerMainMenuInput;
            bool mainMenuInput = false;
            int mainMenuConvertedNumber = 0;

            do

            {
                Console.WriteLine("Please select of the following: \n[1]To Select your location \n[2]To view your past order \n[0]To logout and go back to first menu");
                customerMainMenuInput = Console.ReadLine();
                mainMenuInput = Int32.TryParse(customerMainMenuInput, out mainMenuConvertedNumber);

                //Customer types the wrong input
                if (!mainMenuInput || mainMenuConvertedNumber < 0 || mainMenuConvertedNumber > 2)
                {
                    Console.WriteLine("Invalid input! Please type the input (0 or 1 - 2)");
                }

            } while (!mainMenuInput || mainMenuConvertedNumber < 0 || mainMenuConvertedNumber > 2);

            switch (mainMenuConvertedNumber)
            {
                //To proceed to purchase menu customer selects the store
                case 1:
                    selectStoreMenu();
                    break;

                //To look at customer's past pruchase
                case 2:
                    customerPastPurchase();
                    break;

                //To return the first menu
                case 0:
                    firstMenu();
                    break;
            }

        }

        //Customer wants to see one's past order
        static void customerPastPurchase()
        {
            Console.WriteLine("Your past purchases are: ");


            storeMainMenu();

        }

        //The customer chooses the location 
        static int selectStoreMenu()
        {
           
            
            ShoppingLogic shoppingLogic = new ShoppingLogic();
            
            Console.WriteLine("Please choose one of the store location or press [0] to go back to store main menu.");
            shoppingLogic.storeList();
            string selectStoreMenuInput;
            bool selectStoreMenuConverted = false;
            int selectStoreMenuConvertedNumber = 0;
            do
            {
                selectStoreMenuInput = Console.ReadLine();
                selectStoreMenuConverted = Int32.TryParse(selectStoreMenuInput, out selectStoreMenuConvertedNumber);

                //Customer types the wrong input
                if (!selectStoreMenuConverted || selectStoreMenuConvertedNumber < 0 || selectStoreMenuConvertedNumber > 4)
                {
                    Console.WriteLine("Invalid input! Please type the input (0 or 1 - 4)");
                }

            } while (!selectStoreMenuConverted || selectStoreMenuConvertedNumber < 0 || selectStoreMenuConvertedNumber > 4);

            int sId = selectStoreMenuConvertedNumber;
           string sLocation = null;
            //selectStoreMenuConvertedNumber = shoppingLogic.storeList();
            
           if(selectStoreMenuConvertedNumber == 0)
            {
                storeMainMenu();
            }
            else {
              chosenStoreMenu(sId, sLocation);
            }
            return selectStoreMenuConvertedNumber;
            
        }

            

            //Customer enters a certain store after choosing the location of the store 
            static void chosenStoreMenu(int sId, string sLocation) //(Credit for Aldo Ramirez)
            {
             ShoppingLogic shoppingLogic = new ShoppingLogic();
            //Console.WriteLine(shoppingLogic.storeLocation());
             Console.WriteLine("Welcome to our store #" + sId + ". " + sLocation + " area. Please choose the following " +
                     "\n[1]To do shopping \n[2]To look the past purchase of a certain store \n[0]Return to the Main menu");
             string chosenStoreMenuInput;
             bool chosentStoreMenuConverted = false;
             int chosenStoreMenuConvertedNumber = 0;
             do
             {
                 chosenStoreMenuInput = Console.ReadLine();
                 chosentStoreMenuConverted = Int32.TryParse(chosenStoreMenuInput, out chosenStoreMenuConvertedNumber);

                 //Customer types the wrong input
                 if (!chosentStoreMenuConverted || chosenStoreMenuConvertedNumber < 0 || chosenStoreMenuConvertedNumber > 2)
                 {
                     Console.WriteLine("Invalid input! Please type the input (0 or 1 - 2)");
                 }

             } while (!chosentStoreMenuConverted || chosenStoreMenuConvertedNumber < 0 || chosenStoreMenuConvertedNumber > 2);


             switch (chosenStoreMenuConvertedNumber)
                 {
                     //Customer starts shopping
                     case 1:
                         shoppingCartMenu();
                         break;

                     //To look at the past purchase of a certain store
                     case 2:
                         storePastPurchase(sId, sLocation);
                         break;                

                     //Back to the Main menu in the main program
                        case 0:
                        selectStoreMenu();
                        break;
                 }

             }

        //Customer wants to see the past order
            static void storePastPurchase(int sId, string sLocation)
              {
                  Console.WriteLine("The history of the store #" + sId + ". " + sLocation + " area is:");
                  /*query = $"SELECT * FROM Store left join PastOrders";
                  connection.Open();
                  SqlCommand cmd = new SqlCommand(query, connection);
                  SqlDataReader dr = cmd.ExecuteReader();
                  while (dr.Read())
                  {

                  }
                  dr.Read();
                  connection.Close();*/
                 chosenStoreMenu(sId, sLocation);
              }

            //Customer shopping menu displays with shoppingcart
             static void shoppingCartMenu() 
              {
                  int totalCartQuantityProducts = 0;
                  double totalCartPrice = 0.00;

                  string customerShoppingMenuInput;
                  bool shoppingMenuInput = false;
                  int shoppingMenuConvertedNumber = 0;

                  do

                  {
                      Console.WriteLine($"Here is your shopping cart:" +
                          $"\nNumber of Products: {totalCartQuantityProducts}" +
                          $"\nTotal cost: ${totalCartPrice}");

                      Console.WriteLine("Shop till you drop! Select your option while you shop: \n[1]To Add Products \n[2]To Remove Products \n[3]To Proceed to checkout \n[0]To go back to the chosen store menu");
                      customerShoppingMenuInput = Console.ReadLine();
                      shoppingMenuInput = Int32.TryParse(customerShoppingMenuInput, out shoppingMenuConvertedNumber);

                      //Customer types the wrong input
                      if (!shoppingMenuInput || shoppingMenuConvertedNumber < 0 && shoppingMenuConvertedNumber > 3)
                      {
                          Console.WriteLine("Invalid input! Please type the input (0 or 1 - 3)");
                      }

                  } while (!shoppingMenuInput || shoppingMenuConvertedNumber < 0 && shoppingMenuConvertedNumber > 3);

                  switch(shoppingMenuConvertedNumber)
                  {
                      //To add products in the cart
                      case 1:
                          customerAddProducts();
                    
                    break;

                      //To remove products in the cart
                      case 2:
                          customerRemoveProducts();
                          break;

                      //Proceed to checkout
                      case 3:
                         // checkoutMenu();
                          break;

                      case 0:
                         //chosenStoreMenu();
                          break;
                  }
              }

            //Customer wants to add a product
            static void customerAddProducts()
            {

            //Constructor for each product
            int quantityOrder = 0;
            
            double productPrice = 0.00;
            double productTotalPrice;


            //Constructor for shoppingcart
            //int totalCartQuantityProducts = shoppingCartMenu(totalCartQuantityProducts);
            //double totalCartPrice = shoppingCartMenu(totalCartPrice);

            string customerAddProductInput;
            bool addProductInputConverted = false;
            int addProductConvertedNumber = 0;

            string customerAddProductConfirmInput;
            bool addProductInputConfirmConverted = false;
            int addProductConfirmConvertedNumber = 0;


            Console.WriteLine("Select a product which you want to add (1 - 11) or [0] to go back to shopping cart menu");
                ShoppingLogic productInventory = new ShoppingLogic();
                productInventory.productInventory();

            do
            {
                customerAddProductInput = Console.ReadLine();
                addProductInputConverted = Int32.TryParse(customerAddProductInput, out addProductConvertedNumber);

                //Customer chooses the product
                if (!addProductInputConverted || addProductConvertedNumber < 1 || addProductConvertedNumber > 11)
                {
                    Console.WriteLine("Invalid input! Please type the input (1 - 11)");
                }

            } while (!addProductInputConverted || addProductConvertedNumber < 1 || addProductConvertedNumber > 11);


            //System asks the customer if the product wants to add the shopping cart.
            Console.WriteLine("You chose product #" + addProductConvertedNumber + ". Is that correct?" +
                "\n[1]Yes \n[2]No");

            do
            {
                customerAddProductConfirmInput = Console.ReadLine();
                addProductInputConfirmConverted = Int32.TryParse(customerAddProductConfirmInput, out addProductConfirmConvertedNumber);

                //Customer chooses the product
                if (!addProductInputConfirmConverted || addProductConfirmConvertedNumber < 1 || addProductConfirmConvertedNumber > 2)
                {
                    Console.WriteLine("Invalid input! Please type the input (1 - 2)");
                }

            } while (!addProductInputConfirmConverted || addProductConfirmConvertedNumber < 1 || addProductConfirmConvertedNumber > 2);


            //System asks how many to add
            if(addProductConfirmConvertedNumber == 1)
            {
                Console.WriteLine("How many do you want to add?");
                string customerQuantityOrder = Console.ReadLine();
                Int32.TryParse(customerQuantityOrder, out quantityOrder);
                productTotalPrice = productPrice * (double)quantityOrder;

                //Updates shopping cartmenu
                //shoppingCartMenu().totalCartQuantityProducts += totalCartQuantityProducts;
                //shoppingCartMenu().totalCartPrice += totalCartPrice;
                shoppingCartMenu();
                
            }

            //The customer does not want to add a product
            else 
            {
                customerAddProducts();
            }

        }

        //Remove the product
        static void customerRemoveProducts()
        {
            Console.WriteLine("Select a product which you want to remove");
            int productRemoveFromCart;

        }

        //Customer Proceed to the checkout
       /* static void checkoutMenu()
         {
             string customerCheckoutMenuInput;
             bool checkoutMenuInput = false;
             int checkoutMenuConvertedNumber = 0;

             do

             {
                 Console.WriteLine("Do you want to proceed to checkout?: \n[1]Yes \n[0]No,To go back to the shopping cart menu");
                 customerCheckoutMenuInput = Console.ReadLine();
                 checkoutMenuInput = Int32.TryParse(customerCheckoutMenuInput, out checkoutMenuConvertedNumber);

                 //Customer types the wrong input
                 if (!checkoutMenuInput || checkoutMenuConvertedNumber < 0 || checkoutMenuConvertedNumber > 1)
                 {
                     Console.WriteLine("Invalid input! Please type the input (0 or 1)");
                 }

             } while (!checkoutMenuInput || checkoutMenuConvertedNumber < 0 || checkoutMenuConvertedNumber > 1);
            switch (checkoutMenuConvertedNumber)
             {
                 //To proceed to purchase the order
                 //The system will not let the customer to proceed if the number of items are more than 50 
                 //or the total price of more than $500.
                 case 1:
                if(totalCartQuantityProducts > 50 || totalCartPrice > 500)
                {
                    Console.WriteLine("I'm sorry, but we are unable to proceed your purchase with more than 50 items or " +
                        "the total cost of $500.");
                        checkoutMenu();
                }

                else if(totalCartQuantityProducts > 0 || totalCartPrice > 0)
                {
                    Console.WriteLine("You don't have anything to purchase.");
                    checkoutMenu();
                 }

                //Else, the system will let you proceed
                else 
                {
                    paymentMenu();
                }

                break;

                 //Customer not ready to proceed to checkout 
                 case 0:
                     shoppingCartMenu();
                     break;
             }                          
         }*/

        //Customer is willing to pay
        static void paymentMenu()
         {
           Console.WriteLine("Type the credit card number");

         }


        static void Main(string[] args)
            {
            ShoppingLogic shoppingLogic = new ShoppingLogic();

            Console.WriteLine("Welcome to Kevin's Korean Store");
            firstMenu();

         
        }                  
    }
}