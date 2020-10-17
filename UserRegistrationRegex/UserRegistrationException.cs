using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistrationRegex
{
    public class UserRegistrationException:Exception
    {
        public enum InvalidationType
        {
            INVALID_FIRST_NAME = 1,
            INVALID_LAST_NAME,
            INVALID_EMAIL,
            INVALID_PHONE_NUMBER,
            INVALID_PASSWORD
        }

        private readonly InvalidationType invalid;

        public UserRegistrationException(InvalidationType type, string message) : base(message)
        {
            invalid = type;
        }
    }
}
