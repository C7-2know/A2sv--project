using BlogCrud.Data;
using BlogCrud.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCrud.Controllers;

[Route("blog/[controller]")]
[ApiController]

public class PostsController: ControllerBase
{
    public static BlogDbContext _context;
    public PostsController(BlogDbContext context)
    {
        _context=context;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllPost()
    {
        var posts=await _context.Posts.ToListAsync();
        return Ok(posts);
    }

    [HttpGet("{postId}")]
    public async Task<IActionResult> GetPost(int postId)
    {
        var post=_context.Posts.FirstOrDefault(p=>p.PostId==postId);
        if (post==null)
        {
            return NotFound();
        }
        return Ok(post);
    }
    [HttpPost]
    public IActionResult addPost(Post post)
    {
        _context.Posts.Add(post);
        _context.SaveChanges();
        return Ok();
    }
}