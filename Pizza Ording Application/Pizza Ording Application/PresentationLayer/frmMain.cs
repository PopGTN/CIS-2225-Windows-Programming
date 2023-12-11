using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pizza_Ording_Application.BusinessObjects;

namespace Pizza_Ording_Application
{
    public partial class FrmMain : Form
    {

        List<string> gToppings = new List<string>();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            ddlSause.SelectedIndex = 0;


            ddlToppings.DataSource = Pizza.availableIngredients;
            ddlToppings.SelectedIndex = -1;
            lstTopping.Items.Clear(); //Had to clear because it automactically add stuff to the lstTopping.
            Pizza.pizzaOrder.Clear(); //Not sure if it was doing the same here but cleared just in case. Better safe than Sorry 😂
            gToppings.Clear(); //Need to be cleared on load because it will add cheese to the first pizza
            

        }


        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(ddlSize.Text))
            {
                double size;
                //find the size of the pizza
                switch (ddlSize.SelectedIndex)
                {
                    case 0: 
                    default:
                        size = 10;
                        break;
                    case 1:
                        size = 12;
                        break;
                    case 2:
                        size = 14;
                        break;
                }

                Pizza pizza = new Pizza(size, ddlSause.Text, gToppings);

                Pizza.pizzaOrder.Add(pizza);

                MessageBox.Show("Pizza successfully added");

                resetOrderForm();
            }  
          

        }

        private void btnAddTop_Click(object sender, EventArgs e)
        {
            lstTopping.Items.Add(ddlToppings.Text);
            gToppings.Add(ddlToppings.Text);
        }

        private void btnClearOrder_Click(object sender, EventArgs e)
        {
            Pizza.pizzaOrder.Clear();
            lstSummary.Items.Clear();
        }



        //This event is used to set the Pizzas in the Summary box
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcHome.SelectedTab == tpSummary)
            {
                lstSummary.Items.Clear();
                foreach(Pizza pizza in Pizza.pizzaOrder)
                {
                    
                    lstSummary.Items.Add(pizza.ToString());
                }
            }


        }

        private void ddlToppings_SelectedIndexChanged(object sender, EventArgs e)
        {

            //I have button Not visible. That way I keep my orginale code. 
            //Wasn't sure if I could use the button so i made it hidden in place of this way.
            if (!btnAddTop.Visible)
            {
                lstTopping.Items.Add(ddlToppings.Text);
                gToppings.Add(ddlToppings.Text);
            }
        }

        //Used to reset the form
        private void resetOrderForm()
        {
            ddlSize.SelectedIndex = -1;
            ddlToppings.SelectedIndex = -1;
            gToppings.Clear();
            lstTopping.Items.Clear();
            ddlSause.SelectedIndex = 0;
        }
    }
}
