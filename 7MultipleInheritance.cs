using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_practiceques
{
    public interface IFlyable
    {
        void Fly();
    }

    // Define the ISwimmable interface
    public interface ISwimmable
    {
        void Swim();
    }

    // Implement both interfaces in the Duck class
    public class Duck : IFlyable, ISwimmable
    {
        public void Fly()
        {
            Console.WriteLine("The duck is flying.");
        }

        public void Swim()
        {
            Console.WriteLine("The duck is swimming.");
        }
    }

}
