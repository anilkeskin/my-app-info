using AppInfo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppInfo.Services.Interfaces
{
    interface IAnnouncementService
    {
        public List<Announcements> GetAnnouncements();
        public string Create(Announcements announcement);
        public Announcements GetAnnouncementById(Guid Id);
        public string UpdateAnnouncement(Announcements announcement);
        public string DeleteAnnouncement(Announcements announcement);


    }
}
