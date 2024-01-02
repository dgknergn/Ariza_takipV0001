namespace Arıza_takipV0001
{
    public partial class userAddForm : Form
    {
        vtProcess _vtIslemleri;
        string _id, _user, _statu, _sifre;



        public userAddForm(string id, string user, string statu, string sifre)
        {
            InitializeComponent();
            _vtIslemleri = new vtProcess();

            _id = id;
            _user = user;
            _statu = statu;
            _sifre = sifre;
        }

        private void userSaveBtn_Click(object sender, EventArgs e)
        {
            string kullanici, statu = null, password;

            kullanici = userAddName.Text;
            password = userPassword.Text;

            if (radioButton1.Checked == true) { statu = "admin"; }
            else if (radioButton2.Checked == true) { statu = "kullanıcı"; }

            var result = _vtIslemleri.IsUserExistByName(kullanici);

            if (result == false) { _vtIslemleri.SetUserAdd(kullanici, statu, password); }
            else MessageBox.Show("Bu kullanıcı kayıdı mevcut");

            this.saveUser.DataSource = _vtIslemleri.GetUserList();

            var nesneler = groupBox1.Controls.OfType<TextBox>();
            foreach (var nesne in nesneler)
            {
                nesne.Clear();
            }
        }

        private void userAddForm_Load(object sender, EventArgs e)
        {
            this.saveUser.DataSource = _vtIslemleri.GetUserList();
        }

        private void userAddForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            adminSettingsForm admin = new adminSettingsForm(_user, _statu, _sifre, _id);
            this.Hide();
            admin.Show();
        }
    }
}
