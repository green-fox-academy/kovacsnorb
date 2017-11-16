using System;
using System.ComponentModel.DataAnnotations;

namespace RedditProject.Models
{
    public class Redditpost
    {
        public Redditpost()
        {
            DateOfPost = DateTime.Today;
        }

        public long Id { get; set; }

        [Required(ErrorMessage = "Upvote number is required")]
        [Range(0, 100, ErrorMessage = "Initial upvote should be greater than 0, but less than 100.")]
        public int UpVote { get; set; }

        [Required(ErrorMessage = "Downvote number is required")]
        [Range(0, 100, ErrorMessage = "Initial downvote should be greater than 0, but less than 100.")]
        public int DownVote { get; set; }

        [MinLength(5, ErrorMessage = "The title must be at least 5 characters long")]
        [MaxLength(15, ErrorMessage = "The title must be less than 15 characters long")]
        public string Title { get; set; }

        [MinLength(5, ErrorMessage = "The content must be at least 5 characters long")]
        [MaxLength(40, ErrorMessage = "The content must be less than 40 characters long")]
        public string Content { get; set; }
        public DateTime DateOfPost { get; set; }
    }
}
