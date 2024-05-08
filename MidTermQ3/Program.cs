using System;

using MidTermQ3Classes;
namespace MidtermQ3
{
    class program
    {
        static void Main(string[] args)
        {
            TestProfessorConstructors();
            TestProfessorToString();
            TestProfessorPropertyGetters();
            TestProfessorPropertySetters();
            TestProfessorPropertySettersWithExceptions();

            Console.WriteLine("Test(s) Complete.");
        }

        private static void TestProfessorConstructors()
        {
            Professor p1 = new Professor();
            Professor p2 = new Professor(333666999, "John", "Stewart", "Communications");

            Console.Write("Testing Professor Constructors: ");
            Console.WriteLine("Default Construction. Expecting default values | " + p1.ToString());
            Console.WriteLine("Explicit Construction. Expecting values: 333666999, John, Stewart, Communications  | " +p2.ToString());
            Console.WriteLine();

        }

        private static void TestProfessorToString()
        {
            Professor prof = new Professor(123456789,"Stephen", "Colbert", "Political Science");

            Console.WriteLine("Testing ToString");
            Console.WriteLine("Expecting: Professor Stephen Colbert of the Political Science department. L-Number: 123456789   | "+ prof.ToString());
            Console.WriteLine("Expecting: Professor Stephen Colbert of the Political Science department. L-Number: 123456789   | " + prof);
            Console.WriteLine("L-Number");

        }

        private static void TestProfessorPropertyGetters() 
        {            
            Professor p2 = new Professor(333666999, "John", "Stewart", "Communications");

            Console.WriteLine("Testing Getters: ");
            Console.WriteLine("  L-Number: Expecting 333666999  | " + p2.LNumber);
            Console.WriteLine("  First Name: Expecting John   | " + p2.FirstName);
            Console.WriteLine("  Last Name: Expecting Stewart  |  "+ p2.LastName);
            Console.WriteLine("  Department: Expecting Communications  |  " + p2.Department);
            Console.WriteLine();

        }
        private static void TestProfessorPropertySetters() 
        {
            Professor p2 = new Professor(333666999, "John", "Stewart", "Communications");

            Console.WriteLine("Testing Setters: ");
            p2.LNumber = 123456789;
            p2.FirstName = "Stephen";
            p2.LastName = "Colbert";
            p2.Department = "Political Science";
            Console.WriteLine("Expecting: Professor Stephen Colbert of the Political Science department. L-Number: 123456789   | " + p2);
            Console.WriteLine();
        }
        private static void TestProfessorPropertySettersWithExceptions()
        {
            Professor prof = new Professor(123456789, "Stephen", "Colbert", "Political Science");

            Console.WriteLine("Testing Setters with Exceptions");
            try
            {
                prof.LNumber = 2;
            }
            catch
            {
                Console.WriteLine("Threw an exception when L Number is too few digits");
                Console.WriteLine("Still Expecting: Professor Stephen Colbert of the Political Science department. L-Number: 123456789   | " + prof);
            }
            try
            {
                prof.LNumber = 1234567890;
            }
            catch
            {
                Console.WriteLine("Threw an exception the L Number is too many digits");
                Console.WriteLine("Still Expecting: Professor Stephen Colbert of the Political Science department. L-Number: 123456789   | " + prof);
            }
            try
            {
                prof.LNumber = -123456789;
            }
            catch
            {
                Console.WriteLine("Threw an exception when using a negative Lnumber");
                Console.WriteLine("Still Expecting: Professor Stephen Colbert of the Political Science department. L-Number: 123456789   | " + prof);
            }
            try
            {
                prof = new Professor(-134, "Conan", "O'Brien", "English/Dance");
            }
            catch
            {
                Console.WriteLine("Threw an exception when Constructor uses out of range values.");
                Console.WriteLine("Still Expecting: Professor Stephen Colbert of the Political Science department. L-Number: 123456789   | " + prof);
            }
            Console.WriteLine();
        }
    }
}