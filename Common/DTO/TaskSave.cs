using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Managment.Commom.DTO
{
    public  class TaskSave
    {
     

        [Required]
        public string Description { get; set; }

        [Required]
        public DateTime? DeadlineToFinish { get; set; }

        public bool IsCompleted { get; set; }


        [Required]
        public string UserId { get; set; }

        [Required]
        public Guid CategoryId { get; set; }
     
    }
}
