using iTextSharp.text.pdf;
using iTextSharp.text;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PersonelOtomasyon.cls_vardiya;

namespace PersonelOtomasyon
{
    public partial class frmyvardiya : Form
    {
        public frmyvardiya()
        {
            InitializeComponent();
        }
       

        private void frmyvardiya_Load(object sender, EventArgs e)
        {
            // DataGridView için sütunları tanımla
            datagridvardiya.Columns.Add("id", "#");
            datagridvardiya.Columns.Add("ad", "Ad");
            datagridvardiya.Columns.Add("soyad", "Soyad");
            datagridvardiya.Columns.Add("sicilno", "Sicil No");
            datagridvardiya.Columns.Add("tarih", "Vardiya Tarih");
            datagridvardiya.Columns.Add("vardiya_saat", "Vardiya Saati");
            datagridvardiya.Columns.Add("lokasyon", "Çalışma Yeri");
            datagridvardiya.Columns.Add("izin_1", "Vardiya Günü");

            // Form yüklenirken veriyi çeken fonksiyonu çağır
            KayıtGoster();
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private bool IsIzinliGunu(string sicilNo, DateTime tarih)
        {
            string baglanti = "Server=localhost;Database=personelotomasyon;Uid=root;Pwd=''";

            using (var baglan = new MySqlConnection(baglanti))
            {
                try
                {
                    baglan.Open();

                    // Veritabanında izin tablosunu kontrol et
                    string izinSorgusu = "SELECT COUNT(*) FROM izin WHERE sicil_no = @sicil_no AND tarih = @tarih";
                    using (var izinCmd = new MySqlCommand(izinSorgusu, baglan))
                    {
                        izinCmd.Parameters.AddWithValue("@sicil_no", sicilNo);
                        izinCmd.Parameters.AddWithValue("@tarih", tarih);

                        int kayitSayisi = Convert.ToInt32(izinCmd.ExecuteScalar());

                        // Eğer belirtilen tarih için izin kaydı varsa true döndür
                        return kayitSayisi > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir sorun oluştu!\n" + ex.Message);
                    return false;
                }
                finally
                {
                    baglan.Close();
                }
            }
        }

        private void KayıtGoster()
        {
            cbcalismayeri.Items.Clear();
            cbcalismayeri.Items.Add("Kampüs Giriş");
            cbcalismayeri.Items.Add("Kampüs İçi");

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
                    cbsicil.Items.Clear();
                    cmd2 = new MySqlCommand();
                    cmd2.Connection = baglan2;
                    cmd2.CommandText = "SELECT ad, soyad, sicil_no FROM personel";
                    dr2 = cmd2.ExecuteReader();
                    while (dr2.Read())
                    {
                        // cbsicil ComboBox'ına sicil numaralarını ekleyin
                        cbsicil.Items.Add(dr2["sicil_no"].ToString() + " - " + dr2["ad"].ToString() + " " + dr2["soyad"].ToString());
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
                            cmd.CommandText = "SELECT * FROM vardiya";
                            dr = cmd.ExecuteReader();

                            // Eğer veri varsa DataGridView'i temizle ve veriyi ekle
                            if (dr.HasRows)
                            {
                                datagridvardiya.Rows.Clear();
                                while (dr.Read())
                                {
                                    DateTime tarih = Convert.ToDateTime(dr["tarih_gun"]);
                                    string gunAdi = tarih.ToString("dddd"); // Tarihten gün adını al

                                    bool izinli = IsIzinliGunu(dr["sicil_no"].ToString(), tarih);

                                    datagridvardiya.Rows.Add(
                                        dr["id"].ToString(),
                                        dr["ad"].ToString(),
                                        dr["soyad"].ToString(),
                                        dr["sicil_no"].ToString(),
                                        tarih.ToShortDateString(),
                                        dr["tarih_saat"].ToString(),
                                        dr["bolge"].ToString(),
                                        gunAdi,
                                        izinli ? "Evet" : "Hayır" // İzinli günü sütunu ekle
                                    );
                                }
                                // Veritabanı bağlantısını kapat
                                baglan.Close();
                            }
                        

                            else
                            {
                                MessageBox.Show("Vardiya Bilgisi Bulunamadı!");
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

        private void btn_geri_Click(object sender, EventArgs e)
        {
            this.Close();
            frmyonetici adm = new frmyonetici();
            adm.Show();
        }

        private void cbcalismayeri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbcalismayeri.SelectedIndex == 0)
            {
                cbvsaat.Items.Clear();
                cbvsaat.Items.Add("00.00 - 08.00");
                cbvsaat.Items.Add("08.00 - 16.00");
                cbvsaat.Items.Add("16.00 - 24.00");
            }
            else
            {
                cbvsaat.Items.Clear();
                cbvsaat.Items.Add("08.00 - 16.00");
                cbvsaat.Items.Add("09.00 - 17.00");
            }
        }

        private void btnvsil_Click(object sender, EventArgs e)
        {
            string baglanti = "Server=localhost;Database=personelotomasyon;Uid=root;Pwd=''";

            // Seçili satırı sil
            if (datagridvardiya.SelectedRows.Count > 0)
            {
                // Seçili satırın indeksini al
                int selectedIndex = datagridvardiya.CurrentRow.Index;

                // Silme işlemi için sorgu
                string silme = "DELETE FROM vardiya WHERE id = @id";

                using (var baglan = new MySqlConnection(baglanti))
                {
                    baglan.Open();

                    // MySqlCommand nesnesi oluştur ve parametreleri ekle
                    using (MySqlCommand cmd = new MySqlCommand(silme, baglan))
                    {
                        // Seçili satırın gün adını al
                        string selectedGünAdı = datagridvardiya.Rows[selectedIndex].Cells["id"].Value.ToString();

                        cmd.Parameters.AddWithValue("@id", selectedGünAdı);

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

        private void btnvolustur_Click(object sender, EventArgs e)
        {
            // Veritabanı bağlantı bilgilerini içeren string
            string baglanti = "Server=localhost;Database=personelotomasyon;Uid=root;Pwd=''";

            // MySqlCommand ve MySqlDataReader nesneleri
            MySqlCommand cmd;

            using (var baglan = new MySqlConnection(baglanti))
            {
                baglan.Open();

                // Önce " " karakterine göre stringi böl
                string[] parts = cbsicil.Text.Split(' ');

                // Sadece ilk parçayı (sicil_no) al
                string sicil_no = parts[0];
                string ad = parts[2];
                string soyad = parts[3];

                // Vardiya oluşturulacak tarih ve saat
                DateTime vardiyaTarih = dtpvtarih.Value;
                string vardiyaSaat = cbvsaat.Text;

                // Kontrol için flag
                bool vardiyaOlusturulabilir1 = true, vardiyaOlusturulabilir2 = true, vardiyaOlusturulabilir3 = true, vardiyaOlusturulabilir4 = true, mesaiEkle = false;

                // Aynı güne birden fazla saat kayıt edilip edilmediğini kontrol et
                string kontrol = "SELECT COUNT(*) FROM vardiya WHERE sicil_no = @sicil_no AND tarih_gun = @tarih_gun";
                using (var kontrolCmd = new MySqlCommand(kontrol, baglan))
                {
                    kontrolCmd.Parameters.AddWithValue("@sicil_no", sicil_no);
                    kontrolCmd.Parameters.AddWithValue("@tarih_gun", vardiyaTarih);

                    int kayitSayisi = Convert.ToInt32(kontrolCmd.ExecuteScalar());

                    if (kayitSayisi > 0)
                    {
                        // Aynı gün için daha önce kayıt yapılmışsa uyarı ver
                        DialogResult result = MessageBox.Show("Bu güne zaten vardiya atanmış. Devam Edilsin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.No)
                        {
                            vardiyaOlusturulabilir1 = false;
                        }
                        else
                        {
                            mesaiEkle = true;
                        }
                    }
                }

                // İzin aldığı gün olup olmadığını kontrol et
                string izinGunu = "SELECT COUNT(*) FROM izin WHERE sicil_no = @sicil_no AND tarih = @tarih_gun";
                using (var kontrolCmd = new MySqlCommand(izinGunu, baglan))
                {
                    kontrolCmd.Parameters.AddWithValue("@sicil_no", sicil_no);
                    kontrolCmd.Parameters.AddWithValue("@tarih_gun", vardiyaTarih);

                    int kayitSayisi = Convert.ToInt32(kontrolCmd.ExecuteScalar());

                    if (kayitSayisi > 0)
                    {
                        // Aynı gün için daha önce kayıt yapılmışsa uyarı ver
                        DialogResult result = MessageBox.Show("Personel izin almış. Devam Edilsin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.No)
                        {
                            vardiyaOlusturulabilir4 = false;
                        }
                        else
                        {
                            mesaiEkle = true;
                        }
                    }
                }

                // personel tablosundan izin_1 ve izin_2 günlerini kontrol et
                string izinSorgusu = "SELECT izin_1, izin_2 FROM personel WHERE sicil_no = @sicil_no";
                using (var izinCmd = new MySqlCommand(izinSorgusu, baglan))
                {
                    izinCmd.Parameters.AddWithValue("@sicil_no", sicil_no);

                    using (var izinReader = izinCmd.ExecuteReader())
                    {
                        if (izinReader.Read())
                        {
                            string izin1 = izinReader["izin_1"].ToString();
                            string izin2 = izinReader["izin_2"].ToString();

                            // personel tablosundan gelen izin günlerini kontrol et
                            if (vardiyaTarih.DayOfWeek.ToString() == izin1 || vardiyaTarih.DayOfWeek.ToString() == izin2)
                            {
                                // İzin gününe denk gelen bir vardiya oluşturulamaz
                                DialogResult result = MessageBox.Show("Bu tarih izin günüdür. Devam Edilsin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                if (result == DialogResult.No)
                                {
                                    vardiyaOlusturulabilir2 = false;
                                }
                                else
                                {
                                    mesaiEkle = true;
                                }
                            }
                        }
                    }
                }

                // ozelgun tablosunu kontrol et
                string ozelGunSorgusu = "SELECT * FROM ozelgun WHERE tarih = @tarih";
                using (var ozelGunCmd = new MySqlCommand(ozelGunSorgusu, baglan))
                {
                    ozelGunCmd.Parameters.AddWithValue("@tarih", vardiyaTarih);

                    using (var ozelGunReader = ozelGunCmd.ExecuteReader())
                    {
                        if (ozelGunReader.Read())
                        {
                            // İzin gününe denk gelen bir vardiya oluşturulamaz
                            DialogResult result = MessageBox.Show("Bu tarih özel gündür günüdür. Devam Edilsin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (result == DialogResult.No)
                            {
                                vardiyaOlusturulabilir3 = false;
                            }
                            else
                            {
                                mesaiEkle = true;
                            }
                        }
                    }
                }

                // Aynı gün içerisinde özel gün veya izin olmayan durumda vardiya kaydını yap
                if (vardiyaOlusturulabilir1 && vardiyaOlusturulabilir2 && vardiyaOlusturulabilir3 && vardiyaOlusturulabilir4) 
                {
                    // Vardiya oluşturulacak tarih ve saat
                    string bolge = cbcalismayeri.Text;

                    // Özel gün veya izin olup olmadığını kontrol eden kodlar bu noktadan önce eklendi
                    // Sadece bu blok içerisinde vardiya kaydını ve mesai kaydını yapılır

                    // Özel gün veya izin olmayan durumda vardiya kaydını yap
                    string vardiya = "INSERT INTO vardiya (ad, soyad, sicil_no, tarih_gun, tarih_saat, bolge) VALUES (@ad, @soyad, @sicil_no, @tarih_gun, @tarih_saat, @bolge)";
                    cmd = new MySqlCommand(vardiya, baglan);

                    // Parametreleri ekleyerek SQL sorgusunu güvenli hale getir
                    cmd.Parameters.AddWithValue("@ad", ad);
                    cmd.Parameters.AddWithValue("@soyad", soyad);
                    cmd.Parameters.AddWithValue("@sicil_no", sicil_no);
                    cmd.Parameters.AddWithValue("@tarih_gun", vardiyaTarih);
                    cmd.Parameters.AddWithValue("@tarih_saat", vardiyaSaat);
                    cmd.Parameters.AddWithValue("@bolge", bolge);

                    // SQL sorgusunu çalıştır
                    cmd.ExecuteNonQuery();

                    // Eğer mesai kaydedilecekse
                    if (mesaiEkle == true)
                    {
                        // mesai tablosuna kayıt ekle
                        string mesaiSorgu = "INSERT INTO mesai (ad, soyad, sicil_no, tarih_gun, tarih_saat, bolge) VALUES (@ad_mesai, @soyad_mesai, @sicil_no_mesai, @tarih_gun_mesai, @tarih_saat_mesai, @bolge_mesai)";
                        using (var mesaiCmd = new MySqlCommand(mesaiSorgu, baglan))
                        {
                            // Parametreleri ekleyerek SQL sorgusunu güvenli hale getir
                            mesaiCmd.Parameters.AddWithValue("@ad_mesai", ad);
                            mesaiCmd.Parameters.AddWithValue("@soyad_mesai", soyad);
                            mesaiCmd.Parameters.AddWithValue("@sicil_no_mesai", sicil_no);
                            mesaiCmd.Parameters.AddWithValue("@tarih_gun_mesai", vardiyaTarih);
                            mesaiCmd.Parameters.AddWithValue("@tarih_saat_mesai", vardiyaSaat);
                            mesaiCmd.Parameters.AddWithValue("@bolge_mesai", bolge);

                            // SQL sorgusunu çalıştır
                            mesaiCmd.ExecuteNonQuery();
                        }
                    }

                    // Veritabanı bağlantısını kapat
                    baglan.Close();

                    // Veri ekledikten sonra DataGridView'i güncelle
                    KayıtGoster();
                }

                baglan.Close();
            }
        }



        private void btnvguncelle_Click(object sender, EventArgs e)
        {
            string baglanti = "Server=localhost;Database=personelotomasyon;Uid=root;Pwd=''";

            // Seçili satırı güncelle
            if (datagridvardiya.SelectedRows.Count > 0)
            {
                // Seçili satırın indeksini al
                int selectedIndex = datagridvardiya.CurrentRow.Index;

                // Güncelleme işlemi için sorgu
                string guncelle = "UPDATE vardiya SET id = @id, tarih_gun = @tarih_gun, tarih_saat = @tarih_saat, bolge = @bolge WHERE id = @id";

                using (var baglan = new MySqlConnection(baglanti))
                {
                    baglan.Open();

                    // MySqlCommand nesnesi oluştur ve parametreleri ekle
                    using (MySqlCommand cmd = new MySqlCommand(guncelle, baglan))
                    {
                        // Seçili satırın id'sini al
                        string selectedId = datagridvardiya.Rows[selectedIndex].Cells["id"].Value.ToString();

                        // Parametreleri ekleyerek SQL sorgusunu güncel hale getir
                        cmd.Parameters.AddWithValue("@id", selectedId);
                        cmd.Parameters.AddWithValue("@tarih_gun", dtpvtarih.Value);
                        cmd.Parameters.AddWithValue("@tarih_saat", cbvsaat.Text);
                        cmd.Parameters.AddWithValue("@bolge", cbcalismayeri.Text);

                        // SQL sorgusunu çalıştır
                        cmd.ExecuteNonQuery();
                    }

                    // Veritabanı bağlantısını kapat
                    baglan.Close();

                    // Veri güncellendikten sonra DataGridView'i güncelle
                    KayıtGoster();
                }
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz satırı seçin.");
            }
        }


        public class Personel
        {
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public string SicilNo { get; set; }
            public string KadroTipi { get; set; }
            public string Izin1 { get; set; }
            public string Izin2 { get; set; }

            public Personel(string ad, string soyad ,string sicilNo, string kadroTipi, string izin1, string izin2)
            {
                Ad = ad;
                Soyad = soyad;
                SicilNo = sicilNo;
                KadroTipi = kadroTipi;
                Izin1 = izin1;
                Izin2 = izin2;
            }
        }
        public class Izinler
        {
            public string SicilNo { get; set; }
            public string Tarih { get; set; }

            public Izinler(string sicilNo, string tarih)
            {
                SicilNo = sicilNo;
                Tarih = tarih;
            }
        }

        public class OzelGunler
        {
            public string Tarih { get; set; }
            public string Ad { get; set; }

            public OzelGunler(string tarih, string ad)
            {
                Tarih = tarih;
                Ad = ad;
            }
        }
        private void btnciktial_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.OverwritePrompt = false;
            save.Title = "PDF Dosyaları";
            save.DefaultExt = "pdf";
            save.Filter = "PDF Dosyaları (*.pdf)|*.pdf|Tüm Dosyalar(*.*)|*.*";
            if (save.ShowDialog() == DialogResult.OK)
            {
                PdfPTable pdfTable = new PdfPTable(datagridvardiya.ColumnCount);

                float pageWidth = PageSize.A2.Width; // Sayfa genişliği
                float tableWidth = pageWidth * 0.8f; // Tablo genişliği (sayfa genişliğinin %80'i)

                pdfTable.DefaultCell.Padding = 6;
                pdfTable.WidthPercentage = 100; // Tabloyu sayfanın tam genişliğine yay
                pdfTable.TotalWidth = tableWidth;
                pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;

                // Sayfa genişliğinin yarısı kadar boş hücre ekle (ortalamak için)
                PdfPCell emptyCell = new PdfPCell();
                emptyCell.Colspan = datagridvardiya.ColumnCount;
                emptyCell.Border = 0; // Kenarlığı olmayan bir hücre
                pdfTable.AddCell(emptyCell);

                foreach (DataGridViewColumn column in datagridvardiya.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    pdfTable.AddCell(cell);
                }

                try
                {
                    foreach (DataGridViewRow row in datagridvardiya.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            // Eğer hücre değeri null değilse, PDF tabloya ekle
                            if (cell.Value != null)
                            {
                                // Tarih hücrelerini uygun formata dönüştürerek ekleyin
                                if (cell.OwningColumn.Name == "tarih")
                                {
                                    DateTime dateValue;
                                    if (DateTime.TryParse(cell.Value.ToString(), out dateValue))
                                    {
                                        pdfTable.AddCell(dateValue.ToString("dd.MM.yyyy"));
                                    }
                                    else
                                    {
                                        // Eğer tarih dönüştürme başarısız olursa, boş bir hücre ekleyebilir veya başka bir değer atayabilirsiniz.
                                        pdfTable.AddCell("");
                                    }
                                }
                                else
                                {
                                    // Tarih hücresi değilse, değeri doğrudan ekleyin
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }
                            else
                            {
                                // Eğer hücre değeri null ise, boş bir hücre ekleyebilir veya başka bir değer atayabilirsiniz.
                                pdfTable.AddCell("");
                            }
                        }
                    }
                }
                catch (NullReferenceException)
                {
                }

                using (FileStream stream = new FileStream(save.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 20f, 0f);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    // Başlık eklemek için
                    Paragraph title = new Paragraph("Vardiya Listesi");
                    title.Alignment = Element.ALIGN_CENTER;
                    pdfDoc.Add(title);

                    // Tabloyu sayfanın tam genişliğine yayarak hem sağdan hem soldan ortala
                    pdfTable.TotalWidth = pageWidth;
                    pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
                    pdfDoc.Add(pdfTable);

                    pdfDoc.Close();
                    stream.Close();
                }
            }
        }

        private void dgw_adm_vardiyalar_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                datagridvardiya.ClearSelection();
                datagridvardiya.Rows[e.RowIndex].Selected = true;

                DataGridViewRow selectedRow = datagridvardiya.Rows[e.RowIndex];

                cbsicil.Text = selectedRow.Cells["sicilno"].Value?.ToString();
                cbcalismayeri.Text = selectedRow.Cells["lokasyon"].Value?.ToString();
                dtpvtarih.Text = selectedRow.Cells["tarih"].Value?.ToString();
                cbvsaat.Text = selectedRow.Cells["vardiya_saat"].Value?.ToString();
            }
        }

        private void btnara_Click(object sender, EventArgs e)
        {

            DateTime basTarih = dtp_ara_baslangic.Value;
            DateTime bitTarih = dtp_ara_bitis.Value;

            // Tarihleri 'yyyy-MM-dd' formatına dönüştür
            string bas_tarih = basTarih.ToString("yyyy-MM-dd");
            string bit_tarih = bitTarih.ToString("yyyy-MM-dd");

            string baglanti = "Server=localhost;Database=personelotomasyon;Uid=root;Pwd=''";

            // MySqlCommand ve MySqlDataReader nesneleri
            MySqlCommand cmd;
            MySqlDataReader dr;

            using (var baglan = new MySqlConnection(baglanti))
            {
                try
                {
                    baglan.Open();

                    string sorgu = "SELECT * FROM vardiya WHERE tarih_gun BETWEEN @bas_tarih AND @bit_tarih";
                    cmd = new MySqlCommand(sorgu, baglan);

                    // Parametreleri ekleyerek SQL enjeksiyonlarına karşı koruma sağla
                    cmd.Parameters.AddWithValue("@bas_tarih", basTarih);
                    cmd.Parameters.AddWithValue("@bit_tarih", bitTarih);

                    dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        datagridvardiya.Rows.Clear();
                        while (dr.Read())
                        {
                            DateTime tarih = Convert.ToDateTime(dr["tarih_gun"]);
                            string gunAdi = tarih.ToString("dddd"); // Tarihten gün adını al
                            datagridvardiya.Rows.Add(
                                dr["id"].ToString(),
                                dr["ad"].ToString(),
                                dr["soyad"].ToString(),
                                dr["sicil_no"].ToString(),
                                Convert.ToDateTime(dr["tarih_gun"]).ToShortDateString(),
                                dr["tarih_saat"].ToString(),
                                dr["bolge"].ToString(),
                                gunAdi
                            );
                        }
                    }
                    else
                    {
                        MessageBox.Show("Belirtilen Tarihlerde Vardiya Bilgisi Bulunamadı!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir sorun oluştu!\n" + ex.Message);
                }

                finally
                {
                     // MySqlDataReader'ı kapat
                    baglan.Close();
                }
            }
        }
        private void btnotoolustur_Click(object sender, EventArgs e)
        {
            DateTime baslangicTarihi = dtpvbas.Value;
            DateTime bitisTarihi = dtpvbitis.Value;
            // vardiyalar sınıfının bir örneğini oluşturun
            cls_vardiya.vardiyalar vardiyalar = new cls_vardiya.vardiyalar(baslangicTarihi, bitisTarihi);
            // Ayrıca OtoEkle metodunu çağırarak otomatik vardiya ekleme işlemini gerçekleştirebilirsiniz
            vardiyalar.OtoEkle();
            KayıtGoster();
        }

        private void btnvardiyalarisil_Click(object sender, EventArgs e)
        {
            string baglanti = "Server=localhost;Database=personelotomasyon;Uid=root;Pwd=''";

            // Silme işlemi için sorgu
            string silme = "DELETE FROM vardiya";

            using (var baglan = new MySqlConnection(baglanti))
            {
                baglan.Open();

                // MySqlCommand nesnesi oluştur ve parametreleri ekle
                using (MySqlCommand cmd = new MySqlCommand(silme, baglan))
                {

                    // SQL sorgusunu çalıştır
                    cmd.ExecuteNonQuery();
                }
                
                // Veritabanı bağlantısını kapat
                baglan.Close();

                // Veri silindikten sonra DataGridView'i güncelle
                KayıtGoster();
            }
        }

        private void cbsicil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
