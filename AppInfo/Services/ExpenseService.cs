using AppInfo.Context;
using AppInfo.Entity;
using AppInfo.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AppInfo.Services
{
    public class ExpenseService : IExpenseService
    {
        private readonly AppInfoDbContext _db;

        public ExpenseService(AppInfoDbContext db)
        {
            _db = db;
        }
        //Get Expenses
        public List<Expenses> GetExpenses()
        {
            return _db.Expenses.ToList();
        }
        //Insert a expense
        public string Create(Expenses expense)
        {
            _db.Expenses.Add(expense);
            _db.SaveChanges();
            return "Save Successfully";
        }
        // Get Expense By Id
        public Expenses GetExpenseById(Guid Id)
        {
            return _db.Expenses.FirstOrDefault(s => s.Id == Id);
        }

        //Update Expense
        public string UpdateExpense(Expenses ex)
        {
            _db.Expenses.Update(ex);
            _db.SaveChanges();
            return "Uptate Successfully";
        }
        //Delete User
        public string DeleteExpense(Expenses ex)
        {
            _db.Remove(ex);
            _db.SaveChanges();
            return "Delete Successfully";
        }
    }
}
