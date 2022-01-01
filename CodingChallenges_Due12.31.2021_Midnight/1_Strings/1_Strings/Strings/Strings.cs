using System;


namespace StringManipulationChallenge
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            *
            * implement the required code here and within the methods below.
            *
            */

            //converts the input string to lower
            Console.WriteLine("Enter as string.");
            string s1 = Console.ReadLine();
            string s2 = Program.StringToUpper(s1);
            Console.WriteLine(s2);

            //converts the input string to lower
            string s4 = Program.StringToLower(s1);
            Console.WriteLine(s4);

            //trim the user unput string
            Console.WriteLine("Enter a string to trim the whitespace");
            string s8 = Console.ReadLine();
            string s9 = Program.StringTrim(s8);
            Console.WriteLine(s9);

            //convert a string using IndexOf
            Console.WriteLine("Enter a string");
            string s5 = Console.ReadLine();
            Console.WriteLine("Enter number 1");
            int i1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter nubmer 7");
            int i2 = Convert.ToInt32(Console.ReadLine());

            string s10 = Program.StringSubstring(s5, i1, i2);
            Console.WriteLine(s10);

            //SearchChar
            Console.WriteLine("Please enter a sentence to substring");
            string s3 = Program.StringSubstring("Happy New Year 2022", 4, 8);
            Console.WriteLine(s3);

            Console.WriteLine("Enter an string input");
            string s11 = Console.ReadLine();
            Console.WriteLine("Search for a character within the input");
            char c1 = Convert.ToChar(Console.ReadLine());
            int SearchCharacter = Program.SearchChar(s11, c1);
            Console.WriteLine(SearchCharacter);

            //Concat
            Console.WriteLine("Enter your first name");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter your last name");
            string lname = Console.ReadLine();
            string concat = Program.ConcatNames(fname, lname);
            Console.WriteLine(concat);
        }

        /// <summary>
        /// This method has one string parameter and will: 
        /// 1) change the string to all upper case and 
        /// 2) return the new string.
        /// </summary>
        /// <param name="usersString"></param>
        /// <returns></returns>
        public static string StringToUpper(string usersString)
        {
            //throw new NotImplementedException("StringToUpper method not implemented.");

            usersString = usersString.ToUpper();
            return usersString;
        }

        /// <summary>
        /// This method has one string parameter and will:
        /// 1) change the string to all lower case,
        /// 2) return the new string into the 'lowerCaseString' variable
        /// </summary>
        /// <param name="usersString"></param>
        /// <returns></returns>       
        public static string StringToLower(string usersString)
        {
            //throw new NotImplementedException("StringToUpper method not implemented.");
            usersString = usersString.ToLower();
            return usersString;
        }

        /// <summary>
        /// This method has one string parameter and will:
        /// 1) trim the whitespace from before and after the string, and
        /// 2) return the new string.
        /// HINT: When getting input from the user (you are the user), try inputting "   a string with whitespace   " to see how the whitespace is trimmed.
        /// </summary>
        /// <param name="usersStringWithWhiteSpace"></param>
        /// <returns></returns>
        public static string StringTrim(string usersStringWithWhiteSpace)
        {
            //throw new NotImplementedException("StringTrim method not implemented.");
            usersStringWithWhiteSpace = usersStringWithWhiteSpace.Trim();
            return usersStringWithWhiteSpace;
        }

        /// <summary>
        /// This method has three parameters, one string and two integers. It will:
        /// 1) get the substring based on the first integer element and the length 
        /// of the substring desired.
        /// 2) return the substring.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="firstElement"></param>
        /// <param name="lastElement"></param>
        /// <returns></returns>
        public static string StringSubstring(string x, int firstElement, int lengthOfSubsring)
        {
            //throw new NotImplementedException("StringSubstring method not implemented.");
            return x.Substring(firstElement, lengthOfSubsring);

        }

        /// <summary>
        /// This method has two parameters, one string and one char. It will:
        /// 1) search the string parameter for first occurrance of the char parameter and
        /// 2) return the index of the char.
        /// HINT: Think about how StringTrim() (above) would be useful in this situation
        /// when getting the char from the user. 
        /// </summary>
        /// <param name="userInputString"></param>
        /// <param name="charUserWants"></param>
        /// <returns></returns>
        public static int SearchChar(string userInputString, char charUserWants)
        {
            //throw new NotImplementedException("SearchChar method not implemented.");
            int result = userInputString.IndexOf(charUserWants);
            return result;
        }

        /// <summary>
        /// This method has two string parameters. It will:
        /// 1) concatenate the two strings with a space between them.
        /// 2) return the new string.
        /// HINT: You will need to get the users first and last name in the 
        /// main method and send them as arguments.
        /// </summary>
        /// <param name="fName"></param>
        /// <param name="lName"></param>
        /// <returns></returns>
        public static string ConcatNames(string fName, string lName)
        {
            //throw new NotImplementedException("ConcatNames method not implemented.");
            return String.Concat(fName, " ", lName);
            //return fName + " " + lName;
        }
    }//end of program
}