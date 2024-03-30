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
    public IActionResult AddPost(Post post)
    {
        _context.Posts.Add(post);
        _context.SaveChanges();
        return Ok();
    }

    
    [HttpDelete("{postId}")]
    public IActionResult DeletePost(int postId)
    {
        var post = _context.Posts.FirstOrDefault(p => p.PostId == postId);
        if (post == null)
        {
            return NotFound();
        }
        _context.Posts.Remove(post);
        _context.SaveChanges();
        return Ok();
    }


    [HttpPut("{postId}")]
    public IActionResult UpdatePost(int postId, Post updatedPost)
    {
        var post = _context.Posts.FirstOrDefault(p => p.PostId == postId);
        if (post == null)
        {
            return NotFound();
        }
        post.Title = updatedPost.Title;
        post.Content = updatedPost.Content;
        _context.SaveChanges();
        return Ok();
    }

    
}


[Route("blog/[controller]")]
[ApiController]
public class CommentsController: ControllerBase
{
    public static BlogDbContext _context;
    public CommentsController(BlogDbContext context)
    {
        _context=context;
    }

    // Get all comment
    [HttpGet]
    public async Task<IActionResult> GetAllComments()
    {
        var comments=await _context.Comments.ToListAsync();
        return Ok(comments);
    }

// get a comment usng id 
    [HttpGet("{commentId}")]
    public async Task<IActionResult> GetPost(int commentId)
    {
        var comment=_context.Comments.FirstOrDefault(p=>p.CommentId==commentId);
        if (comment==null)
        {
            return NotFound();
        }
        return Ok(comment);
    }

    [HttpPost]
    public IActionResult AddComment(Comment comment)
    {
        _context.Comments.Add(comment);
        _context.SaveChanges();
        return Ok();
    }


    [HttpDelete("commentId")]
    public IActionResult DeleteComment(int commentId)
    {
        var comment = _context.Comments.FirstOrDefault(c => c.CommentId == commentId);
        if (comment == null)
        {
            return NotFound();
        }
        _context.Comments.Remove(comment);
        _context.SaveChanges();
        return Ok();
    }

    
    [HttpPut("{commentId}")]
    public IActionResult UpdateComment(int commentId,Comment updatedComment)
    {
        var commnet = _context.Comments.FirstOrDefault(p => p.CommentId == commentId);
        if (commnet == null)
        {
            return NotFound();
        }
        commnet.Text = updatedComment.Text;
        _context.SaveChanges();
        return Ok();
    }

    
}