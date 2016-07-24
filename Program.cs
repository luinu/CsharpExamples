using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            User usr = new User(new Service());
            usr.CallService();

            Console.ReadKey();
        }
    }
}
