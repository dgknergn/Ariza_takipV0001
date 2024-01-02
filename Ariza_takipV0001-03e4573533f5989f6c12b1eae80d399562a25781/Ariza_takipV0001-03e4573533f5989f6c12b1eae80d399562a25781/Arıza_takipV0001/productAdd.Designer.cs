namespace Arıza_takipV0001
{
    partial class productAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(productAdd));
            save = new Button();
            aciklamaText = new TextBox();
            label6 = new Label();
            tutarText = new TextBox();
            cihazNoText = new TextBox();
            telNoText = new TextBox();
            userNameText = new TextBox();
            yesRd = new RadioButton();
            noRd = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // save
            // 
            save.Location = new Point(293, 282);
            save.Name = "save";
            save.Size = new Size(108, 28);
            save.TabIndex = 7;
            save.Text = "Kaydet";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // aciklamaText
            // 
            aciklamaText.Location = new Point(4, 178);
            aciklamaText.Multiline = true;
            aciklamaText.Name = "aciklamaText";
            aciklamaText.Size = new Size(397, 94);
            aciklamaText.TabIndex = 6;
            aciklamaText.KeyPress += aciklama_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Location = new Point(279, 117);
            label6.Name = "label6";
            label6.Size = new Size(13, 15);
            label6.TabIndex = 12;
            label6.Text = "₺";
            // 
            // tutarText
            // 
            tutarText.Location = new Point(154, 113);
            tutarText.Name = "tutarText";
            tutarText.Size = new Size(144, 23);
            tutarText.TabIndex = 3;
            tutarText.KeyPress += tutar_KeyPress;
            // 
            // cihazNoText
            // 
            cihazNoText.Location = new Point(4, 113);
            cihazNoText.Name = "cihazNoText";
            cihazNoText.Size = new Size(144, 23);
            cihazNoText.TabIndex = 2;
            // 
            // telNoText
            // 
            telNoText.Location = new Point(154, 60);
            telNoText.Name = "telNoText";
            telNoText.Size = new Size(144, 23);
            telNoText.TabIndex = 1;
            telNoText.KeyPress += telNo_KeyPress;
            // 
            // userNameText
            // 
            userNameText.Location = new Point(4, 60);
            userNameText.Name = "userNameText";
            userNameText.Size = new Size(144, 23);
            userNameText.TabIndex = 0;
            // 
            // yesRd
            // 
            yesRd.AutoSize = true;
            yesRd.Location = new Point(328, 72);
            yesRd.Name = "yesRd";
            yesRd.Size = new Size(56, 19);
            yesRd.TabIndex = 4;
            yesRd.TabStop = true;
            yesRd.Text = "Alındı";
            yesRd.UseVisualStyleBackColor = true;
            // 
            // noRd
            // 
            noRd.AutoSize = true;
            noRd.Location = new Point(328, 97);
            noRd.Name = "noRd";
            noRd.Size = new Size(73, 19);
            noRd.TabIndex = 5;
            noRd.TabStop = true;
            noRd.Text = "Alınmadı";
            noRd.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 42);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 18;
            label1.Text = "Müşteri Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(154, 42);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 19;
            label2.Text = "Telefon";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 95);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 20;
            label3.Text = "Cihaz Modeli";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(154, 95);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 21;
            label4.Text = "Tutar";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(328, 42);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 22;
            label5.Text = "Ödeme";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(4, 160);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 23;
            label7.Text = "Açıkalma";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(aciklamaText);
            groupBox1.Controls.Add(noRd);
            groupBox1.Controls.Add(yesRd);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(telNoText);
            groupBox1.Controls.Add(tutarText);
            groupBox1.Controls.Add(cihazNoText);
            groupBox1.Controls.Add(userNameText);
            groupBox1.Controls.Add(save);
            groupBox1.Location = new Point(5, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(407, 326);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Müşteri Kaydı";
            // 
            // productAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 332);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "productAdd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kayıt";
            FormClosed += productAdd_FormClosed;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBox6;
        private RadioButton yesRd;
        private Panel panel2;
        private TextBox aciklamaText;
        private RadioButton noRd;
        private Label label6;
        private TextBox userNameText;
        private TextBox tutarText;
        private TextBox cihazNoText;
        private TextBox textBox2;
        private Button save;
        private TextBox telNoText;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private GroupBox groupBox1;
    }
}