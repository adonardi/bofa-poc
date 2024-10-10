using System;

namespace bofa_poc.Contract
{
    /// <summary>
    /// A class o objects for users
    /// </summary>
    #region UserObject
    public class UserObject
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
    }
    #endregion
}
