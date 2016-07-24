using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExample
{
    class User
    {
        private IService _service;
        /*
         * Injecting IService interface to User constructor.
         * With this approach we can change the implementation only in one place.
         */
        public User(IService service)
        {
            this._service = service;
        }
        public void CallService()
        {
            this._service.SlaveMethod();
        }

    }
}
