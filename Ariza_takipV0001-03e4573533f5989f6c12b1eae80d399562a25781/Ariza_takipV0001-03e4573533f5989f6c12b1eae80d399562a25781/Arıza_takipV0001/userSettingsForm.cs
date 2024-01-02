using Arýza_takipV0001;

namespace WinFormsApp2
{
    public partial class userSettingsForm : Form
    {
        string _user, _statu, _id, _sifre;
        public userSettingsForm()
        {
            InitializeComponent();
        }

        public userSettingsForm(string user, string statu, string password, string id)
        {
            InitializeComponent();
            _user = user;
            _statu = statu;
            _id = id;
            _sifre = password;
            userLbl.Text = _user;
            statuLbl.Text = _statu;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            passwdUpdForm passwdupdate = new passwdUpdForm(_user, _statu, _id, _sifre);
            passwdupdate.Show();
            this.Hide();
        }

        private void userSettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            menuForm menu = new menuForm(_user, _statu, _sifre, _id);
            this.Hide();
            menu.Show();
        }
    }
}