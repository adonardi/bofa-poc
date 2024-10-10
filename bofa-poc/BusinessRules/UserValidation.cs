using bofa_poc.Contract;
using System;
using System.Text.RegularExpressions;

namespace bofa_poc.BusinessRules
{
    /// <summary>
    /// Validate all data for user - "persona", with regular expression.
    /// </summary>
    public class UserValidation
    {
        public bool ValidateUsername(string username) { 
            return !string.IsNullOrEmpty(username) && Regex.IsMatch(username, @"^[a-zA-Z0-9]{1,8}$");
        }

        public bool ValidateEmail(string email){
             return !string.IsNullOrEmpty(email) && Regex.IsMatch(email, @"^[^\s@]+@[^\s@]+\.[^\s@]+$");
        }

        public bool ValidatePassword(string password){
            return !string.IsNullOrEmpty(password) && Regex.IsMatch(password, @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{6,}$");
        }

        public bool ValidatePhoneNumber(string phoneNumber){
            return !string.IsNullOrEmpty(phoneNumber) && Regex.IsMatch(phoneNumber, @"^[0-9]{10,15}$");
        }

        // Return
        public bool ValidateUser(UserObject user)
        {
            return ValidateUsername(user.Username) &&
                   ValidateEmail(user.Email) &&
                   ValidatePassword(user.Password) &&
                   ValidatePhoneNumber(user.PhoneNumber);
        }
    }
}
