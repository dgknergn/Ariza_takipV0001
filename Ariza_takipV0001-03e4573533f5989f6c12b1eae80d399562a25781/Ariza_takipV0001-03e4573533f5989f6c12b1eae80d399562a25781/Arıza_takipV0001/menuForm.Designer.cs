namespace Arıza_takipV0001
{
    partial class menuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuForm));
            productSearch = new Button();
            productAdd = new Button();
            productOutput = new Button();
            userSettings = new PictureBox();
            userNameLbl = new Label();
            menuStrip1 = new MenuStrip();
            kullanıcıToolStripMenuItem = new ToolStripMenuItem();
            kullanıcıDeğiştirToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            ayarlarToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)userSettings).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // productSearch
            // 
            productSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            productSearch.Location = new Point(24, 164);
            productSearch.Name = "productSearch";
            productSearch.Size = new Size(90, 90);
            productSearch.TabIndex = 0;
            productSearch.Text = "Ürün\r\nSorgula\r\n";
            productSearch.UseVisualStyleBackColor = true;
            productSearch.Click += productSearch_Click;
            // 
            // productAdd
            // 
            productAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            productAdd.Location = new Point(184, 164);
            productAdd.Name = "productAdd";
            productAdd.Size = new Size(90, 90);
            productAdd.TabIndex = 1;
            productAdd.Text = "Ürün\r\n Girişi";
            productAdd.UseVisualStyleBackColor = true;
            productAdd.Click += productAdd_Click;
            // 
            // productOutput
            // 
            productOutput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            productOutput.Location = new Point(343, 164);
            productOutput.Name = "productOutput";
            productOutput.Size = new Size(90, 90);
            productOutput.TabIndex = 2;
            productOutput.Text = "Ürün\r\nÇıkışı";
            productOutput.UseVisualStyleBackColor = true;
            productOutput.Click += productOutput_Click;
            // 
            // userSettings
            // 
            userSettings.BackColor = Color.Transparent;
            userSettings.Image = Properties.Resources.ASD;
            userSettings.Location = new Point(433, 2);
            userSettings.Name = "userSettings";
            userSettings.Size = new Size(30, 23);
            userSettings.SizeMode = PictureBoxSizeMode.CenterImage;
            userSettings.TabIndex = 3;
            userSettings.TabStop = false;
            // 
            // userNameLbl
            // 
            userNameLbl.BackColor = SystemColors.Control;
            userNameLbl.Location = new Point(306, 7);
            userNameLbl.Name = "userNameLbl";
            userNameLbl.Size = new Size(127, 15);
            userNameLbl.TabIndex = 4;
            userNameLbl.Text = "label1";
            userNameLbl.TextAlign = ContentAlignment.MiddleRight;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Control;
            menuStrip1.Items.AddRange(new ToolStripItem[] { kullanıcıToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(465, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // kullanıcıToolStripMenuItem
            // 
            kullanıcıToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kullanıcıDeğiştirToolStripMenuItem, toolStripSeparator1, ayarlarToolStripMenuItem });
            kullanıcıToolStripMenuItem.Name = "kullanıcıToolStripMenuItem";
            kullanıcıToolStripMenuItem.Size = new Size(51, 20);
            kullanıcıToolStripMenuItem.Text = "Dosya";
            // 
            // kullanıcıDeğiştirToolStripMenuItem
            // 
            kullanıcıDeğiştirToolStripMenuItem.Name = "kullanıcıDeğiştirToolStripMenuItem";
            kullanıcıDeğiştirToolStripMenuItem.Size = new Size(162, 22);
            kullanıcıDeğiştirToolStripMenuItem.Text = "Kullanıcı Değiştir";
            kullanıcıDeğiştirToolStripMenuItem.Click += kullanıcıDeğiştirToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(159, 6);
            // 
            // ayarlarToolStripMenuItem
            // 
            ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            ayarlarToolStripMenuItem.Size = new Size(162, 22);
            ayarlarToolStripMenuItem.Text = "Ayarlar";
            ayarlarToolStripMenuItem.Click += ayarlarToolStripMenuItem_Click;
            // 
            // menuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 416);
            Controls.Add(userSettings);
            Controls.Add(userNameLbl);
            Controls.Add(productOutput);
            Controls.Add(productAdd);
            Controls.Add(productSearch);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "menuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menü";
            FormClosed += menuForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)userSettings).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button productSearch;
        private Button productAdd;
        private Button productOutput;
        private PictureBox userSettings;
        private Label userNameLbl;
        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem kullanıcıToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem ayarlarToolStripMenuItem;
        private ToolStripMenuItem kullanıcıDeğiştirToolStripMenuItem;
    }
}