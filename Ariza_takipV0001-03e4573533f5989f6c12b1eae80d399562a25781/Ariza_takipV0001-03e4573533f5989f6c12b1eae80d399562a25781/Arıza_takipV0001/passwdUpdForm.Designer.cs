namespace Arıza_takipV0001
{
    partial class passwdUpdForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(passwdUpdForm));
            pictureBox1 = new PictureBox();
            userLbl = new Label();
            oldPassword = new TextBox();
            saveBtn = new Button();
            statuLbl = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            rePassword = new TextBox();
            newPassword = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(157, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 95);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // userLbl
            // 
            userLbl.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            userLbl.Location = new Point(67, 148);
            userLbl.Name = "userLbl";
            userLbl.Size = new Size(232, 37);
            userLbl.TabIndex = 1;
            userLbl.Text = "label1";
            userLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // oldPassword
            // 
            oldPassword.BackColor = Color.White;
            oldPassword.ForeColor = SystemColors.WindowText;
            oldPassword.Location = new Point(126, 229);
            oldPassword.Name = "oldPassword";
            oldPassword.PasswordChar = '●';
            oldPassword.Size = new Size(149, 23);
            oldPassword.TabIndex = 1;
            oldPassword.TextChanged += oldPassword_TextChanged;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(126, 328);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(149, 25);
            saveBtn.TabIndex = 3;
            saveBtn.Tag = "enter";
            saveBtn.Text = "Onayla";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // statuLbl
            // 
            statuLbl.AutoSize = true;
            statuLbl.Location = new Point(164, 185);
            statuLbl.Name = "statuLbl";
            statuLbl.Size = new Size(38, 15);
            statuLbl.TabIndex = 4;
            statuLbl.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 232);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 5;
            label3.Text = "Mevcut Şifre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 261);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 6;
            label4.Text = "Yeni Şifre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 290);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 7;
            label5.Text = "Şifre Doğrula";
            // 
            // rePassword
            // 
            rePassword.Location = new Point(126, 287);
            rePassword.Name = "rePassword";
            rePassword.PasswordChar = '●';
            rePassword.Size = new Size(149, 23);
            rePassword.TabIndex = 3;
            rePassword.TextChanged += rePassword_TextChanged;
            // 
            // newPassword
            // 
            newPassword.Location = new Point(126, 258);
            newPassword.Name = "newPassword";
            newPassword.PasswordChar = '●';
            newPassword.Size = new Size(149, 23);
            newPassword.TabIndex = 2;
            newPassword.TextChanged += newPassword_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = Properties.Resources.close;
            pictureBox2.Location = new Point(249, 231);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 19);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            pictureBox2.Click += pictureBox2_Click_1;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Image = Properties.Resources.close;
            pictureBox3.Location = new Point(249, 260);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(24, 19);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            pictureBox3.Visible = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // passwdUpdForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 417);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(newPassword);
            Controls.Add(rePassword);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(statuLbl);
            Controls.Add(saveBtn);
            Controls.Add(oldPassword);
            Controls.Add(userLbl);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "passwdUpdForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Şifre Güncelleme";
            FormClosed += passwdUpdForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label userLbl;
        private TextBox oldPassword;
        private Button saveBtn;
        private Label statuLbl;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox rePassword;
        private TextBox newPassword;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}