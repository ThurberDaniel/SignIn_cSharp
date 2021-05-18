namespace SignIn.Models
{

    public class User
    {

        public string Name { get; set; }
        private string Password { get; set; }

        public bool ValidatePassword(string input)
        {
            return input == Password;
        }
        public User()
        {
        }
    }
}