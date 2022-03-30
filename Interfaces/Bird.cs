using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Bird : IFlyable
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void Fly()
        {
            throw new NotImplementedException();
        }

        public string SaySomething(string sound)
        {
            throw new NotImplementedException();
        }
    }
}
