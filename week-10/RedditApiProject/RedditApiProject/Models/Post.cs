using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditApiProject.Models
{
    public class Post
    {
        public Post()
        {
            Timestamp = DateTime.Now;
        }

        public long Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public DateTime Timestamp { get; set; }
        public int Score { get; set; }
    }
}
