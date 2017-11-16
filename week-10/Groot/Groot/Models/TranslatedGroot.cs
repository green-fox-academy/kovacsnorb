using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Groot.Models
{
    public class TranslatedGroot : IGroot
    {
        public string received;
        public string translated;

        public TranslatedGroot(string inputReceived)
        {
            received = inputReceived;
            translated = "I am Groot!";
        }

    }
}
