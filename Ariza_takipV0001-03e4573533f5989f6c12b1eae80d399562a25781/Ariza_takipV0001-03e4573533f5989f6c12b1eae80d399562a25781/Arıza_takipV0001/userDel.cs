namespace Arıza_takipV0001
{
    public partial class userDel : Form
    {
        String _user, _statu, _sifre, _id;
        vtProcess _vtprocess;
        public userDel(string user, string statu, string password, string id)
        {
            InitializeComponent();
            _vtprocess = new vtProcess();

            _id = id;
            _user = user;
            _statu = statu;
            _sifre = password;
        }

        private void userDel_FormClosed(object sender, FormClosedEventArgs e)
        {
            adminSettingsForm adminsettingsform = new adminSettingsForm(_user, _statu, _sifre, _id);
            adminsettingsform.Show();
        }

        private void userDel_Load(object sender, EventArgs e)
        {
            this.userGet.DataSource = _vtprocess.GetUserList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullanici = userGet.CurrentRow.Cells[1].Value.ToString();
            _vtprocess.UserDel(kullanici);

            this.userGet.DataSource = _vtprocess.GetUserList();

        }
    }
}
