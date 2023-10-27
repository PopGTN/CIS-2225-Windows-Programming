using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Ording_Application.BusinessObjects
{
    class Pizza
    {
        public double size { get; set; }
        public string sauceType { get; set; }
        public List<string> toppings { get; set; } 
        public double cost { get; private set; }
        public static List<Pizza> pizzaOrder = new List<Pizza>();
        public static List<string> availableIngredients = new List<string>
        {
            "Cheese", 
            "Pepperoni", 
            "Mushrooms", 
            "Onions", 
            "Peppers",
            "Sausage", 
            "Bacon", 
            "Extra cheese",
            "Black olives",
            "Green peppers",
            "Pineapple",
            "Spinach"
        };

        public Pizza(){}
        public Pizza(double size, string sauceType, List<string> toppings)
        {
            this.size = size;
            this.sauceType = sauceType;
            this.toppings = new List<string>();
            foreach(string topping in toppings)
            {
                this.toppings.Add(topping);
            }
            CalculateCost();
        }


        public void CalculateCost() 
        {
            double cost = 0;

            switch (size)
            {
                case 10:
                    cost += 5;
                    break;
                case 12:
                    cost += 8;
                    break;
                case 14:
                    cost += 12;
                    break;
            }

            foreach (String ingredient in toppings)
            {
                cost += 0.75;
            }

            this.cost += cost; 

        } 
        public override string ToString()
        {
            return  "Size: " + size + "\" Sauce: " + sauceType + " Ingredients: " + string.Join(", ", toppings) + " Cost: $" + cost;
        }

    }

}
