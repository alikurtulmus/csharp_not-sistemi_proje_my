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
    public partial class FrmNotlar : Form
    {
        public FrmNotlar()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.not_tblTableAdapter ds= new DataSet1TableAdapters.not_tblTableAdapter();
        private void txtara_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.NotListesi(int.Parse(txtid.Text));
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-QBFPK40\SQLEXPRESS;Initial Catalog=OkulProjeDB;Integrated Security=True");

        private void FrmNotlar_Load(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select*from ders_tbl", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DisplayMember = "dersad";
            comboBox1.ValueMember = "dersid";
            comboBox1.DataSource = dt;
            baglanti.Close();
        }

        int notid;


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            notid= int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtid.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt3.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtproje.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtort.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtdurum.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
        }
        int sınav1, sınav2, sınav3, proje;
        double ortalama;
        string durum;

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            
            sınav1 = Convert.ToInt16(txt1.Text);
            sınav2 = Convert.ToInt16(txt2.Text);
            sınav3 = Convert.ToInt16(txt3.Text);
            proje = Convert.ToInt16(txtproje.Text);
            ortalama = (sınav1 + sınav2 + sınav3 + proje) / 4;
            txtort.Text = ortalama.ToString();
            if(ortalama > 50)
            {
                txtdurum.Text = "True";
            }
            else
            {
                txtdurum.Text = "False";
            }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            ds.NotGuncelle(byte.Parse(comboBox1.SelectedValue.ToString()), int.Parse(txtid.Text),byte.Parse(txt1.Text), byte.Parse(txt2.Text),byte.Parse(txt3.Text), byte.Parse(txtproje.Text), decimal.Parse(txtort.Text), bool.Parse(txtdurum.Text),notid);
        }
    }
}
