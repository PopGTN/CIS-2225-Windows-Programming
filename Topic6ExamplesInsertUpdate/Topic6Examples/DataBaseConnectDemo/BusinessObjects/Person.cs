using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseConnectDemo.BusinessObjects
{
    public class Person
    {
        //private attributes
        private string firstName;
        private string lastName;
        private int personId;

        //custom constructor used to populate combobox
        public Person(string fName, int pID)
        {
            FirstName = fName;
            PersonId = pID;
        }

        public Person(string fName, string lName)
        {
            FirstName = fName;
            LastName = lName;
        }

        //default Person constructor
        public Person()
        {

        }

        //public properties
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int PersonId { get => personId; set => personId = value; }

        //override toString to display firstName attibute value
        public override string ToString()
        {
            return FirstName;
        }
    }
}
