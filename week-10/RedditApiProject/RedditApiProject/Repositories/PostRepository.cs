using RedditApiProject.Entities;
using RedditApiProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditApiProject.Repositories
{
    public class PostRepository
    {
        PostContext postcontext;

        public PostRepository(PostContext postcontext)
        {
            this.postcontext = postcontext;
        }

        public List<Post> FillList()
        {
            return postcontext.Posts.OrderByDescending(p => p.Score).ToList();
        }
    }
}
