
using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task_Managment.Domain
{
    public class User: IdentityUser
    {
      

        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdateBy { get; set; }
        public DateTime UpdatedOn { get; set; }

      

    }
}
