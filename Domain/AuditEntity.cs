using System;

namespace Task_Managment.Domain
{
    public class AuditEntity
    {
        public DateTime CreatedOn { get; set; }

        // [Column(TypeName = "varchar(250)")]
        public string CreatedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }

        // [Column(TypeName = "varchar(250)")]
        public string UpdatedBy { get; set; }
    }
}