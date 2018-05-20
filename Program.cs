using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo
{

    public class Post
    {
        public int Id { get; set; }
        public DateTime DatePublished { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }

    public class BlogDbContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }




    }


    class Program
    {
        static void Main(string[] args)
        {
            Post newPost = new Post()
            {
                Id = 1,
                Body = "En un lugar de la mancha...",
                DatePublished = DateTime.Today,
                Title = "Don Quijote"
            };
                        
            var context = new BlogDbContext();
            context.Posts.Add(newPost);
            context.SaveChanges();
        }
    }
}
