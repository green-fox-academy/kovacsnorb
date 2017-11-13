using RedditProject.Entities;
using RedditProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditProject.Repositories
{
    public class RedditpostRepository
    {
        RedditpostContext redditpostContext;

        public RedditpostRepository(RedditpostContext redditpostContext)
        {
            this.redditpostContext = redditpostContext;
        }

        public List<Redditpost> FillList()
        {
            return redditpostContext.Redditposts.ToList();
        }

    }
}
