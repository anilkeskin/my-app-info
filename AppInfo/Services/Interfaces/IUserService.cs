using AppInfo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppInfo.Services.Interfaces
{
    interface IUserService
    {
        public List<User> GetUsers();
        public string Create(User user);
        public User GetUserById(Guid Id);
        public string UpdateUser(User user);
        public string DeleteUser(User user);


    }
}
