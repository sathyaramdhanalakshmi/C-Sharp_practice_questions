using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_practiceques
{
    public sealed class SecuritySystem
    {
        public void AuthenticateUser()
        {
            Console.WriteLine("User authenticated successfully.");
        }
    }

    //public class AttemptedDerived : SecuritySystem
    //{
    //}

}
