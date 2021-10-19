using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiniFacebookApp.Models;

namespace MiniFacebookApp.Services.Interfaces
{
    public interface IPostsService
    {
        Task<Post> GetPostByIdAsync(int id);
        Task<IEnumerable<Post>> GetAllPostsAsync();
        Task<bool> AddPostAsync(Post post);
        Task<List<Post>> GetPostsByUserIdAsync(string userId);


        
    }
}
