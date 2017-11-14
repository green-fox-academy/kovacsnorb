using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestPractice.Models
{
    public class Welcome
    {
        public string welcome_message;

        public Welcome(string name, string title)
        {
            welcome_message = $"Oh, hi there {name}, my dear {title}!";
        }
    }
}