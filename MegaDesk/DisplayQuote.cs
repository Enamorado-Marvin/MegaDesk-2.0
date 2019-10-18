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
    public partial class DisplayQuote : Form
    {
        public DisplayQuote()
        {
            InitializeComponent();
        }

        private void SeeQuote_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("newQuote.txt");
            while (reader.EndOfStream == false)
            {
                string line = reader.ReadLine();
                ReadFile.Text += line + " ";
                Console.WriteLine(line);
            }
            reader.Close();
        }

        // I couldn't figure out back to main so I sent it back to add quote 
        // I guess a user cou
        private void close_Click(object sender, EventArgs e)
        {
            AddQuote viewMainMenu = (AddQuote)Tag;
            viewMainMenu.Show();
            Close();
        }
    }
}
