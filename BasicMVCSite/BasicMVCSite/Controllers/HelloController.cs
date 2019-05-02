using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BasicMVCSite.Controllers
{
    public class HelloController : Controller
    {
        public string Index()
        {
            return this.Hello("Haley");
        }

        public string Hello(string Name, int ?Age=0)
        {
            return $"Hello there! {Name} I am {Age} years old.";
        }

        public string Goodbye()
        {
            return "Bye!";
        }
    }
}