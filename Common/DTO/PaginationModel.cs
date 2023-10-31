using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Managment.Commom.DTO
{
    public  class PaginationModel<T>
    {
        public List<T> ListRecords { get; set; }
        public int TotalRecords { get; set; }
        public int TotalPages { get; set; }

    }
}
