namespace Module2HW2.Models
{
    public class User
    {
        public User(string username, string name, string password, string email, string phoneNumber)
         {
             Username = username;
             Name = name;
             Password = password;
             Email = email;
             PhoneNumber = phoneNumber;
         }

        private string Username { get; set; }

        private string Name { get; set; }

        private string Password { get; set; }

        private string Email { get; set; }

        private string PhoneNumber { get; set; }

        public string GetUserEmail()
        {
            return Email;
        }

        public string GetUserPhone()
        {
            return PhoneNumber;
        }
    }
}