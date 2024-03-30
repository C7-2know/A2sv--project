using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlogCrud.Models;


namespace BlogCrud.Data
{
    public class BlogDbContext: DbContext
    {
        public virtual DbSet<Comment> Comments {get; set;}
        public virtual DbSet<Post> Posts {get; set;}
        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
        {
            
        }

        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     base.OnModelCreating(modelBuilder);
        //     modelBuilder.Entity<Comment>(entity =>
        //     {
        //         entity.HasKey(c => c.CommentId);
        //         entity.HasOne(p=>p.Post)
        //             .HasForeignKey(c=>c.PostId)
        //             .OnDelete(DeleteBehavior.Cascade);
        //     });

        //     modelBuilder.Entity<Post>(entity =>
        //     {
        //         entity.HasKey(c => c.PostId);
        //         entity.WithMany(p=>p.Comments);
                
        //     });
        // }
    }
}