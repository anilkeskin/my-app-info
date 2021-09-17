using AppInfo.Context;
using AppInfo.Entity;
using AppInfo.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AppInfo.Services
{
    public class FlatService : IFlatService
    {
        private readonly AppInfoDbContext _db;

        public FlatService(AppInfoDbContext db)
        {
            _db = db;
        }
        //Get Flats
        public List<Flats> GetFlats()
        {
            return _db.Flats.ToList();
        }
        //Insert a flat
        public string Create(Flats flat)
        {
            _db.Flats.Add(flat);
            _db.SaveChanges();
            return "Save Successfully";
        }
        // Get Flat By Id
        public Flats GetFlatById(Int16 Id)
        {
            return _db.Flats.FirstOrDefault(s => s.FlatNumber == Id);
        }

        //Update Flat
        public string UpdateFlat(Flats flat)
        {
            _db.Flats.Update(flat);
            _db.SaveChanges();
            return "Uptate Successfully";
        }
        //Delete User
        public string DeleteFlat(Flats flat)
        {
            _db.Remove(flat);
            _db.SaveChanges();
            return "Delete Successfully";
        }
    }
}
