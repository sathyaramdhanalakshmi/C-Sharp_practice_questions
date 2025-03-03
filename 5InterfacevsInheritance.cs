using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_practiceques
{
    public interface IMovable
    {
        void Move();
    }

    // Machine.cs
    public class Machine
    {
        public void Start()
        {
            Console.WriteLine("Machine starting...");
        }
    }

    // Robot.cs
    public class Robot : Machine, IMovable
    {
        public void Move()
        {
            Console.WriteLine("Robot is moving...");
        }
    }
}
