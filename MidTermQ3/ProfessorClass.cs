using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermQ3Classes
{
    public class Professor
    {

        private int lNumber;
        private string firstName;
        private string lastName;
        private string department;

        public Professor()
        {
            LNumber = 999999999; //would error out when set to 000000000 because it simplified the amount of digits
        }

        public Professor(int id, string fName, string lName, string department)
        {
            LNumber = id;
            firstName = fName;
            lastName = lName;
            this.department = department;
        }

        public int LNumber
        {
            get
            { return lNumber; }
            set
            {
                if (value.ToString().Length == 9 && value >=0) 
                {
                    lNumber = value;
                }
                else
                {
                    throw new ArgumentException("L Number must be 9 digits long.");
                }
            }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        public override string ToString()
        {
            return String.Format("Professor {0} {1} of the {2} department. L-Number: {3}", firstName, lastName, department, lNumber.ToString());
        }
    }
}
