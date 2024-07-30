using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using WebAPI.Models;
using WebAPI.Context;


namespace WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        ApplicationDbContext _dbContext;

        public PostController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        [HttpGet]
        public List<Post> getPosts()
        {
            var posts = _dbContext.Posts.ToList();
            return posts;
        }

        [HttpPost]
        public Post CreatePost(Post post)
        {
            post.CreatedDate = DateTime.Now;
            _dbContext.Posts.Add(post);
            bool isSaved = _dbContext.SaveChanges() > 0;
            if (isSaved)
            {
                return post;
            }

            return null;
        }
   
    }
}

