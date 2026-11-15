namespace BeautySalonWinFormsApp
{
    partial class FormappointmentAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelAppointmentClientId = new Label();
            labelAppointmentMasterId = new Label();
            labelAppointmentServiceId = new Label();
            labelAppointmentStartTime = new Label();
            labelAppointmentEndTime = new Label();
            labelAppointmentBookedPrice = new Label();
            labelAppointmentStatus = new Label();
            labelAppointmentDate = new Label();
            numericUpDownAppointmentBookedPrice = new NumericUpDown();
            dateTimePickerAppointmentDate = new DateTimePicker();
            comboBoxAppointmentStatus = new ComboBox();
            buttonResetAppointmentClientId = new Button();
            buttonResetAppointmentEndTime = new Button();
            buttonResetAppointmentServiceId = new Button();
            buttonResetAppointmentMasterId = new Button();
            buttonResetAppointmentStartTime = new Button();
            buttonResetAppointmentBookedPrice = new Button();
            numericUpDownAppointmentClientId = new NumericUpDown();
            numericUpDownAppointmentMasterId = new NumericUpDown();
            numericUpDownAppointmentServiceId = new NumericUpDown();
            textBoxAppointmentStartTime = new TextBox();
            textBoxAppointmentEndTime = new TextBox();
            buttonCancelAppointment = new Button();
            buttonSaveAppointment = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAppointmentBookedPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAppointmentClientId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAppointmentMasterId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAppointmentServiceId).BeginInit();
            SuspendLayout();
            // 
            // labelAppointmentClientId
            // 
            labelAppointmentClientId.AutoSize = true;
            labelAppointmentClientId.Location = new Point(14, 17);
            labelAppointmentClientId.Name = "labelAppointmentClientId";
            labelAppointmentClientId.Size = new Size(71, 15);
            labelAppointmentClientId.TabIndex = 0;
            labelAppointmentClientId.Text = "Клиент (ID):";
            // 
            // labelAppointmentMasterId
            // 
            labelAppointmentMasterId.AutoSize = true;
            labelAppointmentMasterId.Location = new Point(14, 66);
            labelAppointmentMasterId.Name = "labelAppointmentMasterId";
            labelAppointmentMasterId.Size = new Size(73, 15);
            labelAppointmentMasterId.TabIndex = 1;
            labelAppointmentMasterId.Text = "Мастер (ID):";
            // 
            // labelAppointmentServiceId
            // 
            labelAppointmentServiceId.AutoSize = true;
            labelAppointmentServiceId.Location = new Point(14, 109);
            labelAppointmentServiceId.Name = "labelAppointmentServiceId";
            labelAppointmentServiceId.Size = new Size(69, 15);
            labelAppointmentServiceId.TabIndex = 2;
            labelAppointmentServiceId.Text = "Услуга (ID):";
            // 
            // labelAppointmentStartTime
            // 
            labelAppointmentStartTime.AutoSize = true;
            labelAppointmentStartTime.Location = new Point(14, 200);
            labelAppointmentStartTime.Name = "labelAppointmentStartTime";
            labelAppointmentStartTime.Size = new Size(87, 15);
            labelAppointmentStartTime.TabIndex = 4;
            labelAppointmentStartTime.Text = "Время начала:";
            // 
            // labelAppointmentEndTime
            // 
            labelAppointmentEndTime.AutoSize = true;
            labelAppointmentEndTime.Location = new Point(14, 247);
            labelAppointmentEndTime.Name = "labelAppointmentEndTime";
            labelAppointmentEndTime.Size = new Size(108, 15);
            labelAppointmentEndTime.TabIndex = 5;
            labelAppointmentEndTime.Text = "Время окончания:";
            // 
            // labelAppointmentBookedPrice
            // 
            labelAppointmentBookedPrice.AutoSize = true;
            labelAppointmentBookedPrice.Location = new Point(14, 287);
            labelAppointmentBookedPrice.Name = "labelAppointmentBookedPrice";
            labelAppointmentBookedPrice.Size = new Size(101, 15);
            labelAppointmentBookedPrice.TabIndex = 6;
            labelAppointmentBookedPrice.Text = "Стоимость (руб):";
            // 
            // labelAppointmentStatus
            // 
            labelAppointmentStatus.AutoSize = true;
            labelAppointmentStatus.Location = new Point(14, 329);
            labelAppointmentStatus.Name = "labelAppointmentStatus";
            labelAppointmentStatus.Size = new Size(46, 15);
            labelAppointmentStatus.TabIndex = 7;
            labelAppointmentStatus.Text = "Статус:";
            // 
            // labelAppointmentDate
            // 
            labelAppointmentDate.AutoSize = true;
            labelAppointmentDate.Location = new Point(14, 159);
            labelAppointmentDate.Name = "labelAppointmentDate";
            labelAppointmentDate.Size = new Size(74, 15);
            labelAppointmentDate.TabIndex = 8;
            labelAppointmentDate.Text = "Дата визита:";
            // 
            // numericUpDownAppointmentBookedPrice
            // 
            numericUpDownAppointmentBookedPrice.Location = new Point(128, 284);
            numericUpDownAppointmentBookedPrice.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownAppointmentBookedPrice.Name = "numericUpDownAppointmentBookedPrice";
            numericUpDownAppointmentBookedPrice.Size = new Size(150, 23);
            numericUpDownAppointmentBookedPrice.TabIndex = 12;
            // 
            // dateTimePickerAppointmentDate
            // 
            dateTimePickerAppointmentDate.Format = DateTimePickerFormat.Short;
            dateTimePickerAppointmentDate.Location = new Point(129, 153);
            dateTimePickerAppointmentDate.Name = "dateTimePickerAppointmentDate";
            dateTimePickerAppointmentDate.Size = new Size(149, 23);
            dateTimePickerAppointmentDate.TabIndex = 15;
            // 
            // comboBoxAppointmentStatus
            // 
            comboBoxAppointmentStatus.FormattingEnabled = true;
            comboBoxAppointmentStatus.Items.AddRange(new object[] { "Запланировано", "Выполнено", "Отменено" });
            comboBoxAppointmentStatus.Location = new Point(127, 326);
            comboBoxAppointmentStatus.Name = "comboBoxAppointmentStatus";
            comboBoxAppointmentStatus.Size = new Size(151, 23);
            comboBoxAppointmentStatus.TabIndex = 16;
            // 
            // buttonResetAppointmentClientId
            // 
            buttonResetAppointmentClientId.Location = new Point(284, 15);
            buttonResetAppointmentClientId.Name = "buttonResetAppointmentClientId";
            buttonResetAppointmentClientId.Size = new Size(75, 23);
            buttonResetAppointmentClientId.TabIndex = 19;
            buttonResetAppointmentClientId.Text = "Сбросить";
            buttonResetAppointmentClientId.UseVisualStyleBackColor = true;
            buttonResetAppointmentClientId.Click += buttonResetAppointmentClientId_Click;
            // 
            // buttonResetAppointmentEndTime
            // 
            buttonResetAppointmentEndTime.Location = new Point(284, 241);
            buttonResetAppointmentEndTime.Name = "buttonResetAppointmentEndTime";
            buttonResetAppointmentEndTime.Size = new Size(75, 23);
            buttonResetAppointmentEndTime.TabIndex = 20;
            buttonResetAppointmentEndTime.Text = "Сбросить";
            buttonResetAppointmentEndTime.UseVisualStyleBackColor = true;
            buttonResetAppointmentEndTime.Click += buttonResetAppointmentEndTime_Click;
            // 
            // buttonResetAppointmentServiceId
            // 
            buttonResetAppointmentServiceId.Location = new Point(283, 107);
            buttonResetAppointmentServiceId.Name = "buttonResetAppointmentServiceId";
            buttonResetAppointmentServiceId.Size = new Size(75, 23);
            buttonResetAppointmentServiceId.TabIndex = 22;
            buttonResetAppointmentServiceId.Text = "Сбросить";
            buttonResetAppointmentServiceId.UseVisualStyleBackColor = true;
            buttonResetAppointmentServiceId.Click += buttonResetAppointmentServiceId_Click;
            // 
            // buttonResetAppointmentMasterId
            // 
            buttonResetAppointmentMasterId.Location = new Point(284, 64);
            buttonResetAppointmentMasterId.Name = "buttonResetAppointmentMasterId";
            buttonResetAppointmentMasterId.Size = new Size(75, 23);
            buttonResetAppointmentMasterId.TabIndex = 23;
            buttonResetAppointmentMasterId.Text = "Сбросить";
            buttonResetAppointmentMasterId.UseVisualStyleBackColor = true;
            buttonResetAppointmentMasterId.Click += buttonResetAppointmentMasterId_Click;
            // 
            // buttonResetAppointmentStartTime
            // 
            buttonResetAppointmentStartTime.Location = new Point(284, 197);
            buttonResetAppointmentStartTime.Name = "buttonResetAppointmentStartTime";
            buttonResetAppointmentStartTime.Size = new Size(75, 23);
            buttonResetAppointmentStartTime.TabIndex = 24;
            buttonResetAppointmentStartTime.Text = "Сбросить";
            buttonResetAppointmentStartTime.UseVisualStyleBackColor = true;
            buttonResetAppointmentStartTime.Click += buttonResetAppointmentStartTime_Click;
            // 
            // buttonResetAppointmentBookedPrice
            // 
            buttonResetAppointmentBookedPrice.Location = new Point(284, 284);
            buttonResetAppointmentBookedPrice.Name = "buttonResetAppointmentBookedPrice";
            buttonResetAppointmentBookedPrice.Size = new Size(75, 23);
            buttonResetAppointmentBookedPrice.TabIndex = 25;
            buttonResetAppointmentBookedPrice.Text = "Сбросить";
            buttonResetAppointmentBookedPrice.UseVisualStyleBackColor = true;
            buttonResetAppointmentBookedPrice.Click += buttonResetAppointmentBookedPrice_Click;
            // 
            // numericUpDownAppointmentClientId
            // 
            numericUpDownAppointmentClientId.Location = new Point(128, 15);
            numericUpDownAppointmentClientId.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownAppointmentClientId.Name = "numericUpDownAppointmentClientId";
            numericUpDownAppointmentClientId.Size = new Size(150, 23);
            numericUpDownAppointmentClientId.TabIndex = 26;
            // 
            // numericUpDownAppointmentMasterId
            // 
            numericUpDownAppointmentMasterId.Location = new Point(127, 64);
            numericUpDownAppointmentMasterId.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownAppointmentMasterId.Name = "numericUpDownAppointmentMasterId";
            numericUpDownAppointmentMasterId.Size = new Size(150, 23);
            numericUpDownAppointmentMasterId.TabIndex = 27;
            // 
            // numericUpDownAppointmentServiceId
            // 
            numericUpDownAppointmentServiceId.Location = new Point(127, 107);
            numericUpDownAppointmentServiceId.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownAppointmentServiceId.Name = "numericUpDownAppointmentServiceId";
            numericUpDownAppointmentServiceId.Size = new Size(150, 23);
            numericUpDownAppointmentServiceId.TabIndex = 28;
            // 
            // textBoxAppointmentStartTime
            // 
            textBoxAppointmentStartTime.Location = new Point(127, 198);
            textBoxAppointmentStartTime.Name = "textBoxAppointmentStartTime";
            textBoxAppointmentStartTime.Size = new Size(150, 23);
            textBoxAppointmentStartTime.TabIndex = 29;
            // 
            // textBoxAppointmentEndTime
            // 
            textBoxAppointmentEndTime.Location = new Point(127, 241);
            textBoxAppointmentEndTime.Name = "textBoxAppointmentEndTime";
            textBoxAppointmentEndTime.Size = new Size(150, 23);
            textBoxAppointmentEndTime.TabIndex = 30;
            // 
            // buttonCancelAppointment
            // 
            buttonCancelAppointment.Location = new Point(78, 395);
            buttonCancelAppointment.Name = "buttonCancelAppointment";
            buttonCancelAppointment.Size = new Size(115, 23);
            buttonCancelAppointment.TabIndex = 31;
            buttonCancelAppointment.Text = "Отмена";
            buttonCancelAppointment.UseVisualStyleBackColor = true;
            buttonCancelAppointment.Click += buttonCancelAppointment_Click;
            // 
            // buttonSaveAppointment
            // 
            buttonSaveAppointment.Location = new Point(199, 395);
            buttonSaveAppointment.Name = "buttonSaveAppointment";
            buttonSaveAppointment.Size = new Size(115, 23);
            buttonSaveAppointment.TabIndex = 32;
            buttonSaveAppointment.Text = "Сохранить";
            buttonSaveAppointment.UseVisualStyleBackColor = true;
            // 
            // FormappointmentAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 430);
            Controls.Add(buttonSaveAppointment);
            Controls.Add(buttonCancelAppointment);
            Controls.Add(textBoxAppointmentEndTime);
            Controls.Add(textBoxAppointmentStartTime);
            Controls.Add(numericUpDownAppointmentServiceId);
            Controls.Add(numericUpDownAppointmentMasterId);
            Controls.Add(numericUpDownAppointmentClientId);
            Controls.Add(buttonResetAppointmentBookedPrice);
            Controls.Add(buttonResetAppointmentStartTime);
            Controls.Add(buttonResetAppointmentMasterId);
            Controls.Add(buttonResetAppointmentServiceId);
            Controls.Add(buttonResetAppointmentEndTime);
            Controls.Add(buttonResetAppointmentClientId);
            Controls.Add(comboBoxAppointmentStatus);
            Controls.Add(dateTimePickerAppointmentDate);
            Controls.Add(numericUpDownAppointmentBookedPrice);
            Controls.Add(labelAppointmentDate);
            Controls.Add(labelAppointmentStatus);
            Controls.Add(labelAppointmentBookedPrice);
            Controls.Add(labelAppointmentEndTime);
            Controls.Add(labelAppointmentStartTime);
            Controls.Add(labelAppointmentServiceId);
            Controls.Add(labelAppointmentMasterId);
            Controls.Add(labelAppointmentClientId);
            Name = "FormappointmentAdd";
            Text = "FormappointmentAdd";
            Load += FormappointmentAdd_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownAppointmentBookedPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAppointmentClientId).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAppointmentMasterId).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAppointmentServiceId).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAppointmentClientId;
        private Label labelAppointmentMasterId;
        private Label labelAppointmentServiceId;
        private Label labelAppointmentStartTime;
        private Label labelAppointmentEndTime;
        private Label labelAppointmentBookedPrice;
        private Label labelAppointmentStatus;
        private Label labelAppointmentDate;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDownAppointmentBookedPrice;
        private DateTimePicker dateTimePickerAppointmentDate;
        private ComboBox comboBoxAppointmentStatus;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button buttonResetAppointmentClientId;
        private Button buttonResetAppointmentEndTime;
        private Button buttonResetAppointmentServiceId;
        private Button buttonResetAppointmentMasterId;
        private Button buttonResetAppointmentStartTime;
        private Button buttonResetAppointmentBookedPrice;
        private NumericUpDown numericUpDownAppointmentClientId;
        private NumericUpDown numericUpDownAppointmentMasterId;
        private NumericUpDown numericUpDownAppointmentServiceId;
        private TextBox textBoxAppointmentStartTime;
        private TextBox textBoxAppointmentEndTime;
        private Button buttonCancelAppointment;
        private Button buttonSaveAppointment;
    }
}