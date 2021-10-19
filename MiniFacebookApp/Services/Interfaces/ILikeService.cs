using System;
using MiniFacebookApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace MiniFacebookApp.Services.Interfaces
{
    public interface ILikeService
    {
        Task<bool> AddLikeAsync(Like like);
        Task<List<Like>> GetAllLikesByPostIdAsync(int postId);

        Task<List<Like>> GetPostLikesByDate(int postId, DateTime date);
    }
}
