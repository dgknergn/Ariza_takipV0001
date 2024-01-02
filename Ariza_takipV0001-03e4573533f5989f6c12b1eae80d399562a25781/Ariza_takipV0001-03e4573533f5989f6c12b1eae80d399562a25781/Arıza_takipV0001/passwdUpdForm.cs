using Microsoft.VisualBasic;
using WinFormsApp2;

namespace Arıza_takipV0001
{
    public partial class passwdUpdForm : Form
    {
        public string _user, _statu, _sifre, _id, deger;
        int index = 0, lookPicture2, lookPicture3;
        public passwdUpdForm()
        {
            InitializeComponent();
        }
        public passwdUpdForm(string user, string statu, string id, string sifre)
        {
            InitializeComponent();
            _id = id;
            _user = user;
            _statu = statu;
            _sifre = sifre;

            userLbl.Text = _user;
            statuLbl.Text = _statu;
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            vtProcess _vtProcess = new vtProcess();

            if (oldPassword.Text != newPassword.Text)
            {
                if (oldPassword.Text == _sifre)
                {
                    if (newPassword.Text == rePassword.Text)
                    {
                        _vtProcess.SetRePassword(newPassword.Text, Convert.ToInt16(_id));
                        Application.Restart();
                    }
                    else MessageBox.Show("Girilen Şifreler Uyuşmuyor !");
                }
                else MessageBox.Show("Mevcut Şifre Hatalı !");
            }
            else
            {
                DialogResult error = MessageBox.Show("Eski Şifre ve Yeni Şifre aynı olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void passwdUpdForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_statu == "admin")
            {
                adminSettingsForm admin = new adminSettingsForm(_user, _statu, _sifre, _id);
                this.Hide();
                admin.Show();
            }
            else if (_statu == "kullanıcı")
            {
                userSettingsForm user = new userSettingsForm(_user, _statu, _sifre, _id);
                this.Hide();
                user.Show();
            }

        }
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            lookPicture2 = index % 2;
            showPassword(lookPicture2, lookPicture3);
            index++;
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            lookPicture3 = index % 2;
            showPassword(lookPicture2, lookPicture3);
            index++;
        }
        private void oldPassword_TextChanged(object sender, EventArgs e)
        {
            check(oldPassword.Text, newPassword.Text, rePassword.Text, _sifre);
            showPasswordIcon(oldPassword.TextLength, newPassword.TextLength, rePassword.TextLength);
        }
        private void newPassword_TextChanged(object sender, EventArgs e)
        {
            showPasswordIcon(oldPassword.TextLength, newPassword.TextLength, rePassword.TextLength);
            check(oldPassword.Text, newPassword.Text, rePassword.Text, _sifre);
        }
        private void rePassword_TextChanged(object sender, EventArgs e)
        {
            check(oldPassword.Text, newPassword.Text, rePassword.Text, _sifre);
        }
        private void showPasswordIcon(int oldPsw, int newPsw, int rePsw)
        {
            switch (oldPsw)
            {
                case 1:
                    {
                        pictureBox2.Visible = true;
                    }
                    break;

                default:
                    {
                        pictureBox2.Visible = false;
                        oldPassword.PasswordChar = '●';
                        pictureBox2.Image = Arıza_takipV0001.Properties.Resources.close;
                    }
                    break;
            }
            switch (newPsw)
            {
                case 1:
                    {
                        pictureBox3.Visible = true;
                    }
                    break;

                default:
                    {
                        pictureBox3.Visible = false;
                        newPassword.PasswordChar = '●';
                        rePassword.PasswordChar = '●';
                        pictureBox3.Image = Arıza_takipV0001.Properties.Resources.close;
                    }
                    break;
            }
        }
        private void showPassword(int look1, int look2)
        {
            switch (look1)
            {
                case 0:
                    {
                        oldPassword.PasswordChar = '\0';
                        pictureBox2.Image = Arıza_takipV0001.Properties.Resources.open;
                    }
                    break;

                case 1:
                    {
                        oldPassword.PasswordChar = '●';
                        pictureBox2.Image = Arıza_takipV0001.Properties.Resources.close;
                    }
                    break;
                default:
                    break;
            }
            switch (look2)
            {
                case 0:
                    {
                        newPassword.PasswordChar = '●';
                        rePassword.PasswordChar = '●';
                        pictureBox3.Image = Arıza_takipV0001.Properties.Resources.close;
                    }
                    break;

                case 1:
                    {
                        newPassword.PasswordChar = '\0';
                        rePassword.PasswordChar = '\0';
                        pictureBox3.Image = Arıza_takipV0001.Properties.Resources.open;
                    }
                    break;
                default:
                    break;
            }
        }
        private void check(string oldPsw, string newPsw, string rePsw, string passwd)
        {
            if (oldPsw != passwd)
            {
                oldPassword.BackColor = Color.Tomato;
            }
            else if (oldPsw == passwd)
            {
                oldPassword.BackColor = Color.White;
            }


            if (newPsw != rePsw)
            {
                newPassword.BackColor = Color.Tomato;
                rePassword.BackColor = Color.Tomato;

            }
            else if (newPsw == rePsw)
            {
                newPassword.BackColor = Color.White;
                rePassword.BackColor = Color.White;
            }
        }
    }
}

