namespace BeautySalonWinFormsApp
{
    partial class ButtonResetDuration
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
            Label labelDescription;
            Label labelPrice;
            Label labelDuration;
            labelTitle = new Label();
            textBoxTitle = new TextBox();
            textBoxDescription = new TextBox();
            numericUpDownDuration = new NumericUpDown();
            numericUpDownPrice = new NumericUpDown();
            buttonSave = new Button();
            buttonCancel = new Button();
            ButtonResetTitle = new Button();
            ButtonResetDescription = new Button();
            ButtonResetPrice = new Button();
            button1 = new Button();
            labelDescription = new Label();
            labelPrice = new Label();
            labelDuration = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDuration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            SuspendLayout();
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(12, 89);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(105, 15);
            labelDescription.TabIndex = 1;
            labelDescription.Text = "Описание услуги:";
            labelDescription.Click += labelDescription_Click;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(12, 201);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(101, 15);
            labelPrice.TabIndex = 2;
            labelPrice.Text = "Стоимость (руб):";
            labelPrice.Click += labelPrice_Click;
            // 
            // labelDuration
            // 
            labelDuration.AutoSize = true;
            labelDuration.Location = new Point(12, 258);
            labelDuration.Name = "labelDuration";
            labelDuration.Size = new Size(121, 15);
            labelDuration.TabIndex = 3;
            labelDuration.Text = "Длительность (мин):";
            labelDuration.Click += labelDuration_Click;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(12, 21);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(102, 15);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Название услуги:";
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(139, 22);
            textBoxTitle.Multiline = true;
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(276, 42);
            textBoxTitle.TabIndex = 4;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(139, 86);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(276, 83);
            textBoxDescription.TabIndex = 5;
            textBoxDescription.TextChanged += textBoxDescription_TextChanged;
            // 
            // numericUpDownDuration
            // 
            numericUpDownDuration.Location = new Point(139, 256);
            numericUpDownDuration.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDownDuration.Name = "numericUpDownDuration";
            numericUpDownDuration.Size = new Size(98, 23);
            numericUpDownDuration.TabIndex = 6;
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.Location = new Point(139, 199);
            numericUpDownPrice.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(98, 23);
            numericUpDownPrice.TabIndex = 7;
            numericUpDownPrice.ValueChanged += numericUpDownPrice_ValueChanged;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(275, 319);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(115, 23);
            buttonSave.TabIndex = 8;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(154, 319);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(115, 23);
            buttonCancel.TabIndex = 9;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // ButtonResetTitle
            // 
            ButtonResetTitle.Location = new Point(421, 21);
            ButtonResetTitle.Name = "ButtonResetTitle";
            ButtonResetTitle.Size = new Size(90, 23);
            ButtonResetTitle.TabIndex = 10;
            ButtonResetTitle.Text = "Сбросить";
            ButtonResetTitle.UseVisualStyleBackColor = true;
            ButtonResetTitle.Click += ButtonResetTitle_Click;
            // 
            // ButtonResetDescription
            // 
            ButtonResetDescription.Location = new Point(421, 85);
            ButtonResetDescription.Name = "ButtonResetDescription";
            ButtonResetDescription.Size = new Size(90, 23);
            ButtonResetDescription.TabIndex = 11;
            ButtonResetDescription.Text = "Сбросить";
            ButtonResetDescription.UseVisualStyleBackColor = true;
            ButtonResetDescription.Click += ButtonResetDescription_Click;
            // 
            // ButtonResetPrice
            // 
            ButtonResetPrice.Location = new Point(243, 197);
            ButtonResetPrice.Name = "ButtonResetPrice";
            ButtonResetPrice.Size = new Size(90, 23);
            ButtonResetPrice.TabIndex = 12;
            ButtonResetPrice.Text = "Сбросить";
            ButtonResetPrice.UseVisualStyleBackColor = true;
            ButtonResetPrice.Click += ButtonResetPrice_Click;
            // 
            // button1
            // 
            button1.Location = new Point(243, 254);
            button1.Name = "button1";
            button1.Size = new Size(90, 23);
            button1.TabIndex = 13;
            button1.Text = "Сбросить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ButtonResetDuration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 354);
            Controls.Add(button1);
            Controls.Add(ButtonResetPrice);
            Controls.Add(ButtonResetDescription);
            Controls.Add(ButtonResetTitle);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(numericUpDownPrice);
            Controls.Add(numericUpDownDuration);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxTitle);
            Controls.Add(labelDuration);
            Controls.Add(labelPrice);
            Controls.Add(labelDescription);
            Controls.Add(labelTitle);
            Name = "ButtonResetDuration";
            Text = "Добавление новой услуги";
            ((System.ComponentModel.ISupportInitialize)numericUpDownDuration).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private TextBox textBoxTitle;
        private TextBox textBoxDescription;
        private NumericUpDown numericUpDownDuration;
        private NumericUpDown numericUpDownPrice;
        private Button buttonSave;
        private Button buttonCancel;
        private Button ButtonResetTitle;
        private Button ButtonResetDescription;
        private Button ButtonResetPrice;
        private Button button1;
    }
}