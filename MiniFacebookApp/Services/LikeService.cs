using MiniFacebookApp.Models;
using MiniFacebookApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MiniFacebookApp.Services
{
    public class LikeService : ILikeService
    {
        private readonly MiniFacebookDbContext _dbContext;

        public LikeService([FromServices]MiniFacebookDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> AddLikeAsync(Like like)
        {
            var hasLike = await _dbContext.Likes.FirstOrDefaultAsync(l => l.PostId == like.PostId && l.UserId == like.UserId);

            if (hasLike != default)
            {
                _dbContext.Likes.Remove(hasLike);
            }
            else
            {
                await _dbContext.Likes.AddAsync(like);
            }

            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<List<Like>> GetAllLikesByPostIdAsync(int postId)
        {
            return await _dbContext.Likes.Where(l => l.PostId == postId).ToListAsync();
        }

        public async Task<List<Like>> GetPostLikesByDate(int postId, DateTime date)
        {
            return await _dbContext.Likes.Where(l => l.PostId == postId && l.Date == date).ToListAsync();
        }
    }
}
