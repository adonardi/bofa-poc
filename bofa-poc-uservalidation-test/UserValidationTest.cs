using bofa_poc.BusinessRules;
using bofa_poc.Contract;
using FluentAssertions;

namespace bofa_poc_uservalidation_test
{
    public class UserValidationTest
    {
        [Fact]
        public void UserValidation_UserValidation_ReturnBool()
        {
            // Here i am using the "triple A"

            // Arrange
            var user = new UserObject();
            var validator = new UserValidation();

            // Act
            user.Username = "Alex";
            user.Email = "alex@gmail.com";
            user.Password = "Pass@word1";
            user.PhoneNumber = "1168565120";

            var result = validator.ValidateUser(user);

            // Assert
            result.Should().BeTrue();
        }
    }
}