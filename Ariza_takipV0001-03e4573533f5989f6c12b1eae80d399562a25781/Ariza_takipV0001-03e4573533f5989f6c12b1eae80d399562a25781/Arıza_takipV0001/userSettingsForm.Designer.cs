namespace WinFormsApp2
{
    partial class userSettingsForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userSettingsForm));
            button1 = new Button();
            pictureBox1 = new PictureBox();
            userLbl = new Label();
            statuLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.White;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(135, 255);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(82, 81);
            button1.TabIndex = 0;
            button1.Text = "Şifre Değiştir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Arıza_takipV0001.Properties.Resources.Başlıksız_1;
            pictureBox1.Location = new Point(149, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // userLbl
            // 
            userLbl.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            userLbl.ForeColor = SystemColors.ActiveCaptionText;
            userLbl.Location = new Point(75, 156);
            userLbl.Name = "userLbl";
            userLbl.Size = new Size(209, 37);
            userLbl.TabIndex = 2;
            userLbl.Text = "kullanıcı";
            userLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // statuLbl
            // 
            statuLbl.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            statuLbl.ForeColor = SystemColors.ActiveCaptionText;
            statuLbl.ImageAlign = ContentAlignment.TopLeft;
            statuLbl.Location = new Point(118, 193);
            statuLbl.Name = "statuLbl";
            statuLbl.Size = new Size(124, 19);
            statuLbl.TabIndex = 3;
            statuLbl.Text = "statü";
            statuLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // userSettingsForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(358, 417);
            Controls.Add(statuLbl);
            Controls.Add(userLbl);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.AppWorkspace;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "userSettingsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanıcı Ayarları";
            FormClosed += userSettingsForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label userLbl;
        private Label statuLbl;
    }
}