using Arıza_takipV0001;
using System.Data;
using System.IO;

namespace arızatakip
{
    public partial class searchForm : Form
    {
        vtProcess _vtIslemleri;
        string path = System.Windows.Forms.Application.StartupPath + "\\img\\";
        public searchForm()
        {
            InitializeComponent();
            _vtIslemleri = new vtProcess();
            musteriTel.MaxLength = 11;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataListIcon(_vtIslemleri.GetCustomerByName(arizaNo.Text, unvan.Text, musteriTel.Text, cihazModeli.Text));

            if (unvan.Text == "*")
            {
                dataListIcon(_vtIslemleri.GetCustomerList());
            }
        }
        private void arizaNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void musteriTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void searchForm_Load(object sender, EventArgs e)
        {
            dataListIcon(_vtIslemleri.GetCustomerList());
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


