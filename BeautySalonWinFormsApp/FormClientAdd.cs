using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BeautySalonWinFormsApp
{
    public partial class FormClientAdd : Form
    {
        public FormClientAdd()
        {
            InitializeComponent();
        }

        private void labelMasterFirstName_Click(object sender, EventArgs e)
        {

        }

        private void buttonResetMasterFirstName_Click(object sender, EventArgs e)
        {
            textBoxMasterFirstName.Clear();
        }

        private void buttonResetMasterSurname_Click(object sender, EventArgs e)
        {
        }

        private void buttonResetMasterPatronymic_Click(object sender, EventArgs e)
        {
        }

        private void buttonResetMasterSpecialization_Click(object sender, EventArgs e)
        {
        }

        private void buttonResetMasterPhoneNumber_Click(object sender, EventArgs e)
        {
        }

        private void buttonCancelMaster_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelClientPatronymic_Click(object sender, EventArgs e)
        {

        }

        private void buttonResetClientFirstName_Click(object sender, EventArgs e)
        {
            textBoxClientFirstName.Clear();
        }

        private void buttonResetClientSurname_Click(object sender, EventArgs e)
        {
            textBoxClientSurname.Clear();
        }

        private void buttonResetClientPatronymic_Click(object sender, EventArgs e)
        {
            textBoxClientPatronymic.Clear();
        }

        private void buttonResetClientPhoneNumber_Click(object sender, EventArgs e)
        {
            textBoxClientPhoneNumber.Clear();
        }

        private void buttonResetClientGender_Click(object sender, EventArgs e)
        {
        }

        private void buttonCancelClient_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
