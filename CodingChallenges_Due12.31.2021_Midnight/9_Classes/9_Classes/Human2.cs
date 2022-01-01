using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("9_ClassesChallenge.Tests")]
namespace _9_ClassesChallenge
{
    //Part 2 Step 1
    internal class Human2
    {

        private string firstname;

        private string lastname;

        private int age;

        private string eyecolor;

        public Human2 (string firstName, string lastName, int age, string eyeColor)
        {
            this.firstname = firstName;
            this.lastname = lastName;
            this.age = age;
            this.eyecolor = eyeColor;
        }

        public Human2(string firstName, string lastName, int age)
        {
            this.firstname = firstName;
            this.lastname = lastName;
            this.age = age;           
        }

        public Human2(string firstName, string lastName, string eyeColor)
        {
            this.firstname = firstName;
            this.lastname = lastName;
            this.eyecolor = eyeColor;
        }

        public static void AboutMe2()
        {
            void h1(string firstName, string lastName, int age, string eyeColor)
            {
                Console.WriteLine("My name is " +firstName+ " " +lastName+ ". My age is " +
                    age + ". My eye color is " +eyeColor+ ".");
            }

            void h2(string firstName, string lastName, string eyeColor)
            {
                Console.WriteLine("My name is " + firstName + " " + lastName + 
                    " . My eye color is " + eyeColor + ".");
            }

            void h3(string firstName, string lastName, int age)
            {
                Console.WriteLine("My name is " + firstName + " " + lastName + ". My age is " +
                    age + ".");
            }


        }
    }
}