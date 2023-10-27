using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoGameCharacter.BusinessObjects;

namespace VideoGameCharacter
{
    public partial class frmCharHome : Form
    {
        public frmCharHome()
        {
            InitializeComponent();
        }
        //Global bool checks if any race radio button checked
        bool raceChecked = false;


        private void frmCharHome_Load(object sender, EventArgs e)
        {
            foreach (string s in CharacterBase.statsList)
            {
                clbStats.Items.Add(s);
            }
        }

        private void btnJCreate_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                Jester newJChar = new Jester();
                newJChar.Name = txtName.Text;
                newJChar.Race = SetCharacterRace();
                newJChar.Age = int.Parse(txtAge.Text);
                newJChar.HatType = cmbHats.Text;

                //create a local list to store stats from clb
                List<string> sList = new List<string>();

                //loop through the checked list box
                for (int i = 0; i < clbStats.Items.Count; i++)
                {
                    //Check if item at index i is Checked. It will return true if checked
                    if (clbStats.GetItemChecked(i))
                    {
                        //store text value in a string
                        string value = (string)clbStats.Items[i];
                        //add string value to local list of stats
                        sList.Add(value);
                    }
                }

                newJChar.Stats = sList;

                CharacterBase.characters.Add(newJChar);

                
                ClearStats();
            }
            

        }

        private bool ValidateInput()
        {
            string errorMessage = "The issues are: ";
            int originalErrorMessageLength = errorMessage.Length;

            if (string.IsNullOrEmpty(txtName.Text))
            {
                errorMessage += "Name is missing. ";
            }
            if (int.TryParse(txtAge.Text, out int age) == false || age < 0)
            {
                errorMessage += "Age is not correct. ";
            }
            if (CheckStatsChecked() == 0)
            {
                errorMessage += "No stats selected. ";
            }
            if (cmbHats.SelectedIndex < 0)
            {
                errorMessage += "No hat selected. ";
            }
            if (raceChecked == false)
            {
                errorMessage += "No race checked. ";
            }

            if (errorMessage.Length > originalErrorMessageLength)
            {
                MessageBox.Show(errorMessage, "Input Issues");
                return false;
            }
            else
            {
                return true;
            }
        }

        private int CheckStatsChecked()
        {
            int checkedCount = 0;
            for (int i = 0; i < clbStats.Items.Count; i++)
            {
                //Check if item at index i is Checked. It will return true if checked
                if (clbStats.GetItemChecked(i))
                {
                    checkedCount++;
                }
            }

            return checkedCount;
        }

        private void ClearStats()
        {
            for (int i = 0; i < clbStats.Items.Count; i++)
            {
                clbStats.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private string SetCharacterRace()
        {
            string returnVal = "";

            if (rbHuman.Checked)
            {
                returnVal = rbHuman.Text;
            }
            else if (rbElf.Checked)
            {
                returnVal = rbElf.Text;
            }
            else 
            {
                returnVal = rbDwarf.Text;
            }

            return returnVal;
        }

        private void rbHuman_CheckedChanged(object sender, EventArgs e)
        {
            raceChecked = true;
        }

        private void rbElf_CheckedChanged(object sender, EventArgs e)
        {
            raceChecked = true;
        }

        private void rbDwarf_CheckedChanged(object sender, EventArgs e)
        {
            raceChecked = true;
        }

        private void tcChar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcChar.SelectedTab == tpSummary)
            {
                rtxDisplay.Clear();

                foreach (CharacterBase c in CharacterBase.characters)
                {
                    rtxDisplay.Text += c.ToString() + "\n";

                }
            }
        }
    }
}
