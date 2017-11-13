using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JetBrains.Annotations;
using RedditProject.Models;

namespace RedditProject.Entities
{
    public class RedditpostContext : DbContext
    {
        public RedditpostContext(DbContextOptions<RedditpostContext> options) : base(options)
        {
        }

        public DbSet<Redditpost> Redditposts { get; set; }
    }
}
