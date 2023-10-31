
using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task_Managment.Domain
{
    public class Task : AuditEntity
    {
        [Key]
        public Guid TaskId { get; set; }
        public string Description { get; set; }
        public DateTime? DeadlineToFinish { get; set; }

        public bool IsCompleted { get; set; } = false;

        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }

        [ForeignKey("Category")]
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }


    }
}
