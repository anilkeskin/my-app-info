using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AppInfo.Entity
{
    [Table("Announcements")]
    public class Announcements:BaseEntity
    {
        public Announcements()
        {
            Id = Guid.NewGuid();
        }
        public String Title { get; set; }
        public String AnText { get; set; }
        public DateTime AnDate { get; set; }

        public Guid UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }

    }
}
