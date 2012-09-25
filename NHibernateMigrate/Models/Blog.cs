using System;
using System.Collections.Generic;

namespace NHibernateMigrate.Models
{
    public class Blog
    {
        public Blog()
        {
            
        }

        public IList<Post> posts = new List<Post>();
        public Guid Id { get; set; }
        public string Name { get; set; }

        public void Add(Post post)
        {
            posts.Add(post);
        }
    }

}