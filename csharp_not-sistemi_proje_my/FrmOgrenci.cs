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
    public partial class FrmOgrenci : Form
    {
        public FrmOgrenci()
        {
            InitializeComponent();
        }

        DataSet1TableAdapters.DataTable1TableAdapter ds=new DataSet1TableAdapters.DataTable1TableAdapter();
       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    
        private void FrmOgrenci_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.OgrenciListesi();
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-QBFPK40\SQLEXPRESS;Initial Catalog=OkulProjeDB;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select*from klp_tbl", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbkulup.DisplayMember = "klpad";
            cmbkulup.ValueMember = "klpid";
            cmbkulup.DataSource = dt;  
            baglanti.Close();
        }
        string c = "";
        private void btnekle_Click(object sender, EventArgs e)
        {
           

            if(rdbkız.Checked==true)
            {
                c = "Kız";
            }

            if (rdberkek.Checked == true)
            {
                c = "Erkek";
            }

            ds.OgrenciEkle(txtad.Text, txtsoyad.Text, byte.Parse(cmbkulup.SelectedValue.ToString()),c);
            MessageBox.Show("Öğrenci eklendi");
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.OgrenciListesi();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (rdbkız.Checked == true)
            {
                c = "Kız";
            }

            if (rdberkek.Checked == true)
            {
                c = "Erkek";
            }
            ds.OgrenciGuncelle(txtad.Text, txtsoyad.Text,byte.Parse(cmbkulup.SelectedValue.ToString()), c, int.Parse(txtid.Text));
            
            MessageBox.Show("Öğrenci bilgisi güncellenmiştir.");

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            ds.OgrenciSil(int.Parse(txtid.Text));
            MessageBox.Show("Öğrenci kaydı silinmiştir.");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
           // cmbkulup.Text=dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

        }

        private void btnara_Click(object sender, EventArgs e)
        {
           dataGridView1.DataSource= ds.OgrAra(txtara.Text);
        }
    }
}
