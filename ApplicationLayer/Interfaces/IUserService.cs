﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Managment.Domain;
using Task_Managment.Services.DTO;

namespace Services.AppServices.Interfaces
{
    public interface IUserService
    {
        Task<List<UserBasicData>> GetUsersAsync();
    }
}
