namespace arızatakip
{
    partial class searchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(searchForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            arizaNo = new TextBox();
            musteriTel = new TextBox();
            unvan = new TextBox();
            dataList = new DataGridView();
            searchBtn = new Button();
            cihazModeli = new TextBox();
            label4 = new Label();
            durum = new DataGridViewImageColumn();
            Column2 = new DataGridViewTextBoxColumn();
            musteriunvan = new DataGridViewTextBoxColumn();
            musterino = new DataGridViewTextBoxColumn();
            cihazmodel = new DataGridViewTextBoxColumn();
            aciklama = new DataGridViewTextBoxColumn();
            tutar = new DataGridViewTextBoxColumn();
            odeme = new DataGridViewTextBoxColumn();
            company = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 19);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 0;
            label1.Text = "Arıza No";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(170, 19);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Ad Soyad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(333, 19);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 2;
            label3.Text = "Müşteri Tel";
            // 
            // arizaNo
            // 
            arizaNo.Location = new Point(13, 41);
            arizaNo.Margin = new Padding(2);
            arizaNo.Name = "arizaNo";
            arizaNo.Size = new Size(156, 23);
            arizaNo.TabIndex = 1;
            arizaNo.KeyPress += arizaNo_KeyPress;
            // 
            // musteriTel
            // 
            musteriTel.Location = new Point(333, 41);
            musteriTel.Margin = new Padding(2);
            musteriTel.Name = "musteriTel";
            musteriTel.Size = new Size(156, 23);
            musteriTel.TabIndex = 3;
            musteriTel.KeyPress += musteriTel_KeyPress;
            // 
            // unvan
            // 
            unvan.Location = new Point(173, 41);
            unvan.Margin = new Padding(2);
            unvan.Name = "unvan";
            unvan.Size = new Size(156, 23);
            unvan.TabIndex = 2;
            // 
            // dataList
            // 
            dataList.AllowUserToAddRows = false;
            dataList.AllowUserToDeleteRows = false;
            dataList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataList.Columns.AddRange(new DataGridViewColumn[] { durum, Column2, musteriunvan, musterino, cihazmodel, aciklama, tutar, odeme, company });
            dataList.Location = new Point(13, 82);
            dataList.Margin = new Padding(2);
            dataList.Name = "dataList";
            dataList.ReadOnly = true;
            dataList.RowHeadersWidth = 51;
            dataList.RowTemplate.Height = 24;
            dataList.Size = new Size(928, 388);
            dataList.TabIndex = 6;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(653, 40);
            searchBtn.Margin = new Padding(2);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(84, 25);
            searchBtn.TabIndex = 5;
            searchBtn.Text = "Sorgula";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += button1_Click;
            // 
            // cihazModeli
            // 
            cihazModeli.Location = new Point(493, 41);
            cihazModeli.Margin = new Padding(2);
            cihazModeli.Name = "cihazModeli";
            cihazModeli.Size = new Size(156, 23);
            cihazModeli.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(493, 19);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 8;
            label4.Text = "Cihaz Modeli";
            // 
            // durum
            // 
            durum.HeaderText = "Durum";
            durum.Name = "durum";
            durum.ReadOnly = true;
            durum.Resizable = DataGridViewTriState.True;
            durum.SortMode = DataGridViewColumnSortMode.Automatic;
            durum.Width = 50;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "id";
            Column2.HeaderText = "Arıza No";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 75;
            // 
            // musteriunvan
            // 
            musteriunvan.DataPropertyName = "customerName";
            musteriunvan.HeaderText = "Müşteri Ünvanı";
            musteriunvan.MinimumWidth = 6;
            musteriunvan.Name = "musteriunvan";
            musteriunvan.ReadOnly = true;
            musteriunvan.Width = 125;
            // 
            // musterino
            // 
            musterino.DataPropertyName = "customerNo";
            musterino.HeaderText = "Müşteri No";
            musterino.MinimumWidth = 6;
            musterino.Name = "musterino";
            musterino.ReadOnly = true;
            musterino.Width = 125;
            // 
            // cihazmodel
            // 
            cihazmodel.DataPropertyName = "productModel";
            cihazmodel.HeaderText = "Cihaz Modeli";
            cihazmodel.MinimumWidth = 6;
            cihazmodel.Name = "cihazmodel";
            cihazmodel.ReadOnly = true;
            cihazmodel.Width = 125;
            // 
            // aciklama
            // 
            aciklama.DataPropertyName = "explanation";
            aciklama.HeaderText = "Açıklama";
            aciklama.MinimumWidth = 6;
            aciklama.Name = "aciklama";
            aciklama.ReadOnly = true;
            aciklama.Width = 150;
            // 
            // tutar
            // 
            tutar.DataPropertyName = "total";
            tutar.HeaderText = "Tutar";
            tutar.MinimumWidth = 6;
            tutar.Name = "tutar";
            tutar.ReadOnly = true;
            // 
            // odeme
            // 
            odeme.DataPropertyName = "pay";
            odeme.HeaderText = "Ödeme";
            odeme.MinimumWidth = 6;
            odeme.Name = "odeme";
            odeme.ReadOnly = true;
            odeme.Width = 125;
            // 
            // company
            // 
            company.DataPropertyName = "company";
            company.HeaderText = "firma";
            company.Name = "company";
            company.ReadOnly = true;
            company.Visible = false;
            // 
            // searchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 481);
            Controls.Add(cihazModeli);
            Controls.Add(label4);
            Controls.Add(searchBtn);
            Controls.Add(dataList);
            Controls.Add(unvan);
            Controls.Add(musteriTel);
            Controls.Add(arizaNo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "searchForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ürün Sorgula";
            Load += searchForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox arizaNo;
        private System.Windows.Forms.TextBox musteriTel;
        private System.Windows.Forms.TextBox unvan;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arızano;
        private DataGridView dataList;
        private TextBox cihazModeli;
        private Label label4;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn musteriunvan;
        private DataGridViewTextBoxColumn musterino;
        private DataGridViewTextBoxColumn cihazmodel;
        private DataGridViewTextBoxColumn aciklama;
        private DataGridViewTextBoxColumn tutar;
        private DataGridViewTextBoxColumn odeme;
        private DataGridViewImageColumn durum;
        private DataGridViewTextBoxColumn company;
    }
}