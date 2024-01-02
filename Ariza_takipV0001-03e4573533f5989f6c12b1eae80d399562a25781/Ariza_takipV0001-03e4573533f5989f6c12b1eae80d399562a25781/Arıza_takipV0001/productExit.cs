using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Arıza_takipV0001
{
    public partial class productExit : Form
    {
        string _user, _statu, _sifre, _id;
        vtProcess _vtprocess = new vtProcess();
        public productExit(string user, string statu, string password, string id)
        {
            InitializeComponent();
            _user = user;
            _statu = statu;
            _id = id;
            _sifre = password;
        }
        private void pay_Click(object sender, EventArgs e)
        {
            int dataId = Convert.ToInt32(dataList.CurrentRow.Cells[1].Value.ToString());
            _vtprocess.updatePay("Alındı", dataId);

            dataListIcon(_vtprocess.GetCustomerList());
        }

        private void productExit_Load(object sender, EventArgs e)
        {
            dataListIcon(_vtprocess.GetCustomerList());
        }
        void dataListIcon(DataTable data)
        {
            this.dataList.DataSource = data;
            int index = 0;

            foreach (DataGridViewRow row in dataList.Rows)
            {
                string odeme = row.Cells[7].Value.ToString();
                if (odeme == "alındı")
                {
                    dataList.Rows[index].Cells[0].Value = Arıza_takipV0001.Properties.Resources.green;
                }
                else if (odeme == "alınmadı")
                {
                    dataList.Rows[index].Cells[0].Value = Arıza_takipV0001.Properties.Resources.red;
                }
                index++;
            }
        }
    }
}
