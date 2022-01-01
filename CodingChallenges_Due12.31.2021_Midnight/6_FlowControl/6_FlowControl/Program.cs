using System;

namespace _6_FlowControl
{
    public class Program
    {
        static string username;
        static string password;
        static void Main(string[] args)
        {

        }

        /// <summary>
        /// This method gets a valid temperature between -40 asnd 135 inclusive from the user
        /// and returns the valid int. 
        /// </summary>
        /// <returns></returns>
        public static int GetValidTemperature()
        {
            //throw new NotImplementedException($"GetValidTemperature() has not been implemented.");

            string temperature;
            bool temperatureConverted = false;
            int temperatureConvertedNumber;

            //Loops stays until the user enters a vaild input number of -40 to 135. 
            do
            {
                //Same as GetAction in Activity 4, usertypes the temperature input.
                temperature = Console.ReadLine();

                //To compare the temperature string input with the temperature integer number
                temperatureConverted = Int32.TryParse(temperature, out temperatureConvertedNumber);

            } while (!temperatureConverted || temperatureConvertedNumber < -40 || temperatureConvertedNumber > 135);

            return temperatureConvertedNumber;



            /* Console.WriteLine("Type the number of the temperature beteen -40 and 135.");
             if(temperature < -40 && temperature > 135)
             {
                 Console.WriteLine("Invalid input! Type between -40 and 135.");
                 return null;
             }
             else
             {
                 return temperature;
             }*/
        }

        /// <summary>
        /// This method has one int parameter
        /// It prints outdoor activity advice and temperature opinion to the console 
        /// based on 20 degree increments starting at -20 and ending at 135 
        /// n < -20, Console.Write("hella cold");
        /// -20 <= n < 0, Console.Write("pretty cold");
        ///  0 <= n < 20, Console.Write("cold");
        /// 20 <= n < 40, Console.Write("thawed out");
        /// 40 <= n < 60, Console.Write("feels like Autumn");
        /// 60 <= n < 80, Console.Write("perfect outdoor workout temperature");
        /// 80 <= n < 90, Console.Write("niiice");
        /// 90 <= n < 100, Console.Write("hella hot");
        /// 100 <= n < 135, Console.Write("hottest");
        /// </summary>
        /// <param name="temp"></param>
        public static void GiveActivityAdvice(int temp)
        {
            //throw new NotImplementedException($"GiveActivityAdvice() has not been implemented.");

            //Used switch statement in order to reduce the amount of else-if statement.
            switch (temp)
            {
                case int when temp < -20:
                    Console.WriteLine("hella cold");
                    break;

                case int when temp >= -20 && temp < 0:
                    Console.WriteLine("pretty cold");
                    break;

                case int when temp >= 0 && temp < 20:
                    Console.WriteLine("cold");
                    break;

                case int when temp >= 20 && temp < 40:
                    Console.Write("thawed out");
                    break;

                case int when temp >= 40 && temp < 60:
                    Console.Write("feels like Autumn");
                    break;

                case int when temp >= 60 && temp < 80:
                    Console.Write("perfect outdoor workout temperature");
                    break;

                case int when temp >= 80 && temp < 90:
                    Console.Write("niiice");
                    break;

                case int when temp >= 90 && temp < 100:
                    Console.Write("hella hot");
                    break;

                case int when temp >= 100 && temp < 135:
                    Console.WriteLine("hottest");
                    break;
            }

        }


        /// <summary>
        /// This method gets a username and password from the user
        /// and stores that data in the global variables of the 
        /// names in the method.
        /// </summary>
        public static void Register()
        {
            //throw new NotImplementedException($"Register() has not been implemented.");

            //User types the username
            Console.WriteLine("Type you username to register");
            string username = Console.ReadLine();

            //User types the password 
            Console.WriteLine("Type you password to register");
            string password = Console.ReadLine();

            Console.WriteLine($"saved: username:{username} password:{password}");

        }

        /// <summary>
        /// This method gets username and password from the user and
        /// compares them with the username and password names provided in Register().
        /// If the password and username match, the method returns true. 
        /// If they do not match, the user is reprompted for the username and password
        /// until the exact matches are inputted.
        /// </summary>                                                                                                                                                                                                                                                                                                                                                                                                                  
        /// <returns></returns>
        public static bool Login()
        {
            string username1 = Console.ReadLine();
            string password1 = Console.ReadLine();
            if (username1 == username && password1 == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// This method has one int parameter.
        /// It checks if the int is <=42, Console.WriteLine($"{temp} is too cold!");
        /// between 43 and 78 inclusive, Console.WriteLine($"{temp} is an ok temperature");
        /// or > 78, Console.WriteLine($"{temp} is too hot!");
        /// For each temperature range, a different advice is given. 
        /// </summary>
        /// <param name="temp"></param>
        public static void GetTemperatureTernary(int temp)
        {
            // throw new NotImplementedException($"GetTemperatureTernary() has not been implemented.");

            var result = temp <= 42 ? $"{temp} is too cold!" :
                temp >= 43 && temp <= 78 ? $"{temp} is an ok temperature" :
                 temp > 78 ? $"{temp} is too hot!" : "no result";
            Console.WriteLine(result);
        }        
    }//EoP
}//EoN
