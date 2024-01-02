namespace Arıza_takipV0001
{
    partial class singInForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(singInForm));
            singInBtn = new Button();
            dataTime = new TextBox();
            company = new TextBox();
            passwdTextBox = new TextBox();
            userTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            errorMessage = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            userSelect = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userSelect).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // singInBtn
            // 
            singInBtn.Location = new Point(94, 309);
            singInBtn.Name = "singInBtn";
            singInBtn.Size = new Size(138, 33);
            singInBtn.TabIndex = 4;
            singInBtn.Text = "Giriş";
            singInBtn.UseVisualStyleBackColor = true;
            singInBtn.Click += singIn_Click;
            // 
            // dataTime
            // 
            dataTime.Enabled = false;
            dataTime.Location = new Point(94, 176);
            dataTime.Name = "dataTime";
            dataTime.Size = new Size(138, 23);
            dataTime.TabIndex = 1;
            // 
            // company
            // 
            company.Enabled = false;
            company.Location = new Point(94, 205);
            company.Name = "company";
            company.Size = new Size(138, 23);
            company.TabIndex = 2;
            // 
            // passwdTextBox
            // 
            passwdTextBox.Location = new Point(94, 263);
            passwdTextBox.Name = "passwdTextBox";
            passwdTextBox.PasswordChar = '●';
            passwdTextBox.Size = new Size(138, 23);
            passwdTextBox.TabIndex = 2;
            passwdTextBox.TextChanged += passwdTextBox_TextChanged;
            // 
            // userTextBox
            // 
            userTextBox.Location = new Point(94, 234);
            userTextBox.Name = "userTextBox";
            userTextBox.Size = new Size(138, 23);
            userTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 179);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 5;
            label1.Text = "Tarih";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 208);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 6;
            label2.Text = "Firma";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 237);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 7;
            label3.Text = "Kullanıcı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 266);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 8;
            label4.Text = "Şifre";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(260, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // errorMessage
            // 
            errorMessage.AutoSize = true;
            errorMessage.ForeColor = Color.Red;
            errorMessage.Location = new Point(94, 341);
            errorMessage.Name = "errorMessage";
            errorMessage.Size = new Size(100, 15);
            errorMessage.TabIndex = 10;
            errorMessage.Text = "                               ";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // userSelect
            // 
            userSelect.BackColor = Color.White;
            userSelect.Image = Properties.Resources.ASD;
            userSelect.Location = new Point(207, 235);
            userSelect.Name = "userSelect";
            userSelect.Size = new Size(22, 21);
            userSelect.TabIndex = 11;
            userSelect.TabStop = false;
            userSelect.Click += userSelect_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = Properties.Resources.close;
            pictureBox2.Location = new Point(206, 265);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 19);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(207, 206);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(22, 21);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // singInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 377);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(userSelect);
            Controls.Add(errorMessage);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(userTextBox);
            Controls.Add(passwdTextBox);
            Controls.Add(company);
            Controls.Add(dataTime);
            Controls.Add(singInBtn);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "singInForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Arıza Takip V0.0.1";
            FormClosed += singInForm_FormClosed;
            Load += Form1_Load;
            KeyDown += singInForm_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)userSelect).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button singInBtn;
        private TextBox dataTime;
        private TextBox company;
        private TextBox passwdTextBox;
        private Label label1;
        private Label label2;
        private Label label4;
        private PictureBox pictureBox1;
        private Label errorMessage;
        private System.Windows.Forms.Timer timer1;
        private PictureBox userSelect;
        private Label label3;
        public TextBox userTextBox;
        private Button button1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}