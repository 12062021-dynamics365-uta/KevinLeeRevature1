using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace SweetnSaltyConsole
{
    class Program
    {

        static void Main(string[] args)
        {
            int threeSweet = 0; //3 will substitute to "Sweet"
            int fiveSalty = 0; //5 will substitute to "Salty"
            int fifteenSweetnSalty = 0; //Reason of 15 is Least common multiple of 3 and 5 is 15.
                                        //Therefore, 15 will substitude to "Sweet' n Salty"


            //Number startng at 1 and goes to 1000 by incrementing by single number.
            for (int i = 1; i <= 1000; i++)
            {
                //Again, 15 will substitute to "Sweet' n Salty". 
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("Sweet' n Salty" + " ");
                    fifteenSweetnSalty++;
                }

                //5 will substitute to "Salty"
                else if (i % 5 == 0)
               {
                    Console.Write("Salty" + " ");
                    fiveSalty++;                   
                }

                //3 will substitute to "Sweet"
                else if (i % 3 == 0)
                {
                    Console.Write("Sweet" + " ");
                    threeSweet++;                  
                }

                //Any other numbers will count as numbers.
                else
                {
                    Console.Write(i + " ");                    
                }

                //Every 20 numbers will seperate the group.
                if (i % 20 == 0)
                {
                    Console.WriteLine("\n");
                }
            }        
            //Count how many time were printed by each.
            Console.WriteLine(fifteenSweetnSalty + " times 'Sweet' n Salty' were printed.");
            Console.WriteLine(fiveSalty + " times 'Salty' were printed.");
            Console.WriteLine(threeSweet + " times 'Sweet' were printed.");      
            
            //WriteLine and Write has different. WriteLine is make a new line
            //Write stays in the same line.
        }
    }
}
