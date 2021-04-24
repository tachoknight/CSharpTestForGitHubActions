using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTestForGitHubActions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world, this is Version 1.1");
            Console.WriteLine("Oh, look, I added another line.");
            Console.WriteLine("And this is just to make sure everything works");

            JObject mksVal = JObject.Parse("{\"foo\":\"bar\"");
            Console.WriteLine("Hello world");
        }
    }
}
