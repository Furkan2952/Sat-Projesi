using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PersonelOtomasyon
{
    public partial class frmyonetici : Form
    {
        public frmyonetici()
        {
            InitializeComponent();
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            //Kapatma butonu ayarladık
            Application.Exit();
        }

        private void frmyonetici_Load(object sender, EventArgs e)
        {

        }

        private void btnpersonel_Click(object sender, EventArgs e)
        {
            // Personel formunun açılmasını sağlayan kod
            this.Close();
            frmypersonel ekle = new frmypersonel();
            ekle.Show();
        }

        private void btncalismasaatleri_Click(object sender, EventArgs e)
        {
            // Çalışma Saatleri formunun açılmasını sağlayan kod
            this.Close();
            frmycalismasaati ekle = new frmycalismasaati();
            ekle.Show();
        }

        private void btnozelgun_Click(object sender, EventArgs e)
        {
            // Özel Günler formunun açılmasını sağlayan kod
            this.Hide();
            frmyozelgun ekle = new frmyozelgun();
            ekle.Show();
        }

        private void btnizin_Click(object sender, EventArgs e)
        {
            // İzin formunun açılmasını sağlayan kod
            this.Hide();
            frmyizin ekle = new frmyizin();
            ekle.Show();
        }


        private void btnvardiyalar_Click(object sender, EventArgs e)
        {
            // Vardiyalar formunun açılmasını sağlayan kod
            this.Hide();
            frmyvardiya ekle = new frmyvardiya();
            ekle.Show();
        }

        private void btnmesailer_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmymesai ekle = new frmymesai();
            ekle.Show();

        }
    }
}
