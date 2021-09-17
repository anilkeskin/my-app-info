using AppInfo.Context;
using AppInfo.Entity;
using AppInfo.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AppInfo.Services
{
    public class DebtService : IDebtService
    {
        private readonly AppInfoDbContext _db;

        public DebtService(AppInfoDbContext db)
        {
            _db = db;
        }
        //Get Debts
        public List<Debt> GetDebts()
        {
            return _db.Debts.ToList();
        }
        //Insert a user
        public string Create(Debt debt)
        {
            _db.Debts.Add(debt);
            _db.SaveChanges();
            return "Save Successfully";
        }
        // Get Debt By Id
        public Debt GetDebtById(Guid Id)
        {
            return _db.Debts.FirstOrDefault(s => s.Id == Id);
        }

        //Update Debt
        public string UpdateDebt(Debt debt)
        {
            _db.Debts.Update(debt);
            _db.SaveChanges();
            return "Uptate Successfully";
        }
        //Delete Debt
        public string DeleteDebt(Debt debt)
        {
            _db.Remove(debt);
            _db.SaveChanges();
            return "Delete Successfully";
        }
    }
}
