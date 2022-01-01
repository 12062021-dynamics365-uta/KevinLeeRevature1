using System;

namespace DataTypeAndVariables
{
    public class Program
    {
        public static void Main(string[] args)
        {

            byte myByte = 255;
            Console.WriteLine(myByte);

            sbyte mySbyte = -128;
            Console.WriteLine(mySbyte);

            int myInt = 2147483647;
            Console.WriteLine(myInt);

            uint myUint = 4294967295;
            Console.WriteLine(myUint);

            short myShort = -32768;
            Console.WriteLine(myShort);

            ushort myUshort = 65535;
            Console.WriteLine(myUshort);

            float myFloat = -31.1289f;
            Console.WriteLine(myFloat);

            double myDouble = -12.1231250;
            Console.WriteLine(myDouble);

            char myCharacter = 'A';
            Console.WriteLine(myCharacter);

            bool myBool = true;
            Console.WriteLine(myBool);

            string myText = "I control text";
            Console.WriteLine(myText);

            string numString = "15";
            Console.WriteLine(numString);

            decimal myDecimal = 3.001002003m;
            Console.WriteLine(myDecimal);

            long myLong = 9223372036854775807;
            Console.WriteLine(myLong);

            ulong myUlong = 18446744073709551615;
            Console.WriteLine(myUlong);
        }

        /// <summary>
        /// This method has an 'object' type parameter. 
        /// 1. Create a switch statement that evaluates for the data type of the parameter
        /// 2. You will need to get the data type of the parameter in the 'case' part of the switch statement
        /// 3. For each data type, return a string of exactly format, "Data type => <type>" 
        /// 4. For example, an 'int' data type will return ,"Data type => int",
        /// 5. A 'ulong' data type will return "Data type => ulong",
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string PrintValues(object obj)
        {
            //invoking system.Typecode
            TypeCode typeCode = Type.GetTypeCode(obj.GetType());

            switch (typeCode)
            {
                //     An integral type representing unsigned 8-bit integers with values between 0 and
                //     255.
                case TypeCode.Byte:
                    return "Data type => byte";

                //     An integral type representing signed 8-bit integers with values between -128
                //     and 127.
                case TypeCode.SByte:
                    return "Data type => sbyte";

                //     An integral type representing signed 32-bit integers with values between -2147483648
                //     and 2147483647.
                case TypeCode.Int32:
                    return "Data type => int";

                //     An integral type representing unsigned 32-bit integers with values between 0
                //     and 4294967295.
                case TypeCode.UInt32:
                    return "Data type => uint";

                //     An integral type representing signed 16-bit integers with values between -32768
                //     and 32767.
                case TypeCode.Int16:
                    return "Data type => short";

                //     An integral type representing unsigned 16-bit integers with values between 0
                //     and 65535.
                case TypeCode.UInt16:
                    return "Data type => ushort";

                //     A floating point type representing values ranging from approximately 1.5 x 10
                //     -45 to 3.4 x 10 38 with a precision of 7 digits.
                case TypeCode.Single:
                    return "Data type => float";

                //     A floating point type representing values ranging from approximately 5.0 x 10
                //     -324 to 1.7 x 10 308 with a precision of 15-16 digits.
                case TypeCode.Double:
                    return "Data type => double";

                //     An integral type representing unsigned 16-bit integers with values between 0
                //     and 65535. The set of possible values for the System.TypeCode.Char type corresponds
                //     to the Unicode character set.
                case TypeCode.Char:
                    return "Data type => char";

                //     A sealed class type representing Unicode character strings.
                case TypeCode.String:
                    return "Data type => string";

                //     A simple type representing values ranging from 1.0 x 10 -28 to approximately
                //     7.9 x 10 28 with 28-29 significant digits.
                case TypeCode.Decimal:
                    return "Data type => decimal";

                //     An integral type representing signed 64-bit integers with values between -9223372036854775808
                //     and 9223372036854775807.
                case TypeCode.Int64:
                    return "Data type => long";

                //     An integral type representing unsigned 64-bit integers with values between 0
                //     and 18446744073709551615.
                case TypeCode.UInt64:
                    return "Data type => ulong";

                //     A simple type representing Boolean values of true or false.
                case TypeCode.Boolean:
                    return "Data type => bool";

                default:
                    return "No information.";
            }
        }

        /// <summary>
        /// THis method has a string parameter.
        /// 1. Use the .TryParse() method of the Int32 class (Int32.TryParse()) to convert the string parameter to an integer. 
        /// 2. You'll need to investigate how .TryParse() and 'out' parameters work to implement the body of StringToInt().
        /// 3. If the string cannot be converted to a integer, return 'null'. 
        /// 4. Investigate how to use '?' to make non-nullable types nullable.
        /// </summary>
        /// <param name="numString"></param>
        /// <returns></returns>
        public static int? StringToInt(string numString)
        {
            //throw new NotImplementedException($"StringToInt() has not been implemented");

            /*bool stringInputConverted = false;
            int stringConvertedNumber;
            stringInputConverted = Int32.TryParse(numString, out stringConvertedNumber);
            if (!stringInputConverted)
            {
                return null;
            }
            return stringConvertedNumber;*/
            int number;
            bool success = Int32.TryParse(numString, out number);
            if(!success)
            {
                return null;
            }
            else
            {
                return number;
            }


        }
    }// end of class
}
