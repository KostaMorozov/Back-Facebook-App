using System;
using System.Collections;
using Microsoft.AspNetCore.Mvc;
using MiniFacebookApp.Models;
using MiniFacebookApp.Services.Interfaces;
using System.Threading.Tasks;
using MiniFacebookApp.Contracts.Requests;

namespace MiniFacebookApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LikeController : ControllerBase
    {
        private readonly ILikeService _likeService;

        public LikeController(ILikeService likeService)
        {
            _likeService = likeService;
        }

        [HttpPost]
        public async Task<IActionResult> AddLike([FromBody] Like like)
        {
            await _likeService.AddLikeAsync(like);

            return Ok();
        }


        [HttpGet]
        [Route("GetLikes/{postId}")]
        public async Task<IActionResult> GetPostLikes(int postId)
        {
            var likes = await _likeService.GetAllLikesByPostIdAsync(postId);

            return Ok(likes);
        }

        [HttpPost]
        [Route("GetLikesByDate")]
        public async Task<IActionResult> GetPostLikes([FromBody] GetLikesByDateRequest request)
        {
            return Ok(await _likeService.GetPostLikesByDate(request.PostId, request.Date));
        }
    }
}
