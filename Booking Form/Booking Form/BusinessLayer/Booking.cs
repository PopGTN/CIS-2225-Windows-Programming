using System;
using System.Collections.Generic;

/*
 * Author: Joshua Mckenna 
 * Date: 2023/11/10
 * Description: 
 * The Booking Event object is a instance and 
 * holds all the important informatuon for events
 */
namespace Booking_Form.BusinessLayer
{
    public class Booking
    {
        private string venueName;
        private string bandType;
        private string firstName;
        private string lastName;
        private string email;
        private string eventSize;
        private double totalCost;

        public const double BASE_PRICE = 300;


        public Booking() {}
        public Booking(string venueName, string bandType, string firstName, string lastName, string email, string eventSize)
        {
            this.venueName = venueName;
            BandType = bandType;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.eventSize = eventSize;
        }

        public string VenueName { get => venueName; set => venueName = value; }
        public string BandType { get => bandType; set => bandType = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public string EventSize { get => eventSize; set => eventSize = value; }
        public double TotalCost { get => totalCost; set => totalCost = value; }

        public void CalculatePrice()
        {

            double cost = -1;
            
            switch (bandType)
            {
                case "Rock":
                    cost = 1500.00;
                    break;
                case "Pop":
                    cost = 2000.00;
                    break;
                case "Classical":
                    cost = 1200.00;
                    break;
                default:
                    break;
            }

            if (cost != -1)
            {
                cost = Math.Round(cost, 2);
            }

            if (string.Equals("300 and under", eventSize))
            {
                cost *= 1;
            }
            else if (string.Equals("301 to 600 spectators", eventSize))
            {
                cost *= 2;
            }
            else if (string.Equals("601 to 1200 spectators", eventSize))
            {
                cost *= 4;
            }
            totalCost = cost;
        }


        public override string ToString()
        {
            return base.ToString();
        }
    }
}
