using AppInfo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppInfo.Services.Interfaces
{
    interface IDebtService
    {
        public List<Debt> GetDebts();
        public string Create(Debt debt);
        public Debt GetDebtById(Guid Id);
        public string UpdateDebt(Debt debt);
        public string DeleteDebt(Debt debt);


    }
}
