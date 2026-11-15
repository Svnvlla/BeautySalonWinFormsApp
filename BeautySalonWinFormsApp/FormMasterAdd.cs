using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BeautySalonWinFormsApp
{
    public partial class FormMasterAdd : Form
    {
        public FormMasterAdd()
        {
            InitializeComponent();
        }

        private void labelMasterSurname_Click(object sender, EventArgs e)
        {

        }

        private void FormMasterAdd_Load(object sender, EventArgs e)
        {

        }

        private void buttonResetMasterFirstName_Click(object sender, EventArgs e)
        {
            textBoxMasterFirstName.Clear();
        }

        private void buttonResetMasterSurname_Click(object sender, EventArgs e)
        {
            textBoxMasterSurname.Clear();
        }

        private void buttonResetMasterPatronymic_Click(object sender, EventArgs e)
        {
            textBoxMasterPatronymic.Clear();
        }

        private void buttonResetMasterSpecialization_Click(object sender, EventArgs e)
        {
            textBoxMasterSpecialization.Clear();
        }

        private void buttonResetMasterPhoneNumber_Click(object sender, EventArgs e)
        {
            textBoxMasterPhoneNumber.Clear();
        }

        private void buttonCancelMaster_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
