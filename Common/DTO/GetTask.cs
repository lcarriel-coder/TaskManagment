using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Managment.Commom.DTO
{
    public  class GetTask
    {
        [Required]
        public string UserId { get; set; }

        public string? Filter { get; set; }


        public int PageNumber { get; set; }

        [Required]
        public int PageSize { get; set; }

    }
}
