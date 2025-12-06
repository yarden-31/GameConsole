using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Models
{
    internal class UserList
    {
        public List<User> Users;
        public UserList()
        {
            Users = new List<User>();
        }

        //-----------------------------------------------------------

        public void AddUser(User user)
        {
            Users.Add(user);
        }

        //-----------------------------------------------------------

        public bool findUser(string name, string password)
        {
            foreach (var user in Users)
            {
                if (user.Name == name && user.Password == password)
                {
                    return true;
                }
            }
            return false;
        }

        //-----------------------------------------------------------
    }
}
