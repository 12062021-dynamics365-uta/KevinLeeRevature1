using System;
using System.Runtime.Serialization;

namespace _4_MethodsChallenge
{
    [Serializable]
    internal class ArithmeticExceptions : Exception
    {
        public ArithmeticExceptions()
        {
        }

        public ArithmeticExceptions(string message) : base(message)
        {
        }

        public ArithmeticExceptions(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ArithmeticExceptions(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}