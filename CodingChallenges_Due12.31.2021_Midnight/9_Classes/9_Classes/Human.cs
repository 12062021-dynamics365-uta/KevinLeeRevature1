using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("9_ClassesChallenge.Tests")]
namespace _9_ClassesChallenge
{
    //Part 1 Step 1
    internal class Human
    {
        
        private string lastName = "Smyth";
        private string firstName = "Pat";
               
        
        public Human()
        {

        }

        //Part1 Step 2
        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        //Part1 Step 3
        Human withoutArgs = new Human();

        //Part1 Step 4
        Human withArgs = new Human();

        //Part1 Step 5
        public void AboutMe()
        {
            Console.WriteLine("My name is: " +firstName+ " " +lastName+ ".");

            //Part1 Step6
            withoutArgs.AboutMe();
            withArgs.AboutMe();
        }                 
    }//end of class
}//end of namespace