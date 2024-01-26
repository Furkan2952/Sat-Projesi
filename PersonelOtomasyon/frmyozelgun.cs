using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace PersonelOtomasyon
{
    public partial class frmyozelgun : Form
    {
        public frmyozelgun()
        {
            InitializeComponent();
        }

        // Uygulamayı kapatma butonu
        private void btn_kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Form yüklendiğinde çalışan olay
        private void frmyozelgun_Load(object sender, EventArgs e)
        {
            yozelgunt.Format = DateTimePickerFormat.Short;
            yozelgunt.ShowUpDown = true;
            // DataGridView için sütunları tanımla
            datagridyozelgun.Columns.Add("og_ad", "Gün Adı");
            datagridyozelgun.Columns.Add("og_tarih", "Tarihi");

            // Form yüklenirken veriyi çeken fonksiyonu çağır
            LoadData();
        }

        // Özel gün kaydetme butonu
        private void btn_og_kaydet_Click(object sender, EventArgs e)
        {
            if (txtozelgun.Text != null || yozelgunt.Text != null) 
            {

                // Veritabanı bağlantı bilgilerini içeren string
                string baglanti = "Server=localhost;Database=personelotomasyon;Uid=root;Pwd=''";

                // MySqlCommand ve MySqlDataReader nesneleri
                MySqlCommand cmd;

                using (var baglan = new MySqlConnection(baglanti))
                {
                    baglan.Open();

                    // Özel gün eklemek için SQL sorgusu
                    string sorgu = "INSERT INTO ozelgun (ad, tarih) VALUES (@ad, @tarih)";
                    cmd = new MySqlCommand(sorgu, baglan);

                    // Parametreleri ekleyerek SQL sorgusunu güvenli hale getir
                    cmd.Parameters.AddWithValue("@ad", txtozelgun.Text);
                    cmd.Parameters.AddWithValue("@tarih", yozelgunt.Value);

                    // SQL sorgusunu çalıştır
                    cmd.ExecuteNonQuery();

                    // Veritabanı bağlantısını kapat
                    baglan.Close();

                    // Veri ekledikten sonra DataGridView'i güncelle
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Tüm Alanları Doldurunuz!");
            }
        }

        // Veriyi yükleyen fonksiyon
        private void LoadData()
        {
            // Veritabanı bağlantı bilgilerini içeren string
            string baglanti = "Server=localhost;Database=personelotomasyon;Uid=root;Pwd=''";

            // MySqlCommand ve MySqlDataReader nesneleri
            MySqlCommand cmd;
            MySqlDataReader dr;

            using (var baglan = new MySqlConnection(baglanti))
            {
                try
                {
                    // Veritabanına bağlan
                    baglan.Open();

                    // Veritabanından tüm özel günleri çeken SQL sorgusu
                    cmd = new MySqlCommand();
                    cmd.Connection = baglan;
                    cmd.CommandText = "SELECT * FROM ozelgun";
                    dr = cmd.ExecuteReader();

                    // Eğer veri varsa DataGridView'i temizle ve veriyi ekle
                    if (dr.HasRows)
                    {
                        datagridyozelgun.Rows.Clear();
                        while (dr.Read())
                        {
                            datagridyozelgun.Rows.Add(
                                // Sadece tarih kısmını al
                                dr["ad"].ToString(),
                                Convert.ToDateTime(dr["tarih"]).ToShortDateString() 
                            );
                        }
                        // Veritabanı bağlantısını kapat
                        baglan.Close();
                    }
                    else
                    {
                        MessageBox.Show("Özel Gün Bilgisi Bulunamadı!");
                    }
                }
                catch (Exception ex)
                {
                    // Hata durumunda kullanıcıya bilgi ver
                    MessageBox.Show("Bir sorun oluştu!\n" + ex.Message);
                }
            }
        }

        private void btn_og_sil_Click(object sender, EventArgs e)
        {
            string baglanti = "Server=localhost;Database=personelotomasyon;Uid=root;Pwd=''";

            // Seçili satırı sil
            if (datagridyozelgun.SelectedRows.Count > 0)
            {
                // Seçili satırın indeksini al
                int selectedIndex = datagridyozelgun.CurrentRow.Index;

                // Silme işlemi için sorgu
                string silme = "DELETE FROM ozelgun WHERE ad = @ad";

                using (var baglan = new MySqlConnection(baglanti))
                {
                    baglan.Open();

                    // MySqlCommand nesnesi oluştur ve parametreleri ekle
                    using (MySqlCommand cmd = new MySqlCommand(silme, baglan))
                    {
                        // Seçili satırın gün adını al
                        string selectedGünAdı = datagridyozelgun.Rows[selectedIndex].Cells["og_ad"].Value.ToString();

                        cmd.Parameters.AddWithValue("@ad", selectedGünAdı);

                        // SQL sorgusunu çalıştır
                        cmd.ExecuteNonQuery();
                    }

                    // Veritabanı bağlantısını kapat
                    baglan.Close();

                    // Veri silindikten sonra DataGridView'i güncelle
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz satırı seçin.");
            }
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            this.Close();
            frmyonetici ekle = new frmyonetici();
            ekle.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
