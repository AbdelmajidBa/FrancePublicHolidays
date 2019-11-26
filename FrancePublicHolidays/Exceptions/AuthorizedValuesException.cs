using System;

namespace FrancePublicHolidays.Exceptions
{
    internal class AuthorizedValuesException : Exception
    {
        public AuthorizedValuesException(string message) : base(message) { }
        public AuthorizedValuesException(string message, Exception inner) : base(message, inner) { }
   }
}
