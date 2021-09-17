using AppInfo.Context;
using AppInfo.Entity;
using AppInfo.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AppInfo.Services
{
    public class UserService : IUserService
    {
        private readonly AppInfoDbContext _db;

        public UserService(AppInfoDbContext db)
        {
            _db = db;
        }
        //Get Users
        public List<User> GetUsers()
        {
            return _db.Users.ToList();
        }
        //Insert a user
        public string Create(User user)
        {
            _db.Users.Add(user);
            _db.SaveChanges();
            return "Save Successfully";
        }
        // Get User By Id
        public User GetUserById(Guid Id)
        {
            return _db.Users.FirstOrDefault(s => s.Id == Id);
        }

        //Update User
        public string UpdateUser(User user)
        {
            _db.Users.Update(user);
            _db.SaveChanges();
            return "Uptate Successfully";
        }
        //Delete User
        public string DeleteUser(User user)
        {
            _db.Remove(user);
            _db.SaveChanges();
            return "Delete Successfully";
        }
    }
}
