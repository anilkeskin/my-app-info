using AppInfo.Context;
using AppInfo.Entity;
using AppInfo.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AppInfo.Services
{
    public class AnnouncementService : IAnnouncementService
    {
        private readonly AppInfoDbContext _db;

        public AnnouncementService(AppInfoDbContext db)
        {
            _db = db;
        }
        //Get Users
        public List<Announcements> GetAnnouncements()
        {
            return _db.Announcements.ToList();
        }
        //Insert a announcement
        public string Create(Announcements announcement)
        {
            _db.Announcements.Add(announcement);
            _db.SaveChanges();
            return "Save Successfully";
        }
        // Get Announcement By Id
        public Announcements GetAnnouncementById(Guid Id)
        {
            return _db.Announcements.FirstOrDefault(s => s.Id == Id);
        }

        //Update Announcement
        public string UpdateAnnouncement(Announcements ann)
        {
            _db.Announcements.Update(ann);
            _db.SaveChanges();
            return "Uptate Successfully";
        }
        //Delete User
        public string DeleteAnnouncement(Announcements ann)
        {
            _db.Remove(ann);
            _db.SaveChanges();
            return "Delete Successfully";
        }
    }
}
