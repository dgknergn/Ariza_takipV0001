using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arıza_takipV0001
{
    public partial class changeCompany : Form
    {
        vtProcess _vtProcess = new vtProcess();
        string _user, _statu, _id, _sifre;
        public changeCompany(string user, string statu, string id, string sifre)
        {
            InitializeComponent();
            _user = user;
            _statu = statu;
            _id = id;
            _sifre = sifre;
        }

        private void changeCompany_FormClosed(object sender, FormClosedEventArgs e)
        {
            adminSettingsForm admin = new adminSettingsForm(_user, _statu, _id, _sifre);
            admin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _vtProcess.SetCompanyName(textBox1.Text);
            dataGridView1.DataSource = _vtProcess.GetCompanyList();
        }

        private void changeCompany_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _vtProcess.GetCompanyList();
        }
    }
}
