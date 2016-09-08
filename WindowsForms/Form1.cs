using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            buttonOK.Enabled = false;
        }


        private void buttonOK_Click(object sender, EventArgs e)
        {
            string output;

            output = "Name: " + textBoxName.Text + "\r\n";
            output += "Address: " + textBoxAddress.Text + "\r\n";
            output += "Occupation: " + (string)(checkBoxProgrammer.Checked ?
                "Programmer" : "Not a programmer") + "\r\n";
            output += "Sex: " + (string)(radioButtonFemale.Checked ? "Female" :
                "Male") + "\r\n";
            output += "Age: " + textBoxAge.Text + "\r\n";

            textBoxOutput.Text = output;

        }

        private void Help_Click(object sender, EventArgs e)
        {
            // Write a short description of each TextBox in the Output TextBox.
            string output;
            output = "Name = Your name\r\n";
            output += "Address = Your address\r\n";
            output += "Programmer = Check 'Programmer' if you are a programmer\r\n";
            output += "Sex = Choose your sex\r\n";
            output += "Age = Your age";
            // Insert the new text.
            textBoxOutput.Text = output;
            
        }

        private void textBoxEmpty_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length == 0)
                tb.BackColor = Color.Red;
            else
                tb.BackColor = SystemColors.Window;
            ValidateOk();
        }

        private void ValidateOk()
        {
            buttonOK.Enabled = (textBoxName.BackColor != Color.Red &&
                textBoxAddress.BackColor != Color.Red &&
            textBoxAge.BackColor != Color.Red);
        }

        private void textBoxAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
