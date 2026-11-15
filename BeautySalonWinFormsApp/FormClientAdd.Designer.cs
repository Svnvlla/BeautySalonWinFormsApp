namespace BeautySalonWinFormsApp
{
    partial class FormClientAdd
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
            labelClientFirstName = new Label();
            textBoxClientFirstName = new TextBox();
            buttonResetClientFirstName = new Button();
            labelClientSurname = new Label();
            textBoxClientSurname = new TextBox();
            buttonResetClientSurname = new Button();
            labelClientPatronymic = new Label();
            textBoxClientPatronymic = new TextBox();
            buttonResetClientPatronymic = new Button();
            labelClientPhoneNumber = new Label();
            textBoxClientPhoneNumber = new TextBox();
            buttonResetClientPhoneNumber = new Button();
            labelClientGender = new Label();
            comboBoxClientGender = new ComboBox();
            labelClientBirthDate = new Label();
            dateTimePicker1 = new DateTimePicker();
            buttonCancelClient = new Button();
            buttonSaveClient = new Button();
            SuspendLayout();
            // 
            // labelClientFirstName
            // 
            labelClientFirstName.AutoSize = true;
            labelClientFirstName.Location = new Point(12, 18);
            labelClientFirstName.Name = "labelClientFirstName";
            labelClientFirstName.Size = new Size(34, 15);
            labelClientFirstName.TabIndex = 0;
            labelClientFirstName.Text = "Имя:";
            // 
            // textBoxClientFirstName
            // 
            textBoxClientFirstName.Location = new Point(119, 16);
            textBoxClientFirstName.Name = "textBoxClientFirstName";
            textBoxClientFirstName.Size = new Size(216, 23);
            textBoxClientFirstName.TabIndex = 1;
            // 
            // buttonResetClientFirstName
            // 
            buttonResetClientFirstName.Location = new Point(341, 15);
            buttonResetClientFirstName.Name = "buttonResetClientFirstName";
            buttonResetClientFirstName.Size = new Size(75, 23);
            buttonResetClientFirstName.TabIndex = 2;
            buttonResetClientFirstName.Text = "Сбросить";
            buttonResetClientFirstName.UseVisualStyleBackColor = true;
            buttonResetClientFirstName.Click += buttonResetClientFirstName_Click;
            // 
            // labelClientSurname
            // 
            labelClientSurname.AutoSize = true;
            labelClientSurname.Location = new Point(12, 65);
            labelClientSurname.Name = "labelClientSurname";
            labelClientSurname.Size = new Size(61, 15);
            labelClientSurname.TabIndex = 4;
            labelClientSurname.Text = "Фамилия:";
            // 
            // textBoxClientSurname
            // 
            textBoxClientSurname.Location = new Point(119, 62);
            textBoxClientSurname.Name = "textBoxClientSurname";
            textBoxClientSurname.Size = new Size(216, 23);
            textBoxClientSurname.TabIndex = 5;
            // 
            // buttonResetClientSurname
            // 
            buttonResetClientSurname.Location = new Point(341, 62);
            buttonResetClientSurname.Name = "buttonResetClientSurname";
            buttonResetClientSurname.Size = new Size(75, 23);
            buttonResetClientSurname.TabIndex = 6;
            buttonResetClientSurname.Text = "Сбросить";
            buttonResetClientSurname.UseVisualStyleBackColor = true;
            buttonResetClientSurname.Click += buttonResetClientSurname_Click;
            // 
            // labelClientPatronymic
            // 
            labelClientPatronymic.AutoSize = true;
            labelClientPatronymic.Location = new Point(12, 112);
            labelClientPatronymic.Name = "labelClientPatronymic";
            labelClientPatronymic.Size = new Size(61, 15);
            labelClientPatronymic.TabIndex = 7;
            labelClientPatronymic.Text = "Отчество:";
            labelClientPatronymic.Click += labelClientPatronymic_Click;
            // 
            // textBoxClientPatronymic
            // 
            textBoxClientPatronymic.Location = new Point(119, 108);
            textBoxClientPatronymic.Name = "textBoxClientPatronymic";
            textBoxClientPatronymic.Size = new Size(216, 23);
            textBoxClientPatronymic.TabIndex = 8;
            // 
            // buttonResetClientPatronymic
            // 
            buttonResetClientPatronymic.Location = new Point(341, 108);
            buttonResetClientPatronymic.Name = "buttonResetClientPatronymic";
            buttonResetClientPatronymic.Size = new Size(75, 23);
            buttonResetClientPatronymic.TabIndex = 9;
            buttonResetClientPatronymic.Text = "Сбросить";
            buttonResetClientPatronymic.UseVisualStyleBackColor = true;
            buttonResetClientPatronymic.Click += buttonResetClientPatronymic_Click;
            // 
            // labelClientPhoneNumber
            // 
            labelClientPhoneNumber.AutoSize = true;
            labelClientPhoneNumber.Location = new Point(9, 156);
            labelClientPhoneNumber.Name = "labelClientPhoneNumber";
            labelClientPhoneNumber.Size = new Size(104, 15);
            labelClientPhoneNumber.TabIndex = 10;
            labelClientPhoneNumber.Text = "Номер телефона:";
            // 
            // textBoxClientPhoneNumber
            // 
            textBoxClientPhoneNumber.Location = new Point(119, 153);
            textBoxClientPhoneNumber.Name = "textBoxClientPhoneNumber";
            textBoxClientPhoneNumber.Size = new Size(216, 23);
            textBoxClientPhoneNumber.TabIndex = 11;
            // 
            // buttonResetClientPhoneNumber
            // 
            buttonResetClientPhoneNumber.Location = new Point(341, 152);
            buttonResetClientPhoneNumber.Name = "buttonResetClientPhoneNumber";
            buttonResetClientPhoneNumber.Size = new Size(75, 23);
            buttonResetClientPhoneNumber.TabIndex = 12;
            buttonResetClientPhoneNumber.Text = "Сбросить";
            buttonResetClientPhoneNumber.UseVisualStyleBackColor = true;
            buttonResetClientPhoneNumber.Click += buttonResetClientPhoneNumber_Click;
            // 
            // labelClientGender
            // 
            labelClientGender.AutoSize = true;
            labelClientGender.Location = new Point(9, 199);
            labelClientGender.Name = "labelClientGender";
            labelClientGender.Size = new Size(33, 15);
            labelClientGender.TabIndex = 13;
            labelClientGender.Text = "Пол:";
            // 
            // comboBoxClientGender
            // 
            comboBoxClientGender.FormattingEnabled = true;
            comboBoxClientGender.Items.AddRange(new object[] { "Женский", "Мужской" });
            comboBoxClientGender.Location = new Point(119, 195);
            comboBoxClientGender.Name = "comboBoxClientGender";
            comboBoxClientGender.Size = new Size(216, 23);
            comboBoxClientGender.TabIndex = 14;
            // 
            // labelClientBirthDate
            // 
            labelClientBirthDate.AutoSize = true;
            labelClientBirthDate.Location = new Point(9, 245);
            labelClientBirthDate.Name = "labelClientBirthDate";
            labelClientBirthDate.Size = new Size(93, 15);
            labelClientBirthDate.TabIndex = 16;
            labelClientBirthDate.Text = "Дата рождения:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(119, 239);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(216, 23);
            dateTimePicker1.TabIndex = 17;
            // 
            // buttonCancelClient
            // 
            buttonCancelClient.Location = new Point(103, 319);
            buttonCancelClient.Name = "buttonCancelClient";
            buttonCancelClient.Size = new Size(115, 23);
            buttonCancelClient.TabIndex = 19;
            buttonCancelClient.Text = "Отмена";
            buttonCancelClient.UseVisualStyleBackColor = true;
            buttonCancelClient.Click += buttonCancelClient_Click;
            // 
            // buttonSaveClient
            // 
            buttonSaveClient.Location = new Point(224, 319);
            buttonSaveClient.Name = "buttonSaveClient";
            buttonSaveClient.Size = new Size(115, 23);
            buttonSaveClient.TabIndex = 20;
            buttonSaveClient.Text = "Сохранить";
            buttonSaveClient.UseVisualStyleBackColor = true;
            // 
            // FormClientAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 354);
            Controls.Add(buttonSaveClient);
            Controls.Add(buttonCancelClient);
            Controls.Add(dateTimePicker1);
            Controls.Add(labelClientBirthDate);
            Controls.Add(comboBoxClientGender);
            Controls.Add(labelClientGender);
            Controls.Add(buttonResetClientPhoneNumber);
            Controls.Add(textBoxClientPhoneNumber);
            Controls.Add(labelClientPhoneNumber);
            Controls.Add(buttonResetClientPatronymic);
            Controls.Add(textBoxClientPatronymic);
            Controls.Add(labelClientPatronymic);
            Controls.Add(buttonResetClientSurname);
            Controls.Add(textBoxClientSurname);
            Controls.Add(labelClientSurname);
            Controls.Add(buttonResetClientFirstName);
            Controls.Add(textBoxClientFirstName);
            Controls.Add(labelClientFirstName);
            Name = "FormClientAdd";
            Text = "FormClientAdd";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonResetMasterFirstName;
        private TextBox textBoxMasterFirstName;
        private Label labelClientFirstName;
        private TextBox textBoxClientFirstName;
        private Button buttonResetClientFirstName;
        private Label labelClientSurname;
        private TextBox textBoxClientSurname;
        private Button buttonResetClientSurname;
        private Label labelClientPatronymic;
        private TextBox textBoxClientPatronymic;
        private Button buttonResetClientPatronymic;
        private Label labelClientPhoneNumber;
        private TextBox textBoxClientPhoneNumber;
        private Button buttonResetClientPhoneNumber;
        private Label labelClientGender;
        private ComboBox comboBoxClientGender;
        private Label labelClientBirthDate;
        private DateTimePicker dateTimePicker1;
        private Button buttonCancelClient;
        private Button buttonSaveClient;
    }
}