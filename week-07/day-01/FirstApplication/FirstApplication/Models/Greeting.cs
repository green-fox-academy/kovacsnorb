using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApplication.Models
{
    public class Greeting
    {
        public long Id { get; set; }
        public string Content { get; set; }

        public Greeting(long id, string inputName)
        {
            Id = id;
            Content = "Hello " + inputName;
        }

        public Greeting()
        {
        }

    }
}
