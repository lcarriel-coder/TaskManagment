
using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task_Managment.Domain
{
    public class Category :  AuditEntity
    {
        [Key]
        public Guid CategoryId { get; set; }

        public string Name { get; set; }



    }
}
