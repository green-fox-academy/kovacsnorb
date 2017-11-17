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
        PostContext postContext;

        public PostRepository(PostContext postcontext)
        {
            this.postContext = postcontext;
        }

        public List<Post> FillList()
        {
            return postContext.Posts.OrderByDescending(p => p.Score).ToList();
        }

        public Post GetLastPost()
        {
            return postContext.Posts.LastOrDefault();
        }

        public void AddPostToList(Post post)
        {
            postContext.Posts.Add(post);
            postContext.SaveChanges();
        }

        public void UpvotePost(int id)
        {
            var postToUpvote = postContext.Posts.FirstOrDefault(p => p.Id == id);
            postToUpvote.Score++;
            postContext.SaveChanges();
        }

        public void DownvotePost(int id)
        {
            var postToDownvote = postContext.Posts.FirstOrDefault(p => p.Id == id);
            postToDownvote.Score--;
            postContext.SaveChanges();
        }

        public Post GetPostById(int id)
        {
            return postContext.Posts.FirstOrDefault(p => p.Id == id);
        }
    }
}
