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
    public partial class girisAdmin : Form
    {
        SqlConnection connection;

        SqlDataAdapter dataAdapter;
        DataSet dataSet;
        DataTable dataTable;
        SqlCommand sqlCommand;
        public string sifre, kadi;
        void baglantiAc()
        {
            connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DepoTakip;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            connection.Open();


        }

        public girisAdmin()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            kadi = txtKAdi.Text;
            sifre = txtSifre.Text;

         
                baglantiAc();
                dataAdapter = new SqlDataAdapter("SELECT COUNT(*) FROM Admin WHERE KullaniciAdi='" + kadi + "' AND Sifre='" + sifre + "'", connection);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                if (dataTable.Rows[0][0].ToString() == "1")
                {

                adminPanel panel = new adminPanel();
                panel.ShowDialog();


                }
                else
                {
                    MessageBox.Show("Hatalı giriş yaptınız.Lütfen tekrar giriniz!!!");
                    txtKAdi.Text = "";
                    txtKAdi.Text = "";

                }
       
          
            connection.Close();        
        }
    }
}
