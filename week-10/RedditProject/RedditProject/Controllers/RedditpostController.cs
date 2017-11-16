using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RedditProject.Repositories;
using RedditProject.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RedditProject.Controllers
{
    public class RedditpostController : Controller
    {
        RedditpostRepository redditpostRepository;

        public RedditpostController(RedditpostRepository redditpostRepository)
        {
            this.redditpostRepository = redditpostRepository;
        }

        [Route("")]
        [Route("posts")]
        public IActionResult ListOfPosts()
        {
            var myPosts = redditpostRepository.FillList();
            return View(myPosts);
        }

        [Route("posts/add")]
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [Route("posts/add")]
        [HttpPost]
        public IActionResult Add(Redditpost newPost)
        {
            if (ModelState.IsValid)
            {
                redditpostRepository.AddNew(newPost);
                return RedirectToAction("ListOfPosts");
            }
            else
            {
                return View("Add");
            }
        }

        [Route("posts/{id}/upvote")]
        [HttpGet]
        public IActionResult Upvote([FromRoute] long id)
        {
            var post = redditpostRepository.GetPostById(id);
            redditpostRepository.UpVotePost(post);
            return RedirectToAction("ListOfPosts");
        }

        [Route("posts/{id}/downvote")]
        [HttpGet]
        public IActionResult Downvote([FromRoute] long id)
        {
            var post = redditpostRepository.GetPostById(id);
            redditpostRepository.DownVotePost(post);
            return RedirectToAction("ListOfPosts");
        }
    }
}
