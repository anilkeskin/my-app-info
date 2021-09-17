using AppInfo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppInfo.Services.Interfaces
{
    interface IFlatService
    {
        public List<Flats> GetFlats();
        public string Create(Flats flat);
        public Flats GetFlatById(Int16 Id);
        public string UpdateFlat(Flats flat);
        public string DeleteFlat(Flats flat);
    }
}
