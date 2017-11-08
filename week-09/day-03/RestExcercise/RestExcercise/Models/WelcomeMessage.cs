using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestExcercise.Models
{
    public class WelcomeMessage
    {
        public string welcome_message;

        public WelcomeMessage(string name, string title)
        {
            welcome_message = $"Oh, hi there {name}, my dear {title}!";
        }
    }
}
