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
    public partial class frmymesai : Form
    {
        public frmymesai()
        {
            InitializeComponent();
        }

        private void frmymesai_Load(object sender, EventArgs e)
        {
            datagridmesai.Columns.Add("id", "#");
            datagridmesai.Columns.Add("ad", "Ad");
            datagridmesai.Columns.Add("soyad", "Soyad");
            datagridmesai.Columns.Add("sicil_no", "Sicil No");
            datagridmesai.Columns.Add("vardiya_saat", "Mesai Saati");
            KayıtGoster();
        }
        private void KayıtGoster()
        {
            string baglanti = "Server=localhost;Database=personelotomasyon;Uid=root;Pwd=''";
            MySqlCommand cmd, cmd2;
            MySqlDataReader dr, dr2;

            using (var baglan2 = new MySqlConnection(baglanti))
            {
                try
                {
                    baglan2.Open();
                    cbisicilno.Items.Clear();
                    cmd2 = new MySqlCommand();
                    cmd2.Connection = baglan2;
                    cmd2.CommandText = "SELECT ad, soyad, sicil_no FROM personel";
                    dr2 = cmd2.ExecuteReader();
                    while (dr2.Read())
                    {
                        cbisicilno.Items.Add(dr2["sicil_no"].ToString() + " - " + dr2["ad"].ToString() + " " + dr2["soyad"].ToString());
                    }
                    baglan2.Close();

                    using (var baglan = new MySqlConnection(baglanti))
                    {
                        try
                        {
                            baglan.Open();
                            cmd = new MySqlCommand();
                            cmd.Connection = baglan;
                            cmd.CommandText = "SELECT * FROM mesai";
                            dr = cmd.ExecuteReader();

                            if (dr.HasRows)
                            {
                                datagridmesai.Rows.Clear();
                                while (dr.Read())
                                {
                                    datagridmesai.Rows.Add(
                                        dr["id"].ToString(),
                                        dr["ad"].ToString(),
                                        dr["soyad"].ToString(),
                                        dr["sicil_no"].ToString(),
                                        GetValidDate(dr["tarih_saat"].ToString()) // Doğru formatta bir tarih al
                                    );
                                }
                                baglan.Close();
                            }
                            else
                            {
                                MessageBox.Show("İzin Bilgisi Bulunamadı!");
                                baglan.Close();
                            }
                        }
                        catch (Exception ex)
                        {
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

        private string GetValidDate(string inputDate)
        {
            DateTime parsedDate;
            if (DateTime.TryParse(inputDate, out parsedDate))
            {
                return parsedDate.ToString("yyyy-MM-dd");
            }
            else
            {
                return "Geçersiz Tarih";
            }
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            this.Close();
            frmyonetici ekle = new frmyonetici();
            ekle.Show();
        }

        private void datagridmesai_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                datagridmesai.ClearSelection();
                datagridmesai.Rows[e.RowIndex].Selected = true;

                DataGridViewRow selectedRow = datagridmesai.Rows[e.RowIndex];

            }
        }

        private void btniekle_Click(object sender, EventArgs e)
        {
            string bas_tarih = dtpizinbas.Value.ToString("yyyy-MM-dd");
            string bit_tarih = dtpizinbit.Value.ToString("yyyy-MM-dd");
            if (cbisicilno.Text != null || bas_tarih != null || bit_tarih != null)
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
                        string sorgu = "INSERT INTO mesai (ad,soyad, sicil_no, tarih_saat) VALUES (@ad,@soyad, @sicil_no, @tarih_saat)";
                        cmd = new MySqlCommand(sorgu, baglan);

                        // Parametreleri ekleyerek SQL sorgusunu güvenli hale getir
                        cmd.Parameters.AddWithValue("@ad", ad);
                        cmd.Parameters.AddWithValue("@soyad", soyad);

                        cmd.Parameters.AddWithValue("@sicil_no", sicil_no);
                        cmd.Parameters.AddWithValue("@tarih_saat", currentDate.ToString("yyyy-MM-dd"));

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

        private void btnmsil_Click(object sender, EventArgs e)
        {
            string baglanti = "Server=localhost;Database=personelotomasyon;Uid=root;Pwd=''";

            // Seçili satırı sil
            if (datagridmesai.SelectedRows.Count > 0)
            {
                // Seçili satırın indeksini al
                int selectedIndex = datagridmesai.CurrentRow.Index;

                // Silme işlemi için sorgu
                string silme = "DELETE FROM mesai WHERE sicil_no = @sicilno";

                using (var baglan = new MySqlConnection(baglanti))
                {
                    baglan.Open();

                    // MySqlCommand nesnesi oluştur ve parametreleri ekle
                    using (MySqlCommand cmd = new MySqlCommand(silme, baglan))
                    {
                        // Seçili satırın gün adını al
                        string selectedGünAdı = datagridmesai.Rows[selectedIndex].Cells["sicil_no"].Value.ToString();

                        cmd.Parameters.AddWithValue("@sicilno", selectedGünAdı);

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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblmts_Click(object sender, EventArgs e)
        {

        }

        private void dtptarih_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
