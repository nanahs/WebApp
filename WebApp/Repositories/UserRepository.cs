using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Contexts;
using WebApp.Models;

namespace WebApp.Repositories
{
    public class UserRepository
    {

        public MySqlContext Conn { get; set; }

        public UserRepository(MySqlContext dbConn)
        {
            Conn = dbConn;
        }

        public IEnumerable<User> AllUsers()
        {
            return Conn.Users.Distinct();
        }

        public User GetUserById(int userId)
        {
            return Conn.Users.Single(x => x.UserId == userId);
        }

    }
}
