using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using BlogApp.Models;

namespace BlogApp.DataAccess
{
	public static class PostDataAccess
	{
        public static async Task<IList<Post>> GetPosts() {
            using (var context = new BlogDbContext()) {
                return await context.Post.ToListAsync();
            }
        }

        public static async Task Create(Post post)
        {
            using (var context = new BlogDbContext()) {
                post.CreatedDate = DateTime.UtcNow; context.Post.Add(post);
                await context.SaveChangesAsync();
            }
        }

        public static async Task<Post> GetPostById(int Id)
        {
            using (var context = new BlogDbContext())
            {
                return await context.Post.Where(item => item.Id == Id).FirstOrDefaultAsync();
            }
        }

        public static async Task Update(Post post)
        {
            using (var context = new BlogDbContext()) {
                var foundPost = await context.Post.FindAsync(post.Id);
  
                if (foundPost != null) {
                    foundPost.Title = post.Title;
                    foundPost.Body = post.Body;
                    foundPost.UpdatedDate = DateTime.UtcNow;
                    await context.SaveChangesAsync();
                }
            }
        }

        public static async Task Delete(int Id)
        {
            using (var context = new BlogDbContext())
            {
                var foundPost = await context.Post.FindAsync(Id);

                if (foundPost != null)
                {
                    context.Post.Remove(foundPost);
                    await context.SaveChangesAsync();
                }
            }
        }
    }
}
