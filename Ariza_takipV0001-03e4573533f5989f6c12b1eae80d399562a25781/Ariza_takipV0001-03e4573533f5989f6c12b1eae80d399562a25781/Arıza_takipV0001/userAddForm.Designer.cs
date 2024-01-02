namespace Arıza_takipV0001
{
    partial class userAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userAddForm));
            label1 = new Label();
            userAddName = new TextBox();
            userSaveBtn = new Button();
            userPassword = new TextBox();
            label2 = new Label();
            userRePassword = new TextBox();
            label3 = new Label();
            label4 = new Label();
            saveUser = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            kullanici = new DataGridViewTextBoxColumn();
            statu = new DataGridViewTextBoxColumn();
            passwd = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)saveUser).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 25);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı";
            // 
            // userAddName
            // 
            userAddName.Location = new Point(104, 22);
            userAddName.Name = "userAddName";
            userAddName.Size = new Size(153, 23);
            userAddName.TabIndex = 1;
            // 
            // userSaveBtn
            // 
            userSaveBtn.Location = new Point(104, 146);
            userSaveBtn.Name = "userSaveBtn";
            userSaveBtn.Size = new Size(153, 34);
            userSaveBtn.TabIndex = 5;
            userSaveBtn.Text = "Kaydet";
            userSaveBtn.UseVisualStyleBackColor = true;
            userSaveBtn.Click += userSaveBtn_Click;
            // 
            // userPassword
            // 
            userPassword.Location = new Point(104, 79);
            userPassword.Name = "userPassword";
            userPassword.PasswordChar = '●';
            userPassword.Size = new Size(153, 23);
            userPassword.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 82);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 3;
            label2.Text = "Şifre";
            // 
            // userRePassword
            // 
            userRePassword.Location = new Point(104, 108);
            userRePassword.Name = "userRePassword";
            userRePassword.PasswordChar = '●';
            userRePassword.Size = new Size(153, 23);
            userRePassword.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 111);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 5;
            label3.Text = "Şifre Doğrula";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 54);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 7;
            label4.Text = "Statü";
            // 
            // saveUser
            // 
            saveUser.AllowUserToAddRows = false;
            saveUser.AllowUserToDeleteRows = false;
            saveUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            saveUser.Columns.AddRange(new DataGridViewColumn[] { id, kullanici, statu, passwd });
            saveUser.Location = new Point(29, 239);
            saveUser.Name = "saveUser";
            saveUser.ReadOnly = true;
            saveUser.RowTemplate.Height = 25;
            saveUser.Size = new Size(299, 166);
            saveUser.TabIndex = 9;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "Id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 25;
            // 
            // kullanici
            // 
            kullanici.DataPropertyName = "kullanici";
            kullanici.HeaderText = "Kullanıcı";
            kullanici.Name = "kullanici";
            kullanici.ReadOnly = true;
            // 
            // statu
            // 
            statu.DataPropertyName = "statu";
            statu.HeaderText = "Satatü";
            statu.Name = "statu";
            statu.ReadOnly = true;
            statu.Width = 75;
            // 
            // passwd
            // 
            passwd.DataPropertyName = "password";
            passwd.HeaderText = "Şifre";
            passwd.Name = "passwd";
            passwd.ReadOnly = true;
            passwd.Width = 50;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(userSaveBtn);
            groupBox1.Controls.Add(userAddName);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(userPassword);
            groupBox1.Controls.Add(userRePassword);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(42, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(270, 190);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Yeni Kullanıcı Bilgileri";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(194, 54);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(70, 19);
            radioButton2.TabIndex = 17;
            radioButton2.TabStop = true;
            radioButton2.Text = "Kullanıcı";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(104, 54);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(61, 19);
            radioButton1.TabIndex = 16;
            radioButton1.TabStop = true;
            radioButton1.Text = "Admin";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // userAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 417);
            Controls.Add(groupBox1);
            Controls.Add(saveUser);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "userAddForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanıcı Ekle";
            FormClosed += userAddForm_FormClosed;
            Load += userAddForm_Load;
            ((System.ComponentModel.ISupportInitialize)saveUser).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox userAddName;
        private Button userSaveBtn;
        private TextBox userPassword;
        private Label label2;
        private TextBox userRePassword;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn kullanici;
        private DataGridViewTextBoxColumn statu;
        private DataGridViewTextBoxColumn passwd;
        private GroupBox groupBox1;
        private DataGridView saveUser;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}