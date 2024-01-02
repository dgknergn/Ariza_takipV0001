namespace Arıza_takipV0001
{
    public partial class adminSettingsForm : Form
    {
        String _user, _statu, _sifre, _id;
        public adminSettingsForm()
        {
            InitializeComponent();
        }
        public adminSettingsForm(string user, string statu, string password, string id)
        {
            InitializeComponent();
            _user = user;
            _statu = statu;
            _id = id;
            _sifre = password;

            label1.Text = _user;
            label2.Text = _statu;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            passwdUpdForm passwdupdform = new passwdUpdForm(_user, _statu, _id, _sifre);
            this.Hide();
            passwdupdform.Show();
        } // parola güncelleme ekranını geçiş yapar
        private void button2_Click(object sender, EventArgs e)
        {
            userAddForm useradd = new userAddForm(_id, _user, _statu, _sifre);
            this.Hide();
            useradd.Show();
        } // kullanıcı ekleme ekranını geçiş yapar
        private void button1_Click_1(object sender, EventArgs e)
        {
            userDel userdel = new userDel(_user, _statu, _sifre, _id);
            this.Hide();
            userdel.Show();
        } // kullanıcı silme ekranını geçiş yapar
        private void adminSettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            menuForm menuform = new menuForm(_user, _statu, _id, _sifre);
            this.Hide();
            menuform.Show();
        } // admin ekranı kapatıldığı zaman menü formuna geçiş yapılması sağlar
        private void button2_Click_1(object sender, EventArgs e)
        {
            changeCompany changecompany = new changeCompany(_user, _statu, _id, _sifre);
            this.Hide();
            changecompany.Show();
        } // firma değiştirme ekranına geçiş yapar

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
