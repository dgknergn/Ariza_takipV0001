namespace Arıza_takipV0001
{
    public partial class selectUserForm : Form
    {

        private string alinanKullanici = "", alinanSifre = "", secilenStatu = "", secilenId = "";

        vtProcess _vtIslemleri;

        public selectUserForm()
        {
            InitializeComponent();
            _vtIslemleri = new vtProcess();
        }

        public void kullanıcısec_Load(object sender, EventArgs e)
        {
            this.userList.DataSource = _vtIslemleri.GetUserList();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenId = userList.CurrentRow.Cells[0].Value.ToString();
            alinanKullanici = userList.CurrentRow.Cells[1].Value.ToString();
            secilenStatu = userList.CurrentRow.Cells[2].Value.ToString();
            alinanSifre = userList.CurrentRow.Cells[3].Value.ToString();
            singInForm girisForm = new singInForm(secilenId, alinanKullanici, alinanSifre, secilenStatu);

            this.Hide();
            girisForm.Show();
        }

        private void selectUserForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                singInForm singinform = new singInForm();
                this.Hide();
                singinform.Show();
            }

            if (e.KeyCode == Keys.Enter)
            {
                secilenId = userList.CurrentRow.Cells[0].Value.ToString();
                alinanKullanici = userList.CurrentRow.Cells[1].Value.ToString();
                secilenStatu = userList.CurrentRow.Cells[2].Value.ToString();
                alinanSifre = userList.CurrentRow.Cells[3].Value.ToString();
                singInForm girisForm = new singInForm(secilenId, alinanKullanici, alinanSifre, secilenStatu);

                this.Hide();
                girisForm.Show();
            }

        }
    }
}
