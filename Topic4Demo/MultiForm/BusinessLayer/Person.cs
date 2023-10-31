using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiForm.BusinessLayer
{
    public class Person
    {
        private string name;
        private int age;
        private string hairColor;
        private string eyeColor;
        private string country;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string HairColor { get => hairColor; set => hairColor = value; }
        public string EyeColor { get => eyeColor; set => eyeColor = value; }
        public string Country { get => country; set => country = value; }

        public static List<Person> people = new List<Person>();
        //create a static array of countries
        public static string[] countries = { "Canada", "USA", "Mexico", "Brazil", "England", "Germany", "France" };
        public override string ToString()
        {
            return "Name: " + this.name + ", age: " + this.age + ", hair color: "
                + this.hairColor + " eye color: " + this.eyeColor + ", country: " + this.country;
        }
    }
}
