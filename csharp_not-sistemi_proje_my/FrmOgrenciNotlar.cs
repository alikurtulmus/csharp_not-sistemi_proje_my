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
    public partial class FrmOgrenciNotlar : Form
    {
        public FrmOgrenciNotlar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-QBFPK40\SQLEXPRESS;Initial Catalog=OkulProjeDB;Integrated Security=True");

        public string numara;

        private void FrmOgrenciNotlar_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select dersad,sınav1,sınav2,sınav3,proje,ortalama,durum from not_tbl inner join ders_tbl on not_tbl.dersid=ders_tbl.dersid where ogrid=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1",numara);
            //this.Text = numara.ToString();
            SqlDataAdapter da=new SqlDataAdapter(komut);
            DataTable dt= new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
    }
}
