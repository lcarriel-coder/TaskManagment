using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Managment.Commom.DTO
{
    public  class IsComplete
    {
  
        [Required]
        public Guid TaskId { get; set; }

        [Required]
        public bool IsCompleted { get; set; } 
    }
}
