namespace Mckenna_Joshua_CIS_2225_Partical3.BusinessLayer
{
/**
 * Author: Joshua Mckenna
 * Date: 12/1/2023
 * Description:
 * Calculates Comission and holds instances of information for Junior agents
 */
    class JuniorAgent : Agent
    {

        public JuniorAgent(string fName, string lName, string email, double salesAmount)
             : base(fName, lName, email, salesAmount)
        {

        }

        //Calculates Comission
        public override void Calculate()
        {
            bonusReduction = "-0.5%";
            double output = 0;
            if (salesAmount < 1000)
            {
                commissionRate = "2%";
                output = salesAmount * 0.02;
                output -= (output * 0.005);

            }
            else if (salesAmount >= 1000 && salesAmount < 5000)
            {
                commissionRate = "4%";
                output = salesAmount * 0.04;
                output -= (output * 0.005);
            }
            else if (salesAmount >= 5000)
            {
                commissionRate = "6%";
                output = salesAmount * 0.06;
                output -= (output * 0.005);
            }
        commissionEarned = output;
        }
    }
}
