using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class AddQuote : Form
    {      
        public AddQuote()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }
        
        private void DeskWith_ValueChanged(object sender, EventArgs e)
        {
            
            if(deskWith.Value < 24)
            {
                warningOne.Text = "Minimum width must be 24 inches";
            }
            else if(deskWith.Value > 96)
            {
                warningOne.Text = "Maximum width must be 96 inches";
            }
            else
            {
                warningOne.Text = "";
            }
        }

        private void DeskDepth_ValueChanged(object sender, EventArgs e)
        {
            if (deskDepth.Value < 12)
            {
                warningTwo.Text = "Minimum depth must be 12 inches";
            }
            else if (deskDepth.Value > 48)
            {
                warningTwo.Text = "Maximum depth must be 48 inches";
            }
            else
            {
                warningTwo.Text = "";
            }
        }
    }
}
