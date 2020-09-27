using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Language_Translator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void spanishButton_Click(object sender, EventArgs e)
        {
            translationLabel.Text = "Buenos Dias";
        }

        private void italianButton_Click(object sender, EventArgs e)
        {
            translationLabel.Text = "Buongiorno";
        }

        private void germanButton_Click(object sender, EventArgs e)
        {
            translationLabel.Text = "Guten Morgen";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("I said it didn't do anything! Hello World!");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("chrome.exe", "https://docs.microsoft.com/en-us/dotnet/desktop/winforms/controls/windows-forms-controls-by-function?view=netframeworkdesktop-4.8");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked the radio button!");
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            MessageBox.Show("That's a fine date you've chosen!");
        }
    }
}
