using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BeautySalonWinFormsApp
{
    public partial class ButtonResetDuration : Form
    {
        public ButtonResetDuration()
        {
            InitializeComponent();
        }

        private void numericUpDownPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelDuration_Click(object sender, EventArgs e)
        {

        }

        private void labelDescription_Click(object sender, EventArgs e)
        {

        }

        private void labelPrice_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDownPrice_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonResetTitle_Click(object sender, EventArgs e)
        {
            textBoxTitle.Clear();
        }

        private void ButtonResetDescription_Click(object sender, EventArgs e)
        {
            textBoxDescription.Clear();
        }

        private void ButtonResetPrice_Click(object sender, EventArgs e)
        {
            numericUpDownPrice.Value = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numericUpDownDuration.Value = 0;
        }
    }
}
