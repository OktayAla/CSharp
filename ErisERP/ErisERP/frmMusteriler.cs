using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErisERP
{
    public partial class frmMusteriler : Form
    {
        public frmMusteriler()
        {
            InitializeComponent();
        }

        private void frmMusteriler_Load(object sender, EventArgs e)
        {
            MusteriListele();
        }

        private void MusteriListele()
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Musteriler", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvMusteriler.DataSource = dt;
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            MusteriListele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Musteriler (MusteriKodu, FirmaAdi) VALUES (@kod, @firma)", conn);
                cmd.Parameters.AddWithValue("@kod", Guid.NewGuid().ToString().Substring(0, 8));
                cmd.Parameters.AddWithValue("@firma", "Firma B");
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Müşteri eklendi");
            MusteriListele();
        }
    }
}
