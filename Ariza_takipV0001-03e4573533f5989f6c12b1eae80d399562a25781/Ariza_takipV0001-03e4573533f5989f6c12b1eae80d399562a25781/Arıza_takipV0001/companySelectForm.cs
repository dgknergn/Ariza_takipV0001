using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arıza_takipV0001
{
    public partial class companySelectForm : Form
    {
        string companyName;
        singInForm singinform;
        vtProcess _vtprocess = new vtProcess();
        public companySelectForm()
        {
            InitializeComponent();
        }

        private void companySelectForm_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = _vtprocess.GetCompanyList();
        }

        private void companySelectForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                singinform = new singInForm();
                this.Hide();
                singinform.Show();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            companyName = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            singInForm singinform = new singInForm(companyName);
            this.Hide();
            singinform.Show();
        }
    }
}
