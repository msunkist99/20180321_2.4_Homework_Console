using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180321_2._4_Homework_Console.People
{
    class Person
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }

        // CreditBalance is protected - only visible within this class or classes that inherit from this class
        protected double CreditBalance { get; set; }

        public Person()
        {
        }

        public void DisplayCreditBalance()
        {
            Console.WriteLine("{0} {1} has a {2} credit balance",
                this.FirstName,
                this.LastName,
                this.CreditBalance);
        }

        public void IncreaseCredits(double cost)
        {
            this.CreditBalance += cost;
        }
    }
}
