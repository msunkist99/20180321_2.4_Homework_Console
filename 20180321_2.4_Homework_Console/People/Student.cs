using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// we need System.Configuration for the .AppSetting method in the Student consructor method
using System.Configuration;

namespace _20180321_2._4_Homework_Console.People
{
    // Student class inherits from the Person base class
    class Student : Person
    {
        // constructor - executes code block when the object is created from the class
        // 
        public Student()
        {
            CreditBalance = Convert.ToDouble(ConfigurationManager.AppSettings["StudentStartingCreditBalance"]);
        }

        public bool DecreaseCredits(double cost)
        {
            if (cost > this.CreditBalance)
            {
                DisplayUnsuccessfulPayment();
                return false;
            }
            else
            {
                this.CreditBalance -= cost;
                return true;
            }
        }

        public void IncreaseStudentCreditBalance(double credit)
        {
            Console.WriteLine("Increase {0} {1} balance by {2} credits",
                this.FirstName,
                this.LastName,
                credit);

            this.IncreaseCredits(credit);
            this.DisplayCreditBalance();
        }

        private void DisplayUnsuccessfulPayment()
        {
            Console.WriteLine("{0} {1} has an INSUFFIENT credit balance of {2}",
                this.FirstName,
                this.LastName,
                this.CreditBalance);
        }
    }
}
