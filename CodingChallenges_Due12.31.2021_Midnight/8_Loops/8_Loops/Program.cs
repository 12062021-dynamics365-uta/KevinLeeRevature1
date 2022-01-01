using System;
using System.Collections.Generic;

namespace _8_LoopsChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /* Your code here */

        }

        /// <summary>
        /// Return the number of elements in the List<int> that are odd.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int UseFor(List<int> x)
        {
            //throw new NotImplementedException("UseFor() is not implemented yet.");

            int odd = 0;
            for (int i=0; i < x.Count; i++)
            {
                if(x[i]%2 != 0)
                {
                    odd++;
                }
            }
            return odd;

        }

        /// <summary>
        /// This method counts the even entries from the provided List<object> 
        /// and returns the total number found.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int UseForEach(List<object> x)
        {
            //throw new NotImplementedException("UseForEach() is not implemented yet.");

            int even = 0;
            foreach(object j in x)
            {
                if(Int64.TryParse(j.ToString(), out long i))
                {
                    if(i%2 == 0)
                    { 
                        even++;
                    }
                }
            }
            return even;
        }

        /// <summary>
        /// This method counts the multiples of 4 from the provided List<int>. 
        /// Exit the loop when the integer 1234 is found.
        /// Return the total number of multiples of 4.
        /// </summary>
        /// <param name="x"></param>
        public static int UseWhile(List<int> x)
        {
            //throw new NotImplementedException("UseFor() is not implemented yet.");
            int multiplefour = 0;
            bool int1234found = false;

            do
            {
                foreach(int i in x)
                if(i==1234)
                {
                    int1234found = true;
                        break;
                }
                else if(i%4 == 0)
                {
                    multiplefour++;
                }
            } while (int1234found == false);
            return multiplefour;
        }

        /// <summary>
        /// This method will evaluate the Int Array provided and return how many of its 
        /// values are multiples of 3 and 4.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int UseForThreeFour(int[] x)
        {
           //throw new NotImplementedException("UseForThreeFour() is not implemented yet.");

            int threeandfour = 0;
            foreach (int i in x)

            if ((i%3 == 0) && (i%4 == 0))
            {
                threeandfour += 1; 
            }
            return threeandfour;
        }

        /// <summary>
        /// This method takes an array of List<string>'s. 
        /// It concatenates all the strings, with a space between each, in the Lists and returns the resulting string.
        /// </summary>
        /// <param name="stringListArray"></param>
        /// <returns></returns>
        public static string LoopdyLoop(List<string>[] stringListArray)
        {
            // throw new NotImplementedException("LoopdyLoop() is not implemented yet.");
            string neo = "";

            foreach(List<string>s in stringListArray)
            {
                foreach( string s2 in s)
                {
                    neo += (s2 + " ");
                }
            }
            return neo;
        }
    }
}