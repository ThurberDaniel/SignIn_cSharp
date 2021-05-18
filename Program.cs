using System;
using System.Collections.Generic;
using SignIn.Models;

namespace SignIn
{
    class Program
    {
        static void Main(string[] args)
        {


            Dictionary<string, User> users = new Dictionary<string, User>();
            users jonesy = new User("Jonesy", "CricketLegs");
            users justin = new User("Justin", "LoveCoding");


            users.Add(jonesy.Name, jonesy);
            users.Add(justin.Name, justin);


            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Welcome to Sign IN");
            Console.WriteLine("");
            System.Console.WriteLine("Please Enter LogIn name...");
            Console.Write("username: ");
            string username = Console.ReadLine();
            Console.Write("password: ");
            string password = Console.ReadLine();





            if (users.ContainsKey(username) && users[username].ValidatePassword(password))
            {
                System.Console.WriteLine("Successfully Logged In");
            }
            else
            {
                System.Console.WriteLine("Invalid Password");
            }

        }
    }
}
