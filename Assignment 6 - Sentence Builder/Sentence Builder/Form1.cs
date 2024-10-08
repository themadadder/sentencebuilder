using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sentence_Builder
{
    public partial class Form1 : Form
    {

        private string output = "";


        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bigAbutton_Click(object sender, EventArgs e)
        {

            sentenceOutput.Text += "A "; 
        }

        private void smallAButton_Click(object sender, EventArgs e)
        {
            sentenceOutput.Text += "a ";

        }

        private void bigAnButton_Click(object sender, EventArgs e)
        {
            sentenceOutput.Text += "An ";

        }

        private void smallAnButton_Click(object sender, EventArgs e)
        {
            sentenceOutput.Text += "an ";

        }

        private void bigTheButton_Click(object sender, EventArgs e)
        {
            sentenceOutput.Text += "The ";

        }

        private void smallTheButton_Click(object sender, EventArgs e)
        {
            sentenceOutput.Text += "the ";

        }

        private void manButton_Click(object sender, EventArgs e)
        {
            sentenceOutput.Text += "man ";

        }

        private void womanButton_Click(object sender, EventArgs e)
        {
            sentenceOutput.Text += "woman ";

        }

        private void dogButton_Click(object sender, EventArgs e)
        {
            sentenceOutput.Text += "dog ";

        }

        private void catButton_Click(object sender, EventArgs e)
        {
            sentenceOutput.Text += "cat ";

        }

        private void carButton_Click(object sender, EventArgs e)
        {
            sentenceOutput.Text += "car ";

        }

        private void bicycleButton_Click(object sender, EventArgs e)
        {
            sentenceOutput.Text += "bicycle ";

        }

        private void uglyButton_Click(object sender, EventArgs e)
        {
            sentenceOutput.Text += "ugly ";

        }

        private void beautifulButton_Click(object sender, EventArgs e)
        {
            sentenceOutput.Text += "beautiful ";

        }

        private void bigButton_Click(object sender, EventArgs e)
        {
            sentenceOutput.Text += "big ";

        }

        private void smallButton_Click(object sender, EventArgs e)
        {
            sentenceOutput.Text += "small ";

        }

        private void strangeButton_Click(object sender, EventArgs e)
        {
            sentenceOutput.Text += "strange ";

        }

        private void normalButton_Click(object sender, EventArgs e)
        {
            sentenceOutput.Text += "normal ";

        }

        private void lookedAtButton_Click(object sender, EventArgs e)
        {
            sentenceOutput.Text += "looked at ";

        }

        private void rodeButton_Click(object sender, EventArgs e)
        {
            sentenceOutput.Text += "rode ";

        }

        private void spokeToButton_Click(object sender, EventArgs e)
        {
            sentenceOutput.Text += "spoke to ";

        }

        private void laughedAtButton_Click(object sender, EventArgs e)
        {
            sentenceOutput.Text += "laughed at ";

        }

        private void droveButton_Click(object sender, EventArgs e)
        {
            sentenceOutput.Text += "drove ";

        }

        private void spaceButton_Click(object sender, EventArgs e)
        {
            sentenceOutput.Text += " ";

        }

        private void periodButton_Click(object sender, EventArgs e)
        {
            sentenceOutput.Text += ".";

        }

        private void exclamationButton_Click(object sender, EventArgs e)
        {
            sentenceOutput.Text += "!";

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            sentenceOutput.Text = "";

        }

        private void isButton_Click(object sender, EventArgs e)
        {
            sentenceOutput.Text += "is ";
        }

        private void wasButton_Click(object sender, EventArgs e)
        {
            sentenceOutput.Text += "was ";
        }
    }
}
