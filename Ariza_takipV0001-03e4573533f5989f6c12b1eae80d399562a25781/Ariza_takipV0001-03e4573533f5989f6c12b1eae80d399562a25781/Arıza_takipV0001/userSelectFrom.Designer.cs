namespace Arıza_takipV0001
{
    partial class selectUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(selectUserForm));
            userList = new DataGridView();
            userIdDgv = new DataGridViewTextBoxColumn();
            userDgv = new DataGridViewTextBoxColumn();
            StatuDgv = new DataGridViewTextBoxColumn();
            passwdDgv = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)userList).BeginInit();
            SuspendLayout();
            // 
            // userList
            // 
            userList.AllowUserToAddRows = false;
            userList.AllowUserToDeleteRows = false;
            userList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userList.Columns.AddRange(new DataGridViewColumn[] { userIdDgv, userDgv, StatuDgv, passwdDgv });
            userList.Dock = DockStyle.Fill;
            userList.Location = new Point(0, 0);
            userList.Name = "userList";
            userList.ReadOnly = true;
            userList.RowTemplate.Height = 25;
            userList.Size = new Size(294, 198);
            userList.TabIndex = 0;
            userList.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // userIdDgv
            // 
            userIdDgv.DataPropertyName = "id";
            userIdDgv.HeaderText = "ID";
            userIdDgv.Name = "userIdDgv";
            userIdDgv.ReadOnly = true;
            userIdDgv.Width = 50;
            // 
            // userDgv
            // 
            userDgv.DataPropertyName = "kullanici";
            userDgv.HeaderText = "Kullanıcı Adı";
            userDgv.Name = "userDgv";
            userDgv.ReadOnly = true;
            userDgv.Width = 130;
            // 
            // StatuDgv
            // 
            StatuDgv.DataPropertyName = "statu";
            StatuDgv.HeaderText = "Statü";
            StatuDgv.Name = "StatuDgv";
            StatuDgv.ReadOnly = true;
            StatuDgv.Width = 70;
            // 
            // passwdDgv
            // 
            passwdDgv.DataPropertyName = "password";
            passwdDgv.HeaderText = "Şifre";
            passwdDgv.Name = "passwdDgv";
            passwdDgv.ReadOnly = true;
            passwdDgv.Visible = false;
            // 
            // selectUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 198);
            Controls.Add(userList);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "selectUserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanıcılar";
            Load += kullanıcısec_Load;
            KeyDown += selectUserForm_KeyDown;
            ((System.ComponentModel.ISupportInitialize)userList).EndInit();
            ResumeLayout(false);
        }

        #endregion
        public DataGridView userList;
        private DataGridViewTextBoxColumn user;
        private DataGridViewTextBoxColumn passwd;
        private DataGridViewTextBoxColumn userIdDgv;
        private DataGridViewTextBoxColumn userDgv;
        private DataGridViewTextBoxColumn StatuDgv;
        private DataGridViewTextBoxColumn passwdDgv;
    }
}