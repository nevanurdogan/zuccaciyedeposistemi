using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace nevanurdogan_241701060
{
    public partial class Form1 : Form
    {

        int secilenUrunID = 0;
        string connectionString = @"Data Source=LENOVAI5\SQLEXPRESS;Initial Catalog=Zuccacıyedeposıstemı;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }
      
        void UrunleriListele()
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT * FROM Urunler", con);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void Temizle()
        {
            txtUrunAdi.Text = "";
            txtStok.Text = "";
            txtAlis.Text = "";
            txtSatis.Text = "";

            secilenUrunID = 0;
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenUrunID = Convert.ToInt32(
     dataGridView1.CurrentRow.Cells["UrunID"].Value);

            txtUrunAdi.Text =
                dataGridView1.CurrentRow.Cells["UrunAdi"].Value.ToString();

            txtStok.Text =
                dataGridView1.CurrentRow.Cells["Stok"].Value.ToString();

            txtAlis.Text =
                dataGridView1.CurrentRow.Cells["AlisFiyati"].Value.ToString();

            txtSatis.Text =
                dataGridView1.CurrentRow.Cells["SatisFiyati"].Value.ToString();
        
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            try
            {
                if (secilenUrunID == 0)
                {
                    MessageBox.Show("Lütfen güncellenecek ürünü seçiniz");
                    return;
                }

                if (txtUrunAdi.Text == "" ||
                    txtStok.Text == "" ||
                    txtAlis.Text == "" ||
                    txtSatis.Text == "")
                {
                    MessageBox.Show("Boş alan bırakmayınız");
                    return;
                }

                SqlConnection con = new SqlConnection(connectionString);

                SqlCommand cmd = new SqlCommand(
                    "UPDATE Urunler SET UrunAdi=@ad, Stok=@stok, " +
                    "AlisFiyati=@alis, SatisFiyati=@satis WHERE UrunID=@id", con);

                cmd.Parameters.AddWithValue("@ad", txtUrunAdi.Text);
                cmd.Parameters.AddWithValue("@stok", Convert.ToInt32(txtStok.Text));
                cmd.Parameters.AddWithValue("@alis", Convert.ToDecimal(txtAlis.Text));
                cmd.Parameters.AddWithValue("@satis", Convert.ToDecimal(txtSatis.Text));
                cmd.Parameters.AddWithValue("@id", secilenUrunID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Ürün güncellendi");
                UrunleriListele();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:\n" + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UrunleriListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (secilenUrunID == 0)
                {
                    MessageBox.Show("Lütfen silinecek ürünü seçiniz");
                    return;
                }

                DialogResult sonuc = MessageBox.Show(
                    "Bu ürünü silmek istiyor musunuz?",
                    "Silme Onayı",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (sonuc == DialogResult.No)
                    return;

                SqlConnection con = new SqlConnection(connectionString);

                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Urunler WHERE UrunID=@id", con);

                cmd.Parameters.AddWithValue("@id", secilenUrunID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Ürün silindi");
                UrunleriListele();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:\n" + ex.Message);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUrunAdi.Text == "" ||
                    txtStok.Text == "" ||
                    txtAlis.Text == "" ||
                    txtSatis.Text == "")
                {
                    MessageBox.Show("Boş alan bırakmayınız");
                    return;
                }

                SqlConnection con = new SqlConnection(connectionString);

                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Urunler (UrunAdi, Stok, AlisFiyati, SatisFiyati) " +
                    "VALUES (@ad, @stok, @alis, @satis)", con);

                cmd.Parameters.AddWithValue("@ad", txtUrunAdi.Text);
                cmd.Parameters.AddWithValue("@stok", Convert.ToInt32(txtStok.Text));
                cmd.Parameters.AddWithValue("@alis", Convert.ToDecimal(txtAlis.Text));
                cmd.Parameters.AddWithValue("@satis", Convert.ToDecimal(txtSatis.Text));

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Ürün eklendi");
                UrunleriListele();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:\n" + ex.Message);
            }
        }

        private void btnDepoForm_Click(object sender, EventArgs e)
        {
            FormDepoHareket2 frm = new FormDepoHareket2();
            frm.Show();
            this.Hide();
        }
    }
    
}
