namespace Arıza_takipV0001
{
    partial class adminSettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminSettingsForm));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            newPasswdBtn = new Button();
            newUserBtn = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(155, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(85, 152);
            label1.Name = "label1";
            label1.Size = new Size(193, 37);
            label1.TabIndex = 1;
            label1.Text = "label1";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Location = new Point(135, 189);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 2;
            label2.Text = "label2";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // newPasswdBtn
            // 
            newPasswdBtn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            newPasswdBtn.Location = new Point(13, 281);
            newPasswdBtn.Name = "newPasswdBtn";
            newPasswdBtn.Size = new Size(75, 75);
            newPasswdBtn.TabIndex = 3;
            newPasswdBtn.Text = "  Şifre \r\nDeğiştir";
            newPasswdBtn.UseVisualStyleBackColor = true;
            newPasswdBtn.Click += button1_Click;
            // 
            // newUserBtn
            // 
            newUserBtn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            newUserBtn.Location = new Point(186, 281);
            newUserBtn.Name = "newUserBtn";
            newUserBtn.Size = new Size(75, 75);
            newUserBtn.TabIndex = 4;
            newUserBtn.Text = "Kullanıcı \r\nEkle";
            newUserBtn.UseVisualStyleBackColor = true;
            newUserBtn.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(272, 281);
            button1.Name = "button1";
            button1.Size = new Size(75, 75);
            button1.TabIndex = 5;
            button1.Text = "Kullanıcı Sil";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(100, 281);
            button2.Name = "button2";
            button2.Size = new Size(75, 75);
            button2.TabIndex = 6;
            button2.Text = "Firma Ekle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // adminSettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 417);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(newUserBtn);
            Controls.Add(newPasswdBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "adminSettingsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanıcı Ayarları";
            FormClosed += adminSettingsForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label userName;
        private Label userStatu;
        private Button newPasswdBtn;
        private Button newUserBtn;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}