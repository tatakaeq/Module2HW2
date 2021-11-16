using Module2HW2.Models;

namespace Module2HW2.Providers
{
    public class UserProvider
    {
        private readonly User _user = new()
        {
            Username = "user1",
            Name = "Andrew",
            Password = "qweQWE123",
            Email = "a.kara123@gmail.com",
            PhoneNumber = "380676138004"
        };

        public User GetUser()
        {
            return _user;
        }
    }
}