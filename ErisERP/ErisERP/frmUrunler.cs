using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace ErisERP
{
    public partial class frmUrunler : Form
    {
        public frmUrunler()
        {
            InitializeComponent();
        }

        private void frmUrunler_Load(object sender, EventArgs e)
        {
            UrunListele();
        }

        private void UrunListele()
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Urunler", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvUrunler.DataSource = dt;
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            UrunListele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Urunler (UrunKodu, UrunAdi, BirimFiyat, StokMiktari) VALUES (@kod, @ad, @fiyat, @stok)", conn);
                cmd.Parameters.AddWithValue("@kod", Guid.NewGuid().ToString().Substring(0, 8));
                cmd.Parameters.AddWithValue("@ad", "Yeni Ürün");
                cmd.Parameters.AddWithValue("@fiyat", 150);
                cmd.Parameters.AddWithValue("@stok", 25);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Ürün eklendi");
            UrunListele();
        }
    }
}
