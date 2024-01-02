using System.Data;
using System.Data.SqlClient;

namespace Arıza_takipV0001
{
    public class vtProcess
    {
        private string baglantiStr = @"Data Source=.;Initial Catalog=ArızaTakipV0001;Trusted_Connection=True;";
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter adaptor;

        public SqlConnection? sqlConnect() // veri tabanına bağlanmak için
        {
            try
            {
                baglanti = new SqlConnection(baglantiStr);
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
                baglanti.Open();

                return baglanti;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanına bağlantı kurulamadı. Detay : {0}", ex.Message);
                return null;
            }
        }
        public void UserDel(string kullanici) // var olan kullanıcıyı silmek için sql komutu
        {
            var connection = sqlConnect();
            string sql = "DELETE FROM userProperty WHERE kullanici=@kullanici";
            komut = new SqlCommand(sql, connection);
            komut.Parameters.AddWithValue("@kullanici", kullanici);
            komut.ExecuteNonQuery();

            MessageBox.Show("Seçilen kullanıcı Silindi.");

            if (connection != null) { connection.Close(); }
        }
        public DataTable GetCustomerList() // veri tabanında ki kayıtlı müşterileri getirmek için sql komutu
        {
            sqlConnect();

            DataTable dt = new DataTable();

            string firma = singInForm.setCompanyName;

            using (SqlDataAdapter adaptor = new SqlDataAdapter("SELECT * FROM customerProperty WHERE company = @firma", baglanti))
            {
                adaptor.SelectCommand.Parameters.AddWithValue("@firma", firma);
                adaptor.Fill(dt);
            }
            baglanti.Close();

            return dt;
        }
        public DataTable GetUserList() // veri tabanında ki kayıtlı kullanıcıları getirmek için sql komutu
        {
            sqlConnect();

            DataTable dt = new DataTable();
            adaptor = new SqlDataAdapter("SELECT * FROM userProperty", baglanti);
            adaptor.Fill(dt);
            baglanti.Close();

            return dt;
        }
        public DataTable GetUserByName(string name) // gelen paremetreye uygun kullanı var ise o kullanıcıya ait bilgileri döndüren sql komutu
        {
            sqlConnect();

            DataTable dt = new DataTable();
            adaptor = new SqlDataAdapter("SELECT TOP 1 * FROM userProperty WHERE kullanici = '" + name + "'", baglanti);
            adaptor.Fill(dt);
            baglanti.Close();

            return dt;
        }
        public bool IsUserExistByName(string name) // kullanıcı eklerken eklenen kulanıcının var olup olmadığını kontrol eden sql komutu
        {
            bool result = false;

            var connection = sqlConnect();
            string sqlString = "SELECT COUNT(*) FROM userProperty WHERE kullanici = @name";

            using (var command = new SqlCommand(sqlString, connection))
            {
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                var count = (int)command.ExecuteScalar();

                if (count > 0) result = true;
            }

            if (connection != null) connection.Close();

            return result;
        }
        public DataTable GetCustomerByName(string id, string unvan, string musteriTel, string cihazModeli) // gelen parametrelere uygun kayıtlı müsteri var ise listeleyen sql komutu
        {
            sqlConnect();

            DataTable dt = new DataTable();

            string firma = singInForm.setCompanyName;

            using (SqlDataAdapter adaptor = new SqlDataAdapter("SELECT * FROM customerProperty WHERE id = @id OR customerName = @unvan OR customerNo = @musteriTel OR productModel = @cihazModeli OR company = @firma", baglanti))
            {
                adaptor.SelectCommand.Parameters.AddWithValue("@id", id);
                adaptor.SelectCommand.Parameters.AddWithValue("@unvan", unvan);
                adaptor.SelectCommand.Parameters.AddWithValue("@musteriTel", musteriTel);
                adaptor.SelectCommand.Parameters.AddWithValue("@cihazModeli", cihazModeli);
                adaptor.SelectCommand.Parameters.AddWithValue("@firma", firma);
                adaptor.Fill(dt);
            }
            baglanti.Close();
            return dt;
        }
        private void sqlRun(string sql, string islem) // ürün veya kullanıcı eklenmesi sırasında hataları geri bildirmek için kullanılan sql komutu
        {
            sqlConnect();

            komut = new SqlCommand(sql, baglanti);
            try
            {
                komut.ExecuteNonQuery();
                MessageBox.Show(islem + " işlemi başarıyla gerçekleşti");
            }
            catch (SqlException hata)
            {
                MessageBox.Show(hata.Message.ToString());
            }
        }
        public void SetUserAdd(string kullanici, string statu, string password) // kullanıcı eklemek için gerekli sql komutu
        {
            sqlConnect();
            string sql = "INSERT INTO userProperty(kullanici, statu, password)" +
                 " VALUES('" + kullanici + "','" + statu + "','" + password + "')";
            sqlRun(sql, "Kullanıcı ekleme");
        }
        public void SetRePassword(string password, int id) // kullanıcıların şifrelerini güncellemek için kullanılan sql komutu
        {
            sqlConnect();

            string sql = "UPDATE userProperty set " +
                 "password='" + password + "'" + " WHERE id=" + id;
            sqlRun(sql, "Şifre Değiştirme");
        }
        public void SetProductAdd(string musteriUnvan, string musteriNo, string cihazModeli, string aciklama, double tutar, string odeme, string firma) // yeni müşteri eklemek için kullanılan sql komutu
        {
            sqlConnect();
            string sql = "INSERT INTO customerProperty(customerName, customerNo, productModel, explanation, total, pay, company)" +
                 " VALUES('" + musteriUnvan + "','" + musteriNo + "','" + cihazModeli + "','" + aciklama + "','" + tutar + "','" + odeme + "','" + firma + "')";

            sqlRun(sql, "Kayıt Ekleme");
        }
        public DataTable GetCompanyList() // veri tabanında ki kayıtlı firma ismini getirmek için sql komutu
        {
            sqlConnect();

            DataTable dt = new DataTable();
            adaptor = new SqlDataAdapter("SELECT * FROM company", baglanti);
            adaptor.Fill(dt);
            baglanti.Close();

            return dt;
        }
        public void SetCompanyName(string companyName) // firma eklemek için kullanılan sql komutu
        {
            sqlConnect();
            string sql = "INSERT INTO company(companyName)" +
                 " VALUES ('" + companyName + "')";
            sqlRun(sql, "Firma Ekleme ");
        }
        public void SetMapping(int companyId, int customerId)
        {
            sqlConnect();
            string sql = "INSERT INTO mappingTable(companyId, customerId)" +
                 " VALUES ('" + companyId + "','" + customerId + "')";
            sqlRun(sql, "Firma Ekleme ");
        }

        public void updatePay(string pay, int id)
        {
            sqlConnect();

            string sql = "UPDATE customerProperty set " +
                 "pay='" + pay + "'" + " WHERE id=" + id;
            sqlRun(sql, "Şifre Değiştirme");
        }
    }
}
