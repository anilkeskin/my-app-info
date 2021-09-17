using AppInfo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppInfo.Services.Interfaces
{
    interface IExpenseService
    {
        public List<Expenses> GetExpenses();
        public string Create(Expenses expense);
        public Expenses GetExpenseById(Guid Id);
        public string UpdateExpense(Expenses expense);
        public string DeleteExpense(Expenses expense);


    }
}
