using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiniFacebookApp.Models;

namespace MiniFacebookApp.Services.Interfaces
{
    public interface IUsersService
    {
        Task<List<FacebookUser>> GetAllUsersAsync();
    }
}
