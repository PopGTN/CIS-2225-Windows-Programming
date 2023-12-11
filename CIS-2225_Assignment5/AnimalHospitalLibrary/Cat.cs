using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHospitalLibrary
{
    /*
     * Cat should be similar to Dog
     * Extend the abstract class Animal
     * Create a private attribute of type string name catType
     * Create a way of accessing catType(getter and setters or public property)
     * Create a public array of cat types that is used to populate cat type drop down
     * Create a custom constructor. Must have parameters to satisfy the Animal base class constructor.
     * Parameters to base class Animal must be passed using base()
     * Override the abstract class AnimalTalk
     * Override toString
     */
    public class Cat : Animal
    {
        public static string[] CAT_TYPES = { "Siamese", "Persian", "Maine Coon", "Bengal", "Sphynx" };

        private string catType;

        public string CatType { get { return catType; } set { catType = value; } }


        public Cat(string name, int numLegs, string vDate, string reason, string color, string catType) :
        base(name, numLegs, vDate, reason, color)
        {
            this.catType = catType;

        }

        public override string AnimalTalk()
        {
            return "The " + catType + " named " + base.AnimalName + " says meow";
        }

        public override string ToString()
        {
            return "The " + catType + " named " + base.ToString();
        }
    }
}
