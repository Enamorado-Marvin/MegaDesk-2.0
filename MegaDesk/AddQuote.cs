using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            
            if(widthInput.Value < 24)
            {
                warningOne.Text = "Minimum width must be 24 inches";
            }
            else if(widthInput.Value > 96)
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
            if (depthInput.Value < 12)
            {
                warningTwo.Text = "Minimum depth must be 12 inches";
            }
            else if (depthInput.Value > 48)
            {
                warningTwo.Text = "Maximum depth must be 48 inches";
            }
            else
            {
                warningTwo.Text = "";
            }
        }

        private void SubmitOrder_Click(object sender, EventArgs e)
        {
            Desk desk = new Desk();
            DeskQuote newQuote = new DeskQuote();
            int material = 0;

            // all entered validation
            try
            {
                if (nameInput != null)
                {
                    newQuote.CustName = nameInput.Text;
                }


                NumericUpDown widthBox = sender as NumericUpDown;
                if (widthInput != null)
                {
                    desk.Width = Convert.ToDouble(widthInput.Value);
                }

                NumericUpDown depthBox = sender as NumericUpDown;
                if (depthInput != null)
                {
                    desk.Depth = desk.Width = Convert.ToDouble(widthInput.Value);
                }
                

                if (drawersInput != null)
                {
                    desk.DrawersNum = uint.Parse(drawersInput.SelectedItem.ToString());
                }
                

                if (materialInput != null)
                {
                    string selectedMaterial = materialInput.SelectedItem.ToString();

                    switch (selectedMaterial)
                    {
                        case "Oak":
                            material = (int)DesktopMaterial.Oak;
                            break;
                        case "Rosewood":
                            material = (int)DesktopMaterial.Rosewood;
                            break;
                        case "Laminate":
                            material = (int)DesktopMaterial.Laminate;
                            break;
                        case "Veneer":
                            material = (int)DesktopMaterial.Veneer;
                            break;
                        case "Pine":
                            material = (int)DesktopMaterial.Pine;
                            break;
                    }
                }
               

                if (rushInput != null)
                {
                    newQuote.RushOrder = uint.Parse(rushInput.SelectedItem.ToString());
                }
                
            }
            catch
            {
                MessageBox.Show("Please enter a value in every field", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            double surfaceArea = newQuote.calcSurfaceArea(desk.Width, desk.Depth);
            double shipping = newQuote.calcShippingCost(surfaceArea, newQuote.RushOrder);
            DateTime quoteDate = DateTime.Today;
            newQuote.QuoteDate = quoteDate;

            double quoteTotal = newQuote.QuoteTotal(material, shipping, surfaceArea, desk.DrawersNum);

            StreamWriter writeQuote = new StreamWriter("newQuote.txt");
            writeQuote.WriteLine(newQuote.CustName);
            writeQuote.WriteLine(newQuote.QuoteDate);
            writeQuote.WriteLine("$" + quoteTotal);
            writeQuote.Close();

            DisplayQuote displayQuote = new DisplayQuote();
            displayQuote.Tag = this;
            displayQuote.Show(this);
            Hide();
        }
    }
}
