using System;

namespace FrancePublicHolidays.Exceptions
{
    public class CallApiException : Exception
    {
        public CallApiException (string message) : base(message) { }
        public CallApiException(string message, Exception inner) : base(message, inner) { }
    }
}
