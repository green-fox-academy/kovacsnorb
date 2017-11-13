using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RedditProject.Repositories;

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
    }
}
