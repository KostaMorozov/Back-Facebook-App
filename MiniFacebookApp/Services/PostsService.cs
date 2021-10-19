using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiniFacebookApp.Models;
using MiniFacebookApp.Services.Interfaces;

namespace MiniFacebookApp.Services
{
    public class PostsService : IPostsService
    {
        private readonly MiniFacebookDbContext _dbContext;

        public PostsService([FromServices] MiniFacebookDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Post> GetPostByIdAsync(int id)
        {
            var post = await _dbContext.Posts.FindAsync(id);

            return post == null ? null : post;
        }
        public async Task<IEnumerable<Post>> GetAllPostsAsync()
        {
            return await _dbContext.Posts.ToListAsync();
        }

        public async Task<bool> AddPostAsync(Post post)
        {
            _dbContext.Posts.Add(post);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<List<Post>> GetPostsByUserIdAsync(string userId)
        {
            return await _dbContext.Posts.Where(post => post.UserId == userId).ToListAsync();
        }

    }
}
