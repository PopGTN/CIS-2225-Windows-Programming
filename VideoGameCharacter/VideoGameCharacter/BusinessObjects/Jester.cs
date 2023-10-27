using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGameCharacter.BusinessObjects
{
    public class Jester : CharacterBase
    {
        private string hatType;

        public string HatType { get => hatType; set => hatType = value; }

        public override string ToString()
        {
            return "The Jesters hat is: " + hatType +". " + base.ToString();
        }
    }
}
