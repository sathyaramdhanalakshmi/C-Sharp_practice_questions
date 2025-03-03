using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_practiceques
{
    public class Account
    {
        public virtual void CalculateInterest()
        {
            Console.WriteLine("Base Account Interest Calculation");
        }
    }

    // SavingsAccount.cs
    public class SavingsAccount : Account
    {
        public sealed override void CalculateInterest()
        {
            Console.WriteLine("Savings Account Interest Calculation");
        }
    }

}
