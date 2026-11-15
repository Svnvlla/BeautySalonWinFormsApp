using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BeautySalonWinFormsApp
{
    public partial class FormappointmentAdd : Form
    {
        public FormappointmentAdd()
        {
            InitializeComponent();
        }

        private void FormappointmentAdd_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonResetAppointmentServiceId_Click(object sender, EventArgs e)
        {
            numericUpDownAppointmentServiceId.Value = 0;
        }

        private void buttonResetAppointmentClientId_Click(object sender, EventArgs e)
        {
            numericUpDownAppointmentClientId.Value = 0;
        }

        private void buttonResetAppointmentMasterId_Click(object sender, EventArgs e)
        {
            numericUpDownAppointmentMasterId.Value = 0;
        }

        private void buttonResetAppointmentStartTime_Click(object sender, EventArgs e)
        {
            textBoxAppointmentStartTime.Clear();
        }

        private void buttonResetAppointmentEndTime_Click(object sender, EventArgs e)
        {
            textBoxAppointmentEndTime.Clear();
        }

        private void buttonResetAppointmentBookedPrice_Click(object sender, EventArgs e)
        {
            numericUpDownAppointmentBookedPrice.Value = 0;
        }

        private void buttonCancelAppointment_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
