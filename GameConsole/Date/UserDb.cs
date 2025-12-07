using GameConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Date
{
    internal class UserDb
    {
        private static List<User> users;

        //-----------------------------------------------------------

        public static User RegisterUser (string name, string userName, string password)
        {
            var existingUser = users.FirstOrDefault(registeredUser => registeredUser.UserName == userName);
            if (existingUser != null)
            {
                throw new Exception("This UserName already exists in our System..");
            }
            users.Add(new User(name, userName, password));
            return users.Last();

        }

        //-----------------------------------------------------------

        public static User Login (string Name, string password)
        {
            var existingUser = users.FirstOrDefault(registeredUser => registeredUser.Name == Name && registeredUser.Password == password);
            
            if (existingUser == null)
            {
                throw new Exception("This user doesnt exist with this password.");
                }
            return existingUser;
        }

        //-----------------------------------------------------------

        public static void UpdateUser (User user)
        {
            var existingUserIndex = users.FindIndex(registeredUser => registeredUser.UserName == user.UserName);
            if (existingUserIndex == -1)
            {
                InvalidOperationException doesntExists = new InvalidOperationException("No such user exists.");
            }
            users[existingUserIndex] = user;
        }
    }
}
