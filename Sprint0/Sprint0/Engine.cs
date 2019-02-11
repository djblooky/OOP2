using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint0
{
    public class Engine
    {
        public bool IsStarted { get; set; }

        public string About()
        {
            if (IsStarted)
            {
                return this + " is started";
            }
            else
            {
                return this + " is not started";
            }
        }

        public Engine()
        {
            IsStarted = false;
        }

    }
}
