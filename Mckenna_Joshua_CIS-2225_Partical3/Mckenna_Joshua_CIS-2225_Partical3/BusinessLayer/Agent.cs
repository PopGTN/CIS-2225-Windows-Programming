namespace Mckenna_Joshua_CIS_2225_Partical3.BusinessLayer
{
/**
 * Author: Joshua Mckenna
 * Date: 12/1/2023
 * Description:
 * Calculates Comission and holds instances of information for agents
 */

    class Agent
    {

        protected string fName;

        protected string lName;

        protected string email;

        protected double salesAmount;

        protected string commissionRate;

        protected string bonusReduction;

        protected double commissionEarned;

        public string FName { get { return fName; } set { fName = value; } }

        public string LName { get { return lName; } set { lName = value; } }

        public string Email { get { return email; } set { email = value; } }

        public double SalesAmount { get { return salesAmount; } protected set { salesAmount = value; } }

        public string CommissionRate { get { return commissionRate; } protected set { commissionRate = value; } }

        public string BonusReduction { get { return bonusReduction; } protected set { bonusReduction = value; } }

        public double CommissionEarned { get { return commissionEarned; } protected set { commissionEarned = value; } }


        public Agent(string fName, string lName, string email, double salesAmount)
        {
            FName = fName;
            LName = lName;
            Email = email;
            SalesAmount = salesAmount;
        }

        //Calculates Comission
        public virtual void Calculate()
        {
            double output = 0;
            if (salesAmount < 1000)
            {
                commissionRate = "2%";
                output = salesAmount * 0.02;
            }
            else if (salesAmount >= 1000 && salesAmount < 5000)
            {
                commissionRate = "4%";
                output = salesAmount * 0.04;
            }
            else if (salesAmount >= 5000)
            {
                commissionRate = "6%";
                output = salesAmount * 0.06;

            }
            commissionEarned = output;
        }
    }
}
