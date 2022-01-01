using System;
using System.Collections.Generic;

namespace _7_GuessingGameChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Kevin's magic number guess game!\n" +
                 "Type yournumber (1 - 100)");

            

        }

        /// <summary>
        /// This method returns a randomly chosen number between 1 and 100, inclusive.
        /// </summary>
        /// <returns></returns>
        public static int GetRandomNumber()
        {
            //throw new NotImplementedException();
            int magicNumber;
            Random random = new Random();
            return magicNumber = random.Next(0, 101);


        }

        /// <summary>
        /// This method gets input from the user, 
        /// verifies that the input is valid and 
        /// returns an int.
        /// </summary>
        /// <returns></returns>
        public static int GetUsersGuess()
        {
            throw new NotImplementedException();
           /* int guess;
            guess = Convert.ToInt32(Console.ReadLine());
            
            if(guess != magicNumber)*/
        }

        /// <summary>
        /// This method will has two int parameters.
        /// It will:
        /// 1) compare the first number to the second number
        /// 2) return -1 if the first number is less than the second number
        /// 3) return 0 if the numbers are equal
        /// 4) return 1 if the first number is greater than the second number
        /// </summary>
        /// <param name="randomNum"></param>
        /// <param name="guess"></param>
        /// <returns></returns>
        public static int CompareNums(int randomNum, int guess)
        {
            throw new NotImplementedException();            

           /* if (randomNum > guess)
            {
                return -1;               
            }
            else if (randomNum == guess)
            {
                return 0;
            }
            else
            {
                return 1;
            }*/
        }

        /// <summary>
        /// This method offers the user the chance to play again. 
        /// It returns true if they want to play again and false if they do not.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static bool PlayGameAgain()
        {
            //throw new NotImplementedException();
            bool playAgain;                      
            int playAgainConvertedNumber = 1;

                Console.WriteLine("Do you want to play again? \n[1]Yes \n[2]No");

                switch(playAgainConvertedNumber)
                {
                    case 1:
                        return true;
                        break;

                    case 2:
                        return false;
                        break;

                    default:
                        Console.WriteLine("Invalid input! Please type [1] for Yes, or [2]for no.");
                        break;
                }              
                
           
        }
    }
}
