using Mckenna_Joshua_CIS_2225_Partical3.BusinessLayer;
using System;
using System.Drawing;
using System.Windows.Forms;
/**
 * Author: Joshua Mckenna
 * Date: 12/1/2023
 * Description:
 * Controls the the functions of frmMain
 */
namespace Mckenna_Joshua_CIS_2225_Partical3
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {


            if (ValidateForm())
            {
                //Junior Agent Calculation
                if (rdoJunior.Checked)
                {
                    JuniorAgent ja = new JuniorAgent(txtFName.Text, txtLName.Text, txtEmail.Text, double.Parse(txtSalesAmount.Text));
                    ja.Calculate();
                    txtEarned.Text = "$" + Math.Round(ja.CommissionEarned, 2).ToString();
                    txtRate.Text = ja.CommissionRate;
                    txtBoRe.Text = ja.BonusReduction;

                }
                //Agent Calculation
                else if (rdoAgent.Checked)
                {
                    Agent ag = new Agent(txtFName.Text, txtLName.Text, txtEmail.Text, double.Parse(txtSalesAmount.Text));
                    ag.Calculate();
                    txtEarned.Text = "$" + Math.Round(ag.CommissionEarned, 2).ToString();
                    txtRate.Text = ag.CommissionRate;
                }
                //Senior Agent Calculation
                else if (rdoSenior.Checked)
                {
                    SeniorAgent sa = new SeniorAgent(txtFName.Text, txtLName.Text, txtEmail.Text, double.Parse(txtSalesAmount.Text));
                    sa.Calculate();
                    txtEarned.Text = "$" + Math.Round(sa.CommissionEarned, 2).ToString();
                    txtRate.Text = sa.CommissionRate;
                    txtBoRe.Text = sa.BonusReduction;
                }
            }
            else
            {
                MessageBox.Show("Please finish filling out the form!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFName.Text = "";
            txtLName.Text = "";
            txtEmail.Text = "";
            txtSalesAmount.Text = "";
            rdoAgent.Checked = false;
            rdoSenior.Checked = false;
            rdoJunior.Checked = false;
            txtEarned.Text = "";
            txtBoRe.Text = "";
            txtRate.Text = "";
        }


        //Validates form
        private bool ValidateForm()
        {
            bool isVald = true;
            if (String.IsNullOrEmpty(txtFName.Text))
            {
                lblFName.ForeColor = Color.Red;
                isVald = false;
            }
            else
            {
                lblFName.ForeColor = Color.Black;
            }

            if (String.IsNullOrEmpty(txtLName.Text))
            {
                lblLName.ForeColor = Color.Red;
                isVald = false;
            }
            else
            {
                lblLName.ForeColor = Color.Black;
            }

            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                lblEmail.ForeColor = Color.Red;
                isVald = false;
            }
            else
            {
                lblEmail.ForeColor = Color.Black;
            }

            if (String.IsNullOrEmpty(txtSalesAmount.Text))
            {
                lblSalesAmount.ForeColor = Color.Red;
                isVald = false;

            }
            else
            {
                if (double.TryParse(txtSalesAmount.Text, out double output) == false)
                {
                    lblSalesAmount.ForeColor = Color.Red;
                    isVald = false;
                }
                else
                {
                    lblSalesAmount.ForeColor = Color.Black;
                }
            }

            if (rdoAgent.Checked == false && rdoSenior.Checked == false && rdoJunior.Checked == false){

                grpAgentType.ForeColor = Color.Red;
            } 
            else
            {
                grpAgentType.ForeColor = Color.Black;
            }

            return isVald;
        }
    }
}
