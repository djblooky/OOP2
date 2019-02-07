using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint1
{
    public class Engine
    {
        public bool IsStarted { get; set; }

        public string About()
        {
            if (IsStarted)
            {
                return nameof(Engine) + " is started";
            }
            else
            {
                return nameof(Engine) + " is not started";
            }
        }

        public Engine()
        {
            IsStarted = false;
        }


    }
}
