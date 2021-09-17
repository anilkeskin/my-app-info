using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AppInfo.Entity
{
    [Table("Debts")]
    public class Debt:BaseEntity
    {
        public Debt():base()
        {
            
        }
        public String DebtName { get; set; }
        public Double Total { get; set; }
        public Int16 FlatNumber { get; set; }
        [ForeignKey("FlatNumber")]
        public virtual Flats Flats { get; set; }

    }
}
