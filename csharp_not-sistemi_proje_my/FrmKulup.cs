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

namespace csharp_not_sistemi_proje_my
{
    public partial class FrmKulup : Form
    {
        public FrmKulup()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-QBFPK40\SQLEXPRESS;Initial Catalog=OkulProjeDB;Integrated Security=True");

        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select*from klp_tbl", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void FrmKulup_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into klp_tbl(klpad) values (@p1)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Kulüp eklendi");
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text=dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtad.Text=dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from klp_tbl where klpid=@p1",baglanti);
            komut.Parameters.AddWithValue("@p1",txtid.Text);
            komut.ExecuteNonQuery();
                      
            baglanti.Close();
            MessageBox.Show("Kulüp silindi");
            listele();
             
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update klp_tbl set klpad=@p2 where klpid=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", txtid.Text);
            komut.Parameters.AddWithValue("@p2", txtad.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kulüp bilgileri güncellendi");
            listele();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
