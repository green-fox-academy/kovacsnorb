using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditProject.Models
{
    public class Redditpost
    {
        public Redditpost()
        {
            DateOfPost = DateTime.Today;
        }

        public long Id { get; set; }
        public int UpVote { get; set; }
        public int DownVote { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime DateOfPost { get; set; }
    }
}
