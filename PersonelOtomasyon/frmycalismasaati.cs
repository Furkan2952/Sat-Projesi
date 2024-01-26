using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelOtomasyon
{
    public partial class frmycalismasaati : Form
    {
        public frmycalismasaati()
        {
            InitializeComponent();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            this.Close();
            frmyonetici adm = new frmyonetici();
            adm.Show();
        }

        private void frm_adm_calisma_saatleri_Load(object sender, EventArgs e)
        {

        }
    }
}
