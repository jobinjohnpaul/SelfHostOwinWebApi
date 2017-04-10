using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatanaHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (WebApp.Start<Startup>("http://localhost:12345"))
            {

                Console.WriteLine("Its alive!");
                Console.WriteLine("Oh Its alive!");
                Console.WriteLine("Press any key to quit.");
                Console.ReadLine();
            }

        }
    }
}
