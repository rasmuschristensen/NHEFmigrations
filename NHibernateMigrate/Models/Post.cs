using System;

namespace NHibernateMigrate.Models
{
    public class Post
    {
        public Post()
        {
            
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
    }
}