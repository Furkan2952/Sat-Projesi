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
using static PersonelOtomasyon.cls_Kullanici;

namespace PersonelOtomasyon
{
    public partial class frmgiris : Form
    {
        public frmgiris()
        {
            InitializeComponent();
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            //Kapatma butonu ayarladık
            this.Close();
        }

        private void btn_giris_yap_Click(object sender, EventArgs e)
        {
            string bag = "Server=localhost;Database=personelotomasyon;Uid=root;Pwd='';";

            string kuleposta = tbx_eposta.Text;
            string kulsifre = tbx_sifre.Text;

            if (!string.IsNullOrEmpty(kuleposta) && !string.IsNullOrEmpty(kulsifre))
            {
                using (var baglan = new MySqlConnection(bag))
                {
                    try
                    {
                        baglan.Open();

                        using (MySqlCommand cmd = new MySqlCommand())
                        {
                            cmd.Connection = baglan;
                            cmd.CommandText = "SELECT * FROM personel WHERE email=@eposta AND sifre=@sifre";
                            cmd.Parameters.AddWithValue("@eposta", kuleposta);
                            cmd.Parameters.AddWithValue("@sifre", kulsifre);

                            using (MySqlDataReader dr = cmd.ExecuteReader())
                            {
                                if (dr.Read())
                                {
                                    string userRole = dr["rol"].ToString();

                                    if (userRole == "Yönetici")
                                    {
                                        kullanici.Id = dr["id"].ToString();
                                        kullanici.SicilNo = dr["sicil_no"].ToString();
                                        kullanici.AdSoyad = dr["ad"].ToString() + " " + dr["soyad"].ToString();
                                        this.Hide();
                                        frmyonetici admin = new frmyonetici();
                                        admin.Show();
                                    }
                                    else if (userRole == "Kullanıcı")
                                    {
                                        kullanici.Id = dr["id"].ToString();
                                        kullanici.SicilNo = dr["sicil_no"].ToString();
                                        kullanici.AdSoyad = dr["ad"].ToString() + " " + dr["soyad"].ToString();
                                        this.Hide();
                                        frmpersonel personel = new frmpersonel();
                                        personel.Show();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Bilinmeyen rol: " + userRole);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre Girdiniz.");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bağlantı ile ilgili bir sorun oluştu!\n" + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı ve Şifre Tam Girilmelidir!");
            }
        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }

        private void pnl_login_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
