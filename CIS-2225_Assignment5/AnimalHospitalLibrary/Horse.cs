using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHospitalLibrary
{
    /*
     * Horse should be similar to Dog
     * Extend the abstract class Animal
     * Create a private attribute of type string name horseType
     * Create a way of accessing horseType(getter and setters or public property)
     * Public array of horse types that is used to populate horse type drop down
     * Create a constructor. Must have parameters to satisfy the Animal base class constructor.
     * Parameters to base class Animal must be passed using base()
     * Override the abstract class AnimalTalk
     * Override toString
     */
    public class Horse : Animal
    {
        public static string[] HORSE_TYPES = { "Thoroughbred", "Quarter Horse", "Arabian", "Clydesdale", "Appaloosa" };

        private string horsetype;
 
        public string Horsetype { get { return horsetype; } set { horsetype = value; } }


        public Horse(string name, int numLegs,string vDate, string reason, string color, string horsetype) : 
        base(name, numLegs,vDate, reason, color)
        {
            this.horsetype = horsetype;

        }
        
        public override string AnimalTalk()
        {
            return "The " + horsetype + " named " + base.AnimalName + " says Naaaa";
        }

        public override string ToString()
        {
            return "The " + horsetype + " named " + base.ToString();
        }
    }
}
