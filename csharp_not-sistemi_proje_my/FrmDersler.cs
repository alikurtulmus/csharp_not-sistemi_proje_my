using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_not_sistemi_proje_my
{
    public partial class FrmDersler : Form
    {
        public FrmDersler()
        {
            InitializeComponent();
        }

        DataSet1TableAdapters.ders_tblTableAdapter ds = new DataSet1TableAdapters.ders_tblTableAdapter();

        void listele()
        {
            dataGridView1.DataSource = ds.DersListesi();

        }


        private void FrmDersler_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            ds.DersEkle(txtad.Text);
            MessageBox.Show("Ders eklendi.");
            listele();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            ds.DersSil(byte.Parse(txtid.Text));
            listele();
            MessageBox.Show("Ders silindi.");

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            ds.DersGuncelle(txtad.Text,byte.Parse(txtid.Text));
            listele();
            MessageBox.Show("Ders güncellendi.");

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
