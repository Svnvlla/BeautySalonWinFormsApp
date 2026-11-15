namespace BeautySalonWinFormsApp
{
    partial class FormMasterAdd
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
            labelMasterFirstName = new Label();
            textBoxMasterFirstName = new TextBox();
            buttonResetMasterFirstName = new Button();
            labelMasterSurname = new Label();
            textBoxMasterSurname = new TextBox();
            buttonResetMasterSurname = new Button();
            labelMasterPatronymic = new Label();
            buttonResetMasterPatronymic = new Button();
            labelMasterSpecialization = new Label();
            textBoxMasterPatronymic = new TextBox();
            textBoxMasterSpecialization = new TextBox();
            buttonResetMasterSpecialization = new Button();
            labelMasterPhoneNumber = new Label();
            textBoxMasterPhoneNumber = new TextBox();
            buttonSaveMaster = new Button();
            buttonResetMasterPhoneNumber = new Button();
            buttonCancelMaster = new Button();
            SuspendLayout();
            // 
            // labelMasterFirstName
            // 
            labelMasterFirstName.AutoSize = true;
            labelMasterFirstName.Location = new Point(12, 16);
            labelMasterFirstName.Name = "labelMasterFirstName";
            labelMasterFirstName.Size = new Size(34, 15);
            labelMasterFirstName.TabIndex = 0;
            labelMasterFirstName.Text = "Имя:";
            // 
            // textBoxMasterFirstName
            // 
            textBoxMasterFirstName.Location = new Point(122, 12);
            textBoxMasterFirstName.Name = "textBoxMasterFirstName";
            textBoxMasterFirstName.Size = new Size(189, 23);
            textBoxMasterFirstName.TabIndex = 1;
            // 
            // buttonResetMasterFirstName
            // 
            buttonResetMasterFirstName.Location = new Point(317, 12);
            buttonResetMasterFirstName.Name = "buttonResetMasterFirstName";
            buttonResetMasterFirstName.Size = new Size(75, 23);
            buttonResetMasterFirstName.TabIndex = 2;
            buttonResetMasterFirstName.Text = "Сбросить";
            buttonResetMasterFirstName.UseVisualStyleBackColor = true;
            buttonResetMasterFirstName.Click += buttonResetMasterFirstName_Click;
            // 
            // labelMasterSurname
            // 
            labelMasterSurname.AutoSize = true;
            labelMasterSurname.Location = new Point(12, 58);
            labelMasterSurname.Name = "labelMasterSurname";
            labelMasterSurname.Size = new Size(61, 15);
            labelMasterSurname.TabIndex = 3;
            labelMasterSurname.Text = "Фамилия:";
            labelMasterSurname.Click += labelMasterSurname_Click;
            // 
            // textBoxMasterSurname
            // 
            textBoxMasterSurname.Location = new Point(122, 55);
            textBoxMasterSurname.Name = "textBoxMasterSurname";
            textBoxMasterSurname.Size = new Size(189, 23);
            textBoxMasterSurname.TabIndex = 4;
            // 
            // buttonResetMasterSurname
            // 
            buttonResetMasterSurname.Location = new Point(317, 54);
            buttonResetMasterSurname.Name = "buttonResetMasterSurname";
            buttonResetMasterSurname.Size = new Size(75, 23);
            buttonResetMasterSurname.TabIndex = 5;
            buttonResetMasterSurname.Text = "Сбросить";
            buttonResetMasterSurname.UseVisualStyleBackColor = true;
            buttonResetMasterSurname.Click += buttonResetMasterSurname_Click;
            // 
            // labelMasterPatronymic
            // 
            labelMasterPatronymic.AutoSize = true;
            labelMasterPatronymic.Location = new Point(12, 108);
            labelMasterPatronymic.Name = "labelMasterPatronymic";
            labelMasterPatronymic.Size = new Size(61, 15);
            labelMasterPatronymic.TabIndex = 6;
            labelMasterPatronymic.Text = "Отчество:";
            // 
            // buttonResetMasterPatronymic
            // 
            buttonResetMasterPatronymic.Location = new Point(317, 100);
            buttonResetMasterPatronymic.Name = "buttonResetMasterPatronymic";
            buttonResetMasterPatronymic.Size = new Size(75, 23);
            buttonResetMasterPatronymic.TabIndex = 8;
            buttonResetMasterPatronymic.Text = "Сбросить";
            buttonResetMasterPatronymic.UseVisualStyleBackColor = true;
            buttonResetMasterPatronymic.Click += buttonResetMasterPatronymic_Click;
            // 
            // labelMasterSpecialization
            // 
            labelMasterSpecialization.AutoSize = true;
            labelMasterSpecialization.Location = new Point(12, 149);
            labelMasterSpecialization.Name = "labelMasterSpecialization";
            labelMasterSpecialization.Size = new Size(96, 15);
            labelMasterSpecialization.TabIndex = 9;
            labelMasterSpecialization.Text = "Специализация:";
            // 
            // textBoxMasterPatronymic
            // 
            textBoxMasterPatronymic.Location = new Point(122, 100);
            textBoxMasterPatronymic.Name = "textBoxMasterPatronymic";
            textBoxMasterPatronymic.Size = new Size(189, 23);
            textBoxMasterPatronymic.TabIndex = 7;
            // 
            // textBoxMasterSpecialization
            // 
            textBoxMasterSpecialization.Location = new Point(122, 149);
            textBoxMasterSpecialization.Multiline = true;
            textBoxMasterSpecialization.Name = "textBoxMasterSpecialization";
            textBoxMasterSpecialization.Size = new Size(189, 68);
            textBoxMasterSpecialization.TabIndex = 10;
            // 
            // buttonResetMasterSpecialization
            // 
            buttonResetMasterSpecialization.Location = new Point(317, 149);
            buttonResetMasterSpecialization.Name = "buttonResetMasterSpecialization";
            buttonResetMasterSpecialization.Size = new Size(75, 23);
            buttonResetMasterSpecialization.TabIndex = 11;
            buttonResetMasterSpecialization.Text = "Сбросить";
            buttonResetMasterSpecialization.UseVisualStyleBackColor = true;
            buttonResetMasterSpecialization.Click += buttonResetMasterSpecialization_Click;
            // 
            // labelMasterPhoneNumber
            // 
            labelMasterPhoneNumber.AutoSize = true;
            labelMasterPhoneNumber.Location = new Point(12, 241);
            labelMasterPhoneNumber.Name = "labelMasterPhoneNumber";
            labelMasterPhoneNumber.Size = new Size(104, 15);
            labelMasterPhoneNumber.TabIndex = 12;
            labelMasterPhoneNumber.Text = "Номер телефона:";
            // 
            // textBoxMasterPhoneNumber
            // 
            textBoxMasterPhoneNumber.Location = new Point(122, 241);
            textBoxMasterPhoneNumber.Name = "textBoxMasterPhoneNumber";
            textBoxMasterPhoneNumber.Size = new Size(189, 23);
            textBoxMasterPhoneNumber.TabIndex = 13;
            // 
            // buttonSaveMaster
            // 
            buttonSaveMaster.Location = new Point(212, 321);
            buttonSaveMaster.Name = "buttonSaveMaster";
            buttonSaveMaster.Size = new Size(115, 23);
            buttonSaveMaster.TabIndex = 16;
            buttonSaveMaster.Text = "Сохранить";
            buttonSaveMaster.UseVisualStyleBackColor = true;
            // 
            // buttonResetMasterPhoneNumber
            // 
            buttonResetMasterPhoneNumber.Location = new Point(317, 241);
            buttonResetMasterPhoneNumber.Name = "buttonResetMasterPhoneNumber";
            buttonResetMasterPhoneNumber.Size = new Size(75, 23);
            buttonResetMasterPhoneNumber.TabIndex = 17;
            buttonResetMasterPhoneNumber.Text = "Сбросить";
            buttonResetMasterPhoneNumber.UseVisualStyleBackColor = true;
            buttonResetMasterPhoneNumber.Click += buttonResetMasterPhoneNumber_Click;
            // 
            // buttonCancelMaster
            // 
            buttonCancelMaster.Location = new Point(91, 321);
            buttonCancelMaster.Name = "buttonCancelMaster";
            buttonCancelMaster.Size = new Size(115, 23);
            buttonCancelMaster.TabIndex = 18;
            buttonCancelMaster.Text = "Отмена";
            buttonCancelMaster.UseVisualStyleBackColor = true;
            buttonCancelMaster.Click += buttonCancelMaster_Click;
            // 
            // FormMasterAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 356);
            Controls.Add(buttonCancelMaster);
            Controls.Add(buttonResetMasterPhoneNumber);
            Controls.Add(buttonSaveMaster);
            Controls.Add(textBoxMasterPhoneNumber);
            Controls.Add(labelMasterPhoneNumber);
            Controls.Add(buttonResetMasterSpecialization);
            Controls.Add(textBoxMasterSpecialization);
            Controls.Add(labelMasterSpecialization);
            Controls.Add(buttonResetMasterPatronymic);
            Controls.Add(textBoxMasterPatronymic);
            Controls.Add(labelMasterPatronymic);
            Controls.Add(buttonResetMasterSurname);
            Controls.Add(textBoxMasterSurname);
            Controls.Add(labelMasterSurname);
            Controls.Add(buttonResetMasterFirstName);
            Controls.Add(textBoxMasterFirstName);
            Controls.Add(labelMasterFirstName);
            Name = "FormMasterAdd";
            Text = "Добавление мастера";
            Load += FormMasterAdd_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMasterFirstName;
        private TextBox textBoxMasterFirstName;
        private Button buttonResetMasterFirstName;
        private Label labelMasterSurname;
        private TextBox textBoxMasterSurname;
        private Button buttonResetMasterSurname;
        private Label labelMasterPatronymic;
        private Button buttonResetMasterPatronymic;
        private Label labelMasterSpecialization;
        private TextBox textBoxMasterPatronymic;
        private TextBox textBoxMasterSpecialization;
        private Button buttonResetMasterSpecialization;
        private Label labelMasterPhoneNumber;
        private TextBox textBoxMasterPhoneNumber;
        private Button buttonSaveMaster;
        private Button buttonResetMasterPhoneNumber;
        private Button buttonCancelMaster;
    }
}