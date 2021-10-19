using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiniFacebookApp.Models;
using MiniFacebookApp.Services.Interfaces;

namespace MiniFacebookApp.Services
{
    public class UsersService : IUsersService
    {
        private readonly MiniFacebookDbContext _dbContext;

        public UsersService([FromServices] MiniFacebookDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<FacebookUser>> GetAllUsersAsync()
        {
            return await _dbContext.Users.ToListAsync();
        }
    }
}
