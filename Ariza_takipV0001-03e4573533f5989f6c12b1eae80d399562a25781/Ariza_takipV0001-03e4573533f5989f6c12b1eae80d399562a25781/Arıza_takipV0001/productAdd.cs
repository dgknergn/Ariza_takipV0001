using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Arıza_takipV0001
{
    public partial class productAdd : Form
    {
        vtProcess _vtprocess = new vtProcess();
        string _user, _statu, _password, _id, odeme;

        string firma = singInForm.setCompanyName;

        

        public productAdd(string user, string statu, string password, string id)
        {
            InitializeComponent();
            telNoText.MaxLength = 11;
            aciklamaText.MaxLength = 100;
            _user = user;
            _statu = statu;
            _password = password;
            _id = id;
        }

        private void productAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            menuForm menuform = new menuForm(_user, _statu, _password, _id);

            this.Hide();
            menuform.Show();
        }

        private void telNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.';
        }

        private void aciklama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (aciklamaText.Text.Length == 100)
            {
                MessageBox.Show("Maximum Karakter Sayısına Ulaştınız.");
            }
        }
        private void save_Click(object sender, EventArgs e)
        {
            var _companyId = _vtprocess.GetCompanyList();
            var _customerId = _vtprocess.GetCustomerList();
            vtProcess vtprocess = new vtProcess();

            if (yesRd.Checked == true) { odeme = "alındı"; }
            else if (noRd.Checked == true) { odeme = "alınmadı"; }

            vtprocess.SetProductAdd(userNameText.Text, telNoText.Text, cihazNoText.Text, aciklamaText.Text, Convert.ToDouble(tutarText.Text), odeme,firma);
            var nesneler = groupBox1.Controls.OfType<System.Windows.Forms.TextBox>();
            foreach (var nesne in nesneler)
            {
                nesne.Clear();
            }
        }
    }
}
