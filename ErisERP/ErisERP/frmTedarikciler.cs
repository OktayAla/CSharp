using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace ErisERP
{
    public partial class frmTedarikciler : Form
    {
        public frmTedarikciler()
        {
            InitializeComponent();
        }

        private void frmTedarikciler_Load(object sender, EventArgs e)
        {
            TedarikciListele();
        }

        private void TedarikciListele()
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tedarikciler", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvTedarikciler.DataSource = dt;
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            TedarikciListele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Tedarikciler (FirmaAdi, YetkiliKisi) VALUES (@firma, @yetkili)", conn);
                cmd.Parameters.AddWithValue("@firma", "Tedarikçi X");
                cmd.Parameters.AddWithValue("@yetkili", "Ali Yetkili");
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Tedarikçi eklendi");
            TedarikciListele();
        }
    }
}
