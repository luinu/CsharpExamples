using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExample
{
    public interface IService
    {
        void SlaveMethod();
    }

    class Service : IService
    {
        // Here we need to implement all methods inherited from IService interface
        public void SlaveMethod()
        {
            Console.WriteLine("Calling SlaveMethod... .");
        }
    }
    // TODO: add method to check if instances were created
}
