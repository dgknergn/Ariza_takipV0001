using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using System.Text;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Arıza_takipV0001
{
    public partial class singInForm : Form
    {
        vtProcess _vtprocess = new vtProcess();

        int singİnIndex = 3, second = 10, index = 0;
        string _kullaniciAdi = string.Empty, _sifre = string.Empty, _statu = string.Empty, _id = string.Empty, _companyName = string.Empty;

        string _CompanyName;
        public static string setCompanyName;

        public singInForm(string companyName)
        {
            _companyName = companyName;
            setCompanyName = _companyName;
            InitializeComponent();
        }
        public singInForm()
        {
            InitializeComponent();
        }
        public singInForm(string id, string kullaniciAdi, string sifre, string statu)
        {
            InitializeComponent();
            _id = id;
            _kullaniciAdi = kullaniciAdi;
            _sifre = sifre;
            _statu = statu;
            userTextBox.Text = _kullaniciAdi;
        }
        private void Form1_Load(object sender, EventArgs e)// saat ve firma bilgisinin ekrana yazılmasını sağlar 
        {
            dataTime.Text = DateTime.Now.ToShortDateString();

            company.Text = _companyName;
        }
        private void singIn_Click(object sender, EventArgs e)
        {
            if (!ValidateUsernameAndPassword()) return;

            if (!string.IsNullOrEmpty(_kullaniciAdi))
            {
                if (userTextBox.Text == _kullaniciAdi && passwdTextBox.Text == _sifre)
                {
                    menuForm menu = new menuForm(_kullaniciAdi, _statu, _sifre, _id);
                    menu.Show();
                    this.Hide();
                }
                else _errorMessage();
            }

            else
            {
                var kullanici = _vtprocess.GetUserByName(userTextBox.Text.ToLower());
                if (kullanici != null && kullanici.Rows.Count > 0)
                {
                    var sifreFromDb = kullanici.Rows[0].Field<string>("password");
                    if (passwdTextBox.Text == sifreFromDb)
                    {
                        _kullaniciAdi = kullanici.Rows[0].Field<string>("kullanici");
                        _statu = kullanici.Rows[0].Field<string>("statu");
                        _sifre = kullanici.Rows[0].Field<string>("password");
                        _id = kullanici.Rows[0].Field<int>("id").ToString();

                        menuForm menu = new menuForm(_kullaniciAdi, _statu, _sifre, _id);
                        menu.Show();
                        this.Hide();
                    }
                    else _errorMessage();
                }
                else
                {
                    MessageBox.Show("Kullanıcı bulunamadı.");
                }
            }

            if (singİnIndex == 0)
            {
                singInBtn.Enabled = false;
                timer1.Start();
            }
            singİnIndex--;
        } // giriş butonuna basıldığında yapılacak işlemler
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;

            second = second - 1;
            singInBtn.Text = Convert.ToString(second);

            if (second == 0)
            {
                timer1.Stop();

                int singİnIndex = 3;
                int second = 10;

                singInBtn.Enabled = true;
                singInBtn.Text = "Giriş";
                errorMessage.Text = " ";
            }
        } // şifre yanlış girildiği zaman butonda sayılan geri sayım
        private void userSelect_Click(object sender, EventArgs e)
        {
            selectUserForm selectUserForm = new selectUserForm();
            selectUserForm.Show();
            this.Hide();
        } // görsele basıldığı zaman ekranda kullanıcı seçim ekranı açar
        private void _errorMessage()
        {
            errorMessage.Text = singİnIndex + "*Kullanıcı veya Şifre Hatalı";
        } // şifre veya kullanıcı adı hatalı olur ise dönecek hata mesajı
        private bool ValidateUsernameAndPassword()
        {
            var errorMessage = new StringBuilder();
            var isValid = true;

            if (string.IsNullOrEmpty(company.Text))
            {
                errorMessage.AppendLine("- Firma Seçiniz.");
                isValid = false;
            }
            if (string.IsNullOrEmpty(userTextBox.Text))
            {
                errorMessage.AppendLine("- Kullanıcı adı giriniz.");
                isValid = false;
            }
            if (string.IsNullOrEmpty(passwdTextBox.Text))
            {
                errorMessage.AppendLine("- Şifre giriniz.");
                isValid = false;
            }
            if (!isValid)
            {
                MessageBox.Show(errorMessage.ToString());
            }

            return isValid;
        }  // kullanıcı adı ve şifre alanlarının boş olup olmadığını kontrol ediyor.
        private void singInForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                singIn_Click(this, new EventArgs());
            }
        } // giriş ekranında enter a basılınca giriş yapılmasını sağlar
        private void singInForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        } // form kapatılınca uygulamanın durdurulmasını sağlar 
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (index % 2 == 0)
            {
                passwdTextBox.PasswordChar = '\0';
                pictureBox2.Image = Arıza_takipV0001.Properties.Resources.open;
            }
            else if (index % 2 == 1)
            {
                passwdTextBox.PasswordChar = '●';
                pictureBox2.Image = Arıza_takipV0001.Properties.Resources.close;
            }
            index++;
        } // girilen şifrenin görünüp gizlenmesini sağlar
        private void passwdTextBox_TextChanged(object sender, EventArgs e)
        {
            if (passwdTextBox.TextLength == 1)
            {
                pictureBox2.Visible = true;
            }
            else if (passwdTextBox.TextLength == 0)
            {
                pictureBox2.Visible = false;
                passwdTextBox.PasswordChar = '●';
                pictureBox2.Image = Arıza_takipV0001.Properties.Resources.close;
            }
        } // şifre textbox boş olduğunda şifre aç kapa butonunu saklarmak için kod
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            companySelectForm companySelect = new companySelectForm();
            this.Hide();
            companySelect.Show();

        }
    }
}
