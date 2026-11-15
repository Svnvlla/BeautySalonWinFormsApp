namespace BeautySalonWinFormsApp
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBoxLogo = new PictureBox();
            labelAboutText = new Label();
            ButtonClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(12, 12);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(80, 80);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // labelAboutText
            // 
            labelAboutText.AutoSize = true;
            labelAboutText.Font = new Font("Segoe UI", 9F);
            labelAboutText.Location = new Point(98, 12);
            labelAboutText.Name = "labelAboutText";
            labelAboutText.Size = new Size(414, 150);
            labelAboutText.TabIndex = 1;
            labelAboutText.Text = resources.GetString("labelAboutText.Text");
            labelAboutText.Click += labelAboutText_Click;
            // 
            // ButtonClose
            // 
            ButtonClose.Location = new Point(435, 186);
            ButtonClose.Name = "ButtonClose";
            ButtonClose.Size = new Size(89, 23);
            ButtonClose.TabIndex = 3;
            ButtonClose.Text = "Закрыть";
            ButtonClose.UseVisualStyleBackColor = true;
            ButtonClose.Click += ButtonClose_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 221);
            Controls.Add(ButtonClose);
            Controls.Add(labelAboutText);
            Controls.Add(pictureBoxLogo);
            Name = "FormAbout";
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxLogo;
        private Label labelAboutText;
        private Button ButtonClose;
    }
}