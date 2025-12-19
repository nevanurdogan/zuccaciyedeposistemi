using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nevanurdogan_241701060
{
   
    public partial class FormDepoHareket2 : Form
              
    {
        string connectionString = @"Data Source=LENOVAI5\SQLEXPRESS;Initial Catalog=Zuccacıyedeposıstemı;Integrated Security=True";


        public FormDepoHareket2()
        {
            InitializeComponent();
        }
        void DepoHareketListele()
        {
            SqlConnection con = new SqlConnection(connectionString);

            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT H.HareketID, U.UrunAdi, H.HareketTipi, H.Miktar, H.Tarih " +
                "FROM DepoHareketleri H " +
                "INNER JOIN Urunler U ON H.UrunID = U.UrunID " +
                "ORDER BY H.Tarih DESC", con);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvDepoHareket.DataSource = dt;
        }
        void StokUyariKontrol()
        {
            SqlConnection con = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand(
                "SELECT UrunAdi, Stok FROM Urunler WHERE Stok <= 5", con);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            string mesaj = "";

            while (dr.Read())
            {
                mesaj += dr["UrunAdi"].ToString() +
                         " (Stok: " + dr["Stok"].ToString() + ")\n";
            }

            con.Close();

            if (mesaj != "")
            {
                MessageBox.Show(
                    "Stok azalan ürünler:\n\n" + mesaj,
                    "STOK UYARISI",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }


        void UrunleriDoldur()
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT UrunID, UrunAdi FROM Urunler", con);

            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbGirisUrun.DisplayMember = "UrunAdi";
            cmbGirisUrun.ValueMember = "UrunID";
            cmbGirisUrun.DataSource = dt;

            cmbCikisUrun.DisplayMember = "UrunAdi";
            cmbCikisUrun.ValueMember = "UrunID";
            cmbCikisUrun.DataSource = dt.Copy();
        }
        void TedarikciDoldur()
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT TedarikciID, FirmaAdi FROM Tedarikciler", con);

            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbTedarikci.DisplayMember = "FirmaAdi";
            cmbTedarikci.ValueMember = "TedarikciID";
            cmbTedarikci.DataSource = dt;
        }
        void MusteriDoldur()
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT MusteriID, Ad + ' ' + Soyad AS AdSoyad FROM Musteriler", con);

            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbMusteri.DisplayMember = "AdSoyad";
            cmbMusteri.ValueMember = "MusteriID";
            cmbMusteri.DataSource = dt;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StokUyariKontrol();

            "VALUES (@uid, 'CIKIS', GETDATE(), @miktar)"
                 try
            {
                int urunID = Convert.ToInt32(cmbCikisUrun.SelectedValue);
                int miktar = Convert.ToInt32(txtCikisMiktar.Text);

                
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                SqlCommand cmdStok = new SqlCommand(
                    "UPDATE Urunler SET Stok = Stok - @miktar WHERE UrunID = @uid", con);

                cmdStok.Parameters.AddWithValue("@miktar", miktar);
                cmdStok.Parameters.AddWithValue("@uid", urunID);
                cmdStok.ExecuteNonQuery();

                SqlCommand cmdLog = new SqlCommand(
                    "INSERT INTO DepoHareketleri (UrunID, HareketTipi, Tarih, Miktar) " +
                    "VALUES (@uid, 'CIKIS', GETDATE(), @miktar)", con);

                cmdLog.Parameters.AddWithValue("@uid", urunID);
                cmdLog.Parameters.AddWithValue("@miktar", miktar);
                cmdLog.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Depo çıkışı yapıldı");
                DepoHareketListele();
                StokUyariKontrol();
                txtCikisMiktar.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void FormDepoHareket2_Load(object sender, EventArgs e)
        {
           
            UrunleriDoldur();
            TedarikciDoldur();
            MusteriDoldur();
            DepoHareketListele();
            StokUyariKontrol();
        }

        private void grpGiris_Enter(object sender, EventArgs e)
        {
        

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int urunID = Convert.ToInt32(cmbGirisUrun.SelectedValue);
                int miktar = Convert.ToInt32(txtGirisMiktar.Text);

                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                SqlCommand cmdLog = new SqlCommand(
                    "INSERT INTO DepoHareketleri (UrunID, HareketTipi, Tarih, Miktar) " +
                    "VALUES (@uid, 'GIRIS', GETDATE(), @miktar)", con);

                cmdLog.Parameters.AddWithValue("@uid", urunID);
                cmdLog.Parameters.AddWithValue("@miktar", miktar);
                cmdLog.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Depo girişi kaydedildi");
                txtGirisMiktar.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
