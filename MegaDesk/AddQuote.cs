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
        private Desk desk = new Desk();
        private DeskQuote newQuote = new DeskQuote();
        double materialOrder = 0;


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

            desk.Width = uint.Parse(widthInput.Value.ToString());
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

            desk.Depth = uint.Parse(depthInput.Value.ToString());
        }

        private void SubmitOrder_Click(object sender, EventArgs e)
        {
            
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
                    desk.Depth = desk.Depth = Convert.ToDouble(depthInput.Value);
                }
                

                if (drawersInput != null)
                {
                    desk.DrawersNum = uint.Parse(drawersInput.SelectedItem.ToString());
                }
                

                if (materialInput != null)
                {
                    desk.material = materialInput.SelectedItem.ToString();

                    switch (desk.material)
                    {
                        case "Oak":
                            //material = DesktopMaterial.Oak;
                            materialOrder = 200;
                            break;
                        case "Rosewood":
                            //material = DesktopMaterial.Rosewood;
                            materialOrder = 300;
                            break;
                        case "Laminate":
                            //material = DesktopMaterial.Laminate;
                            materialOrder = 100;
                            break;
                        case "Veneer":
                            //material = DesktopMaterial.Veneer;
                            materialOrder = 125;
                            break;
                        case "Pine":
                            //material = DesktopMaterial.Pine;
                            materialOrder = 50;
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
                if (nameInput == null || widthInput == null || depthInput == null || materialInput == null || rushInput == null)
                {
                    MessageBox.Show("Please enter a value in every field", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }

           
            double surfaceArea = newQuote.calcSurfaceArea(desk.Width, desk.Depth);
            double shipping = newQuote.calcShippingCost(surfaceArea, newQuote.RushOrder);
            DateTime quoteDate = DateTime.Today;
            newQuote.QuoteDate = quoteDate;

            double quoteTotal = newQuote.QuoteTotal(materialOrder, shipping, surfaceArea, desk.DrawersNum);

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

        private void AddQuote_Load(object sender, EventArgs e)
        {

        }
    }
}
