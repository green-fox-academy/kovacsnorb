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

        public void AddNew(Redditpost newPost)
        {
            redditpostContext.Redditposts.Add(newPost);
            redditpostContext.SaveChanges();
        }

        public void UpVotePost(Redditpost postToUpVote)
        {
            var post = redditpostContext.Redditposts.FirstOrDefault(p => p.Id == postToUpVote.Id);
            post.UpVote++;
            redditpostContext.SaveChanges();
        }

        public void DownVotePost(Redditpost postToDownVote)
        {
            var post = redditpostContext.Redditposts.FirstOrDefault(p => p.Id == postToDownVote.Id);
            post.DownVote++;
            redditpostContext.SaveChanges();
        }

        public Redditpost GetPostById(long id)
        {
            return redditpostContext.Redditposts.FirstOrDefault(p => p.Id == id);
        }
    }
}
