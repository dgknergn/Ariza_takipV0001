namespace Arıza_takipV0001
{
    partial class userDel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userDel));
            userGet = new DataGridView();
            button1 = new Button();
            id = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            kullanici = new DataGridViewTextBoxColumn();
            statu = new DataGridViewTextBoxColumn();
            sifre = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)userGet).BeginInit();
            SuspendLayout();
            // 
            // userGet
            // 
            userGet.AllowUserToAddRows = false;
            userGet.AllowUserToDeleteRows = false;
            userGet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userGet.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, kullanici, statu, sifre });
            userGet.Location = new Point(3, 0);
            userGet.Name = "userGet";
            userGet.ReadOnly = true;
            userGet.RowTemplate.Height = 25;
            userGet.Size = new Size(271, 150);
            userGet.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(184, 156);
            button1.Name = "button1";
            button1.Size = new Size(91, 29);
            button1.TabIndex = 1;
            button1.Text = "Sil";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.Name = "id";
            id.Width = 25;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "id";
            dataGridViewTextBoxColumn1.HeaderText = "id";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 25;
            // 
            // kullanici
            // 
            kullanici.DataPropertyName = "kullanici";
            kullanici.HeaderText = "Kullanıcı Adı";
            kullanici.Name = "kullanici";
            kullanici.ReadOnly = true;
            // 
            // statu
            // 
            statu.DataPropertyName = "statu";
            statu.HeaderText = "Statü";
            statu.Name = "statu";
            statu.ReadOnly = true;
            // 
            // sifre
            // 
            sifre.DataPropertyName = "password";
            sifre.HeaderText = "Şifre";
            sifre.Name = "sifre";
            sifre.ReadOnly = true;
            sifre.Visible = false;
            // 
            // userDel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(278, 197);
            Controls.Add(button1);
            Controls.Add(userGet);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "userDel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanı Sil";
            FormClosed += userDel_FormClosed;
            Load += userDel_Load;
            ((System.ComponentModel.ISupportInitialize)userGet).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private DataGridView userGet;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn kullanici;
        private DataGridViewTextBoxColumn statu;
        private DataGridViewTextBoxColumn sifre;
    }
}