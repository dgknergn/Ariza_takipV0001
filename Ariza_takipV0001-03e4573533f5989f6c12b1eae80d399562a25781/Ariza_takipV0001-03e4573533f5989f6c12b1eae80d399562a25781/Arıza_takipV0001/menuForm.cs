using arızatakip;
using WinFormsApp2;

namespace Arıza_takipV0001
{
    public partial class menuForm : Form
    {
        string _user, _statu, _sifre, _id;
        public menuForm()
        {
            InitializeComponent();
        }
        public menuForm(string user, string statu, string password, string id)
        {
            InitializeComponent();
            _user = user;
            _statu = statu;
            _id = id;
            _sifre = password;
            userNameLbl.Text = _user.ToUpper();
        }

        private void productSearch_Click(object sender, EventArgs e)
        {
            searchForm search = new searchForm();
            search.Show();
        } // ürün sorgulama ekranına geçiş yapar

        private void productAdd_Click(object sender, EventArgs e)
        {
            productAdd urungirisi = new productAdd(_user, _statu, _sifre, _id);
            this.Hide();
            urungirisi.Show();
        } // ürün ekleme akranına geçiş yapar

        private void productOutput_Click(object sender, EventArgs e)
        {
            productExit produtexit = new productExit(_user, _statu, _sifre, _id);
            produtexit.Show();
            
        } // ürün çıkış ekranına geçiş yapar

        private void kullanıcıDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            singInForm singInForm = new singInForm();
            singInForm.Show();
            this.Hide();
        }  // açılır menü de yer alır giriş ekranına geçiş yapar

        private void ayarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_statu == "admin")
            {
                adminSettingsForm adminsettings = new adminSettingsForm(_user, _statu, _sifre, _id);
                this.Hide();
                adminsettings.Show();
            } // giriş yapılan kullanıcı statüsü admin ise açılacak ayar sayfası
            else if (_statu == "kullanıcı")
            {
                userSettingsForm usersettingsform = new userSettingsForm(_user, _statu, _sifre, _id);
                this.Hide();
                usersettingsform.Show();
            }// giriş yapılan kullanıcı statüsü kullanıcı ise açılacak ayar sayfası
        } // açılır menüde yer alır kullanıcı ayarlarına girer

        private void menuForm_FormClosed(object sender, FormClosedEventArgs e) 
        {
            Application.Exit();
        } // menü form kapatıldığı zaman uygulamayı sonlandırır
    }
}
