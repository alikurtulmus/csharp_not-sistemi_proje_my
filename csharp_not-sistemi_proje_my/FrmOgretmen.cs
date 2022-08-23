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
    public partial class FrmOgretmen : Form
    {
        public FrmOgretmen()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmKulup frmk =new FrmKulup();
            frmk.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDersler frmd = new FrmDersler();
            frmd.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmOgrenci frmo = new FrmOgrenci();
            frmo.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmNotlar frmn = new FrmNotlar();
            frmn.Show();
        }
    }
}
