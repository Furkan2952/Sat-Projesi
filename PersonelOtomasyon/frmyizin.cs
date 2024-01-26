using MySql.Data.MySqlClient;
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
    public partial class frmyizin : Form
    {
        public frmyizin()
        {
            InitializeComponent();
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_adm_izin_Load(object sender, EventArgs e)
        {
            // DataGridView için sütunları tanımla
            datagridizinler.Columns.Add("id", "#");
            datagridizinler.Columns.Add("adsoyad", "Ad Soyad");
            datagridizinler.Columns.Add("sebep", "İzin Sebebi");
            datagridizinler.Columns.Add("sicil_no", "Sicil No");
            datagridizinler.Columns.Add("tarih", "Tarihi");

            // Form yüklenirken veriyi çeken fonksiyonu çağır
            KayıtGoster();
        }
        private void KayıtGoster()
        {
            // Veritabanı bağlantı bilgilerini içeren string
            string baglanti = "Server=localhost;Database=personelotomasyon;Uid=root;Pwd=''";

            // MySqlCommand ve MySqlDataReader nesneleri
            MySqlCommand cmd, cmd2;
            MySqlDataReader dr, dr2;
            using (var baglan2 = new MySqlConnection(baglanti))
            {
                try
                {
                    // Veritabanına bağlan
                    baglan2.Open();
                    cbisicilno.Items.Clear();
                    cmd2 = new MySqlCommand();
                    cmd2.Connection = baglan2;
                    cmd2.CommandText = "SELECT ad, soyad, sicil_no FROM personel";
                    dr2 = cmd2.ExecuteReader();
                    while (dr2.Read())
                    {
                        // cb_sicil_no ComboBox'ına sicil numaralarını ekleyin
                        cbisicilno.Items.Add(dr2["sicil_no"].ToString() + " - " + dr2["ad"].ToString() + " " + dr2["soyad"].ToString());
                    }
                    baglan2.Close();
                    using (var baglan = new MySqlConnection(baglanti))
                    {
                        try
                        {
                            // Veritabanına bağlan
                            baglan.Open();

                            // Veritabanından tüm izinleri çeken SQL sorgusu
                            cmd = new MySqlCommand();
                            cmd.Connection = baglan;
                            cmd.CommandText = "SELECT * FROM izin";
                            dr = cmd.ExecuteReader();

                            // Eğer veri varsa DataGridView'i temizle ve veriyi ekle
                            if (dr.HasRows)
                            {
                                datagridizinler.Rows.Clear();
                                while (dr.Read())
                                {
                                    datagridizinler.Rows.Add(
                                        dr["id"].ToString(),
                                        dr["adsoyad"].ToString(),
                                        dr["sebep"].ToString(),
                                        dr["sicil_no"].ToString(),
                                        // Sadece tarih kısmını al
                                        Convert.ToDateTime(dr["tarih"]).ToShortDateString()
                                    );
                                }
                                // Veritabanı bağlantısını kapat
                                baglan.Close();


                            }
                            else
                            {
                                MessageBox.Show("İzin Bilgisi Bulunamadı!");
                                // Veritabanı bağlantısını kapat
                                baglan.Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            // Hata durumunda kullanıcıya bilgi ver
                            MessageBox.Show("Bir sorun oluştu!\n" + ex.Message);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Personel Bilgisi Bulunamadı!");
                }
            }
            
        }


        private void btnikaydet_Click(object sender, EventArgs e)
        {
            string bas_tarih = dtpizinbas.Value.ToString("yyyy-MM-dd");
            string bit_tarih = dtpizinbit.Value.ToString("yyyy-MM-dd");
            if (txtizinsebep != null || cbisicilno.Text != null || bas_tarih != null || bit_tarih != null)
            {

                // Veritabanı bağlantı bilgilerini içeren string
                string baglanti = "Server=localhost;Database=personelotomasyon;Uid=root;Pwd=''";

                // MySqlCommand ve MySqlDataReader nesneleri
                MySqlCommand cmd;

                using (var baglan = new MySqlConnection(baglanti))
                {
                    baglan.Open();

                    // Tarih aralığındaki her gün için ayrı bir kayıt eklemek için döngü
                    DateTime startDate = DateTime.Parse(bas_tarih);
                    DateTime endDate = DateTime.Parse(bit_tarih);

                    for (DateTime currentDate = startDate; currentDate <= endDate; currentDate = currentDate.AddDays(1))
                    {
                        string secilenItem = cbisicilno.SelectedItem.ToString();
                        string[] parcalar = secilenItem.Split('-');

                        // Sicil numarasını al
                        string sicil_no = parcalar[0].Trim();

                        // Ad ve soyadı ayır
                        string[] adSoyadParcalar = parcalar[1].Split(' ');

                        // Adı al
                        string ad = adSoyadParcalar[0].Trim();

                        // Soyadı al
                        string soyad = string.Join(" ", adSoyadParcalar.Skip(1)).Trim();

                        // İzin bilgilerini eklemek için SQL sorgusu
                        string sorgu = "INSERT INTO izin (adsoyad, sebep, sicil_no, tarih) VALUES (@adsoyad, @sebep, @sicil_no, @tarih)";
                        cmd = new MySqlCommand(sorgu, baglan);

                        // Parametreleri ekleyerek SQL sorgusunu güvenli hale getir
                        cmd.Parameters.AddWithValue("@adsoyad", ad + " " + soyad);
                        cmd.Parameters.AddWithValue("@sicil_no", sicil_no);
                        cmd.Parameters.AddWithValue("@sebep", txtizinsebep.Text);
                        cmd.Parameters.AddWithValue("@tarih", currentDate.ToString("yyyy-MM-dd"));

                        // SQL sorgusunu çalıştır
                        cmd.ExecuteNonQuery();
                    }

                    // Veritabanı bağlantısını kapat
                    baglan.Close();

                    // Veri ekledikten sonra DataGridView'i güncelle
                    KayıtGoster();
                }
            }
            else 
            {
                MessageBox.Show("Tüm Alanları Doldurunuz!");
            }
        }

        private void btnisil_Click(object sender, EventArgs e)
        {
            string baglanti = "Server=localhost;Database=personelotomasyon;Uid=root;Pwd=''";

            // Seçili satırı sil
            if (datagridizinler.SelectedRows.Count > 0)
            {
                // Seçili satırın indeksini al
                int selectedIndex = datagridizinler.CurrentRow.Index;

                // Silme işlemi için sorgu
                string silme = "DELETE FROM izin WHERE id = @id";

                using (var baglan = new MySqlConnection(baglanti))
                {
                    baglan.Open();

                    // MySqlCommand nesnesi oluştur ve parametreleri ekle
                    using (MySqlCommand cmd = new MySqlCommand(silme, baglan))
                    {
                        // Seçili satırın gün adını al
                        string selectedId = datagridizinler.Rows[selectedIndex].Cells["id"].Value.ToString();

                        cmd.Parameters.AddWithValue("@id", selectedId);

                        // SQL sorgusunu çalıştır
                        cmd.ExecuteNonQuery();
                    }

                    // Veritabanı bağlantısını kapat
                    baglan.Close();

                    // Veri silindikten sonra DataGridView'i güncelle
                    KayıtGoster();
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz satırı seçin.");
            }
        }



        private void btngeri_Click(object sender, EventArgs e)
        {
            this.Close();
            frmyonetici adm = new frmyonetici();
            adm.Show();
        }

        private void pnl_og_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbisicilno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
