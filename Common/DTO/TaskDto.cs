using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Managment.Commom.DTO
{
    public  class TaskDto
    {
        public Guid TaskId { get; set; }
        public string Description { get; set; }
        public DateTime? DeadlineToFinish { get; set; }

        public string CategoryName { get; set; }

        public bool IsCompleted { get; set; } = false;
        public string UserId { get; set; }
        public Guid CategoryId { get; set; }
     
    }
}
