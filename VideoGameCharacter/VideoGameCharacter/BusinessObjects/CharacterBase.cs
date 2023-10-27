using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGameCharacter.BusinessObjects
{
    public class CharacterBase
    {
        //create the attributes of the base character
        private string name;
        private string race;
        private int age;
        private List<string> stats;

        public string Name { get => name; set => name = value; }
        public string Race { get => race; set => race = value; }
        public int Age { get => age; set => age = value; }
        public List<string> Stats { get => stats; set => stats = value; }

        //public accessable 
        public static string[] statsList = { "Health", "Strength", "Speed", "Luck", "Dexterity" };
        public static List<CharacterBase> characters = new List<CharacterBase>();

        public override string ToString()
        {
            return "The name is: " + Name + " age: " + Age + " race " + Race + " stats" + ShowStats();
        }

        public string ShowStats()
        {
            string displayStats = "";
            foreach (string s in Stats)
            {
                displayStats += s + " ";
            }
            return displayStats;
        }
    }
}
