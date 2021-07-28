using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepoProjesi
{
    public partial class adminPanel : Form
    {
        SqlConnection connection;

        SqlDataAdapter dataAdapter;
        DataSet dataSet;
        DataTable dataTable;
        SqlCommand sqlCommand;
        SqlDataReader dataReader;
        int toplamMaliyet = 0;
        int toplamSatis = 0;



        void baglantiAc()
        {
            connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DepoTakip;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            connection.Open();


        }
        void gridDoldur()
        {
            connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DepoTakip;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            dataAdapter = new SqlDataAdapter("select * from UrunListesi", connection);
            dataSet = new DataSet();
            connection.Open();
            dataAdapter.Fill(dataSet, "UrunListesi");
            dataGridView1.DataSource = dataSet.Tables["UrunListesi"];
            connection.Close();

            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                toplamMaliyet += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
            }
            lblToplamMaliyet.Text = "Ürünlerin Toplam Maliyet Fiyati : " + toplamMaliyet.ToString();
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                toplamSatis += Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
            }
            lblToplamSatis.Text = "Ürünlerin Toplam Satiş Fiyati : " + toplamSatis.ToString();


        }
        void ComboboxDoldur()
        {
            baglantiAc();
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "SELECT *FROM UrunListesi";
            sqlCommand.Connection = connection;
            sqlCommand.CommandType = CommandType.Text;
            dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                cmbUrunSil.Items.Add(dataReader["UrunAdi"]);
                cmbUrunCikisAdi.Items.Add(dataReader["UrunAdi"]);
            }
            connection.Close();
        }
        public int AyniKayitKontrol(string aranan)
        {
            baglantiAc();
            SqlCommand tekrar = new SqlCommand("select count(*) from UrunListesi where UrunAdi='" + aranan + "'", connection);
            int sonuc = (int)tekrar.ExecuteScalar();
            return sonuc;

        }
        public adminPanel()
        {
            InitializeComponent();
        }

        private void adminPanel_Load(object sender, EventArgs e)
        {
            gridDoldur();
            ComboboxDoldur();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglantiAc();
            string sorgu = "DELETE FROM UrunListesi WHERE UrunAdi=@UrunAdi ";
            sqlCommand = new SqlCommand(sorgu, connection);
            sqlCommand.Parameters.AddWithValue("@UrunAdi", cmbUrunSil.Text);
            sqlCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Kayıt Başarıyla Silindi.");
            cmbUrunSil.Text = "";
            cmbUrunSil.Items.Clear();
            ComboboxDoldur();
            gridDoldur();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbUrunAdi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            baglantiAc();
            string kayit = "SELECT * from UrunListesi where ID=@id";
            SqlCommand komut = new SqlCommand(kayit, connection);
            komut.Parameters.AddWithValue("@id", txtAra.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                txtUrunAdi.Text = dr["UrunAdi"].ToString();
                txtSatisFiyat.Text = dr["UrunFiyat"].ToString();
                txtUrunAdet.Text = dr["UrunAdet"].ToString();
                txtUrunMaliyet.Text = dr["UrunMaliyet"].ToString();
       
            }
            else
                MessageBox.Show("Ürün Bulunamadı.");
            connection.Close();
        }

        private void btnUrunGüncelle_Click(object sender, EventArgs e)
        {
            baglantiAc();
            if (txtAra.Text == "" || txtSatisFiyat.Text == "" || txtUrunAdet.Text == "" || txtUrunAdi.Text == "" || txtUrunMaliyet.Text == "")
            {
                MessageBox.Show("Güncelleme  Fiyat,Adet,Adi,Maliyet Fiyat Boş Olamaz");

            }
            else {

           
            string kayit = "update UrunListesi set UrunAdi=@UrunAdi,UrunAdet=@UrunAdet,UrunMaliyet=@UrunMaliyet,UrunFiyat=@UrunFiyat where Id=@Id";
            SqlCommand komut = new SqlCommand(kayit, connection);
                komut.Parameters.AddWithValue("@Id", txtAra.Text);

                komut.Parameters.AddWithValue("@UrunAdi", txtUrunAdi.Text);
            komut.Parameters.AddWithValue("@UrunAdet", int.Parse(txtUrunAdet.Text));
            komut.Parameters.AddWithValue("@UrunMaliyet", txtUrunMaliyet.Text);
            komut.Parameters.AddWithValue("@UrunFiyat", txtSatisFiyat.Text);
   
            komut.ExecuteNonQuery();
            connection.Close();
            gridDoldur();
            MessageBox.Show("Ürün Bilgileri Güncellendi.");
                

            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtUrunAdi.Text = "";
            txtUrunAdet.Text = "";
            txtUrunMaliyet.Text = "";
            txtSatisFiyat.Text = "";

        }

        private void cmbUrunCikisAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglantiAc();
            string kayit = "SELECT * from UrunListesi where UrunAdi=@UrunAdi";
            SqlCommand komut = new SqlCommand(kayit, connection);
            komut.Parameters.AddWithValue("@UrunAdi", cmbUrunCikisAdi.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                txtUrunCikisAdet.Text = dr["UrunAdet"].ToString();
             
            }
            else
                MessageBox.Show("Ürün Bulunamadı.");
            gridDoldur();

            connection.Close();
        }

        private void btnUrunCikis_Click(object sender, EventArgs e)
        {

            baglantiAc();
            string kayit = "update UrunListesi set UrunAdet=@UrunAdet where UrunAdi=@UrunAdi";
            SqlCommand komut = new SqlCommand(kayit, connection);

            komut.Parameters.AddWithValue("@UrunAdi", cmbUrunCikisAdi.Text);

            komut.Parameters.AddWithValue("@UrunAdet", int.Parse(txtUrunCikisAdet.Text));
    

            komut.ExecuteNonQuery();
            connection.Close();
            gridDoldur();
            MessageBox.Show("Ürün Bilgileri Güncellendi.");

        }

        private void txtUrunMaliyet_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void txtUrunAdet_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void txtSatisFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void txtUrunCikisAdet_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
    }
}
