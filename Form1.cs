using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DepoProjesi
{
    public partial class frmMain : Form
    {
        SqlConnection connection;

        SqlDataAdapter dataAdapter;
        DataSet dataSet;
        SqlCommand sqlCommand;
        int toplamMaliyet = 0;
        int toplamSatis = 0;




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
        public int AyniKayitKontrol(string aranan)
        {
            baglantiAc();
            SqlCommand tekrar = new SqlCommand("select count(*) from UrunListesi where UrunAdi='" + aranan + "'", connection);
            int sonuc = (int)tekrar.ExecuteScalar();
            return sonuc;

        }
        public frmMain()
        {
            InitializeComponent();
        }
        void baglantiAc()
        {
            connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DepoTakip;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            connection.Open();


        }
        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            baglantiAc();

            if (0 == AyniKayitKontrol(txtUrunAdi.Text))
            {
                sqlCommand = new SqlCommand("insert into UrunListesi(UrunAdi,UrunAdet,UrunMaliyet,UrunFiyat)values(@UrunAdi,@UrunAdet,@UrunMaliyet,@UrunFiyat)", connection);
                sqlCommand.Parameters.AddWithValue("@UrunAdi", txtUrunAdi.Text);
                sqlCommand.Parameters.AddWithValue("@UrunAdet", txtUrunAdet.Text);
                sqlCommand.Parameters.AddWithValue("@UrunMaliyet", txtUrunMaliyet.Text);
                sqlCommand.Parameters.AddWithValue("@UrunFiyat", txtSatisFiyat.Text);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Ürün Girişi Başarı ile yapıldı.");

                connection.Close();
                gridDoldur();
            }
            else
            {
                MessageBox.Show("Ürün İsminde Aynısı Var.");

            


            }

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            gridDoldur();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            girisAdmin admin = new girisAdmin();
            admin.ShowDialog();
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
    }
}
