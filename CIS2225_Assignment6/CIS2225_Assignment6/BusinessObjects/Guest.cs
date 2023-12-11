namespace CIS2225_Assignment6.BusinessObjects
{
/*
 * Author: Joshua Mckenna 
 * Date: 12/11/2023
 * Description:
 * Holds the important data to edit and display Guest information in the form
 */

    public class Guest
    {
        //private attributes
        private string firstName;
        private string lastName;
        private int guestId;

        //custom constructor used to populate combobox
        public Guest(string fName, int pID)
        {
            FirstName = fName;
            GuestId = pID;
        }

        public Guest(string fName, string lName)
        {
            FirstName = fName;
            LastName = lName;
        }


        public Guest(int pID, string fName, string lName)
        {
            GuestId = pID;
            FirstName = fName;
            LastName = lName;
        }

        //default Person constructor
        public Guest()
        {

        }

        //public properties
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int GuestId { get => guestId; set => guestId = value; }

        //override toString to display firstName attibute value
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
