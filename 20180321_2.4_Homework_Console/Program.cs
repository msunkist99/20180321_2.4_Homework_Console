using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// add the following using statement to access classes in the People folder
using _20180321_2._4_Homework_Console.People;

namespace _20180321_2._4_Homework_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "_20180321_2.4_Homework_Console";

            Student studentA = new Student();
            Console.Write("Enter student first name - ");
            studentA.FirstName = Console.ReadLine();
            Console.Write("Enter student last name - ");
            studentA.LastName = Console.ReadLine();
            studentA.DisplayCreditBalance();

            Tutor tutorA = new Tutor();
            Console.Write("\n\rEnter tutor first name - ");
            tutorA.FirstName = Console.ReadLine();
            Console.Write("Enter tutor last name - ");
            tutorA.LastName = Console.ReadLine();
            Console.Write("Enter tutor cost - ");
            tutorA.Cost = Convert.ToDouble(Console.ReadLine());
            tutorA.DisplayCreditBalance();

            Tutor tutorB = new Tutor();
            Console.Write("\n\rEnter tutor first name - ");
            tutorB.FirstName = Console.ReadLine();
            Console.Write("Enter tutor last name - ");
            tutorB.LastName = Console.ReadLine();
            Console.Write("Enter tutor cost - ");
            tutorB.Cost = Convert.ToDouble(Console.ReadLine());
            tutorB.DisplayCreditBalance();
            //
            //
            Console.Write("\n\r******************************");

            Console.WriteLine("\n\r{0} {1} will pay {2} {3} {4} credits",
                studentA.FirstName,
                studentA.LastName,
                tutorA.FirstName,
                tutorA.LastName,
                tutorA.Cost);

            if (studentA.DecreaseCredits(tutorA.Cost) == false)
            {
                // the assumption is that crediting the student with 100 credits 
                // will give the student sufficient balance to pay the tutor
                studentA.IncreaseStudentCreditBalance(100);
                studentA.DecreaseCredits(tutorA.Cost);
            }

            tutorA.IncreaseCredits(tutorA.Cost);
            studentA.DisplayCreditBalance();
            tutorA.DisplayCreditBalance();

            Console.WriteLine("\n\r{0} {1} will pay {2} {3} {4} credits",
                studentA.FirstName,
                studentA.LastName,
                tutorB.FirstName,
                tutorB.LastName,
                tutorB.Cost);

            if (studentA.DecreaseCredits(tutorB.Cost) == false)
            {
                studentA.IncreaseStudentCreditBalance(100);

                Console.WriteLine("\n\r{0} {1} will pay {2} {3} {4} credits",
                    studentA.FirstName,
                    studentA.LastName,
                    tutorB.FirstName,
                    tutorB.LastName,
                tutorB.Cost);

                studentA.DecreaseCredits(tutorB.Cost);
            }

            tutorB.IncreaseCredits(tutorB.Cost);
            studentA.DisplayCreditBalance();
            tutorB.DisplayCreditBalance();

            Console.ReadLine();
        }
    }
}
