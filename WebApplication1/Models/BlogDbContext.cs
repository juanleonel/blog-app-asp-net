using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using BlogApp.Models;

namespace BlogApp.Models
{
    public class BlogDbContext: DbContext
    {
        public DbSet<Post> Post { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Reaction> Reaction { get; set; }
    }
}