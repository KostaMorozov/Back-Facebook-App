using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiniFacebookApp.Models;
using MiniFacebookApp.Services.Interfaces;

namespace MiniFacebookApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostsService _postsService;

        public PostController(IPostsService postsService)
        {
            _postsService = postsService;
        }

        /*[HttpGet]
        [Route("GetAllPosts")]
        public async Task<ActionResult<IEnumerable<Post>>> GetPosts()
        {
            //return await _context.Posts.ToListAsync();
            return await _postsService.GetAllPostsAsync();
            //return Ok(posts);
        }

        [HttpGet]
        [Route("GetPost/{id}")]
        public async Task<ActionResult<Post>> GetPost(int id)
        {
            var post = await _context.Posts.FindAsync(id);

            if (post == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response()
                {
                    Status = "Error",
                    Message = "Post Not Found"
                });
            }

            return post;
        }

        
        [HttpGet]
        [Route("GetUserPosts/{userId}")]
        public async Task<IActionResult> GetUserPosts(string userId)
        {
            var posts = await _postsService.GetPostsByUserIdAsync(userId);
            return Ok(posts);
        }

        // PUT: api/Post/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPost(int id, Post post)
        {
            if (id != post.PostId)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response()
                {
                    Status = "Error",
                    Message = "Mismatch Between Posts"
                });
            }

            _context.Entry(post).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PostExists(id))
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, new Response()
                    {
                        Status = "Error",
                        Message = "Post Not Found"
                    });
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Post
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Post>> PostPost(Post post)
        {
            _context.Posts.Add(post);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPost", new { id = post.PostId }, post);
        }

        // DELETE: api/Post/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePost(int id)
        {
            var post = await _context.Posts.FindAsync(id);
            if (post == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response()
                {
                    Status = "Error",
                    Message = "Post Not Found"
                });
            }

            _context.Posts.Remove(post);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PostExists(int id)
        {
            return _context.Posts.Any(e => e.PostId == id);
        }*/
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Post>> GetPost(int id)
        {
            var post = await _postsService.GetPostByIdAsync(id);

            if (post == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response()
                {
                    Status = "Error",
                    Message = "Post Not Found"
                });
            }

            return Ok(post);
        }

        [HttpGet]
        [Route("GetAllPosts")]
        public async Task<ActionResult<IEnumerable<Post>>> GetPosts()
        {
            var posts = await _postsService.GetAllPostsAsync();
            return Ok(posts);
        }

        [HttpPost]
        public async Task<ActionResult> PostPost(Post post)
        {
            await _postsService.AddPostAsync(post);
            return Ok();
        }

        [HttpGet]
        [Route("GetUserPosts/{userId}")]
        public async Task<IActionResult> GetUserPosts(string userId)
        {
            var posts = await _postsService.GetPostsByUserIdAsync(userId);
            return Ok(posts);
        }
    }
}
