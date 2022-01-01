using System;

namespace _4_MethodsChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string name = GetName();
            Console.WriteLine(GreetFriend(name));

            Console.WriteLine(DoAction(GetNumber(), GetNumber(), GetAction()));

            Console.WriteLine(" || Above is the solution.");
        }

        public static string GetName()
        {
            //throw new NotImplementedException("GetName() is not implemented yet");
            Console.WriteLine("Hello, what is your name?");

            //User types the name with string input
            return Console.ReadLine(); 
        }

        public static string GreetFriend(string name)
        {
            //throw new NotImplementedException("GreetFriend() is not implemented yet");

            //Returns agreeting message with the string of name.
            return "Hello, " + name + ". You are my friend.";

            //return $"Hello, {name}. You are my friend"; //Another solution
        }

        public static double GetNumber()
        {
            //throw new NotImplementedException("GetNumber() is not implemented yet");
            Console.WriteLine("Type the number");
            //Converts the string number input to double number. 
            return Convert.ToDouble(Console.ReadLine());

        }

        public static int GetAction()
        {
            //throw new NotImplementedException("GetAction() is not implemented yet");
             Console.WriteLine("Please choose one of the following: \n[1]Addition \n[2]Subtraction \n[3]Multiplcation \n[4]Division");

            string userSelection;
            bool userSelectionConverted = false;
            int userSelectionConvertedNumber;

            //The menu selection stays until the valid input is typed 
            do
            {

                //User types the string
                userSelection = Console.ReadLine();

                //To compare the string input with the interger selection
                userSelectionConverted = Int32.TryParse(userSelection, out userSelectionConvertedNumber);               
               
            } while (!userSelectionConverted || userSelectionConvertedNumber < 1 || userSelectionConvertedNumber > 4);
           
            //Return the menu selection 1 to 4.
            if(userSelectionConvertedNumber >= 1 || userSelectionConvertedNumber <= 4)
            {
                return userSelectionConvertedNumber;
            }
            //If the input is not valid, return default value which is 0.
            else
            {
                Console.WriteLine("Invalid input! Please type the valid number!(1-4)");
                GetAction();
                return 0;
            }

        }

        public static double DoAction(double x, double y, int action)
        {
            if (action < 1 || action > 4)             
                throw new FormatException();        
                

            //throw new NotImplementedException("DoAction() is not implemented yet");
            double z = 0;
            switch (action)
            {                           
                //select for addition
                case 1:
                    Console.WriteLine("You selected addition.");
                    z = x + y;
                    return z;
                    break;
                                                                       
                //select for subtraction
                case 2:
                    Console.WriteLine("You selected subtraction.");
                    z = y - x;
                    return z;
                    break;

                //select for multiplciation
                case 3:
                    Console.WriteLine("You selected multiplciation.");
                    z = x * y;
                    return z;
                    break;

                //select for division
                case 4:
                    Console.WriteLine("You selected division.");
                    try
                    {
                        z = (x / y);
                        
                    }
                    catch (ArithmeticExceptions ae) //In case the division is divided to zero to catch exception.
                    //And the README gave the name of the exception as: "Arithmetic Exceptions".
                    {
                        Console.WriteLine("You can't divide to zero!");                       
                    }
                    return z;
                    break;
                    

                default:
                    return 0;
                    break;
            }          
        }
    }
}
        
    


