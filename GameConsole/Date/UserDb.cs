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
        private static List<User> users = new List<User>();

        //-----------------------------------------------------------

        public static User RegisterUser (string name, string userName, string password)
        {
            var existingUser = users.FirstOrDefault(registeredUser => registeredUser.UserName == userName);
            if (existingUser != null)
            {
                return null;
            }
            users.Add(new User(name, userName, password));
            return users.Last();

        }

        //-----------------------------------------------------------

        public static User Login (string Name, string password)
        {
             return users.FirstOrDefault(registeredUser => registeredUser.Name == Name && registeredUser.Password == password);
           
        }

        //-----------------------------------------------------------

        public static void UpdateUser (User user)
        {

            //var existingUser = users.Single(registeredUser => registeredUser.UserName == user.UserName);
            //existingUser.Name = user.Name;
            //existingUser.Password = user.Password;

            var existingUserIndex = users.FindIndex(registeredUser => registeredUser.UserName == user.UserName);
            if (existingUserIndex == -1)
            {
                throw new InvalidOperationException("No such user exists.");
            }
            users[existingUserIndex] = user;
        }

        //-----------------------------------------------------------

        public static void UpdateName (User user, string newName)
        {
            var existingUser = users.Single(registeredUser => registeredUser.UserName == user.UserName);
            existingUser.Name = newName;
        }

        //-----------------------------------------------------------

        public static void UpdatePassword (User user, string newPassword)
        {
            var existingUser = users.Single(registeredUser => registeredUser.UserName == user.UserName);
            existingUser.Password = newPassword;
        }

        //-----------------------------------------------------------

    }
}
