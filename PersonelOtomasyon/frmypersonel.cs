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
using static PersonelOtomasyon.cls_Kullanici;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PersonelOtomasyon
{
    public partial class frmypersonel : Form
    {
        public frmypersonel()
        {
            InitializeComponent();
        }
        private void btnkapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void frmypersonel_Load(object sender, EventArgs e)
        {
            // DataGridView için sütunları tanımla
            datagridpersonel.Columns.Add("id", "#");
            datagridpersonel.Columns.Add("ad", "Ad");
            datagridpersonel.Columns.Add("soyad", "Soyad");
            datagridpersonel.Columns.Add("rol", "Rolü");
            datagridpersonel.Columns.Add("sicil_no", "Sicil_No");
            datagridpersonel.Columns.Add("kadro", "Kadro Tipi");
            datagridpersonel.Columns.Add("unvan", "Ünvanı");
            datagridpersonel.Columns.Add("email", "E-Posta");
            datagridpersonel.Columns.Add("sifre", "Şifre");
            datagridpersonel.Columns.Add("telefon", "Telefon");
            datagridpersonel.Columns.Add("tc_no", "Kimlik No");
            datagridpersonel.Columns.Add("adres", "Adres");
            datagridpersonel.Columns.Add("izin_1", "1. Izin");
            datagridpersonel.Columns.Add("izin_2", "2. Izin");

            // Form yüklenirken veriyi çeken fonksiyonu çağır
            KayıtGoster();
        }

        // Veriyi yükleyen fonksiyon
        private void KayıtGoster()
        {
            // Tekrara düşmemesi için comboboxları sıfırlıyoruz
            cbkadro.Items.Clear();
            cbypol.Items.Clear();

            // Combobox verilerini tanımla
            cbkadro.Items.Add("İşçi");
            cbkadro.Items.Add("Memur");

            cbypol.Items.Add("Kullanıcı");
            cbypol.Items.Add("Yönetici");

            Dictionary<string, string> gunler = new Dictionary<string, string>
            {
                { "Pazartesi", "Monday" },
                { "Salı", "Tuesday" },
                { "Çarşamba", "Wednesday" },
                { "Perşembe", "Thursday" },
                { "Cuma", "Friday" },
                { "Cumartesi", "Saturday" },
                { "Pazar", "Sunday" },
                { "", "" },
                { "Monday", "Pazartesi" },
                { "Tuesday", "Salı" },
                { "Wednesday", "Çarşamba" },
                { "Thursday", "Perşembe" },
                { "Friday", "Cuma" },
                { "Saturday", "Cumartesi" },
                { "Sunday", "Pazar" }

            };

            cbypizin1.DataSource = new BindingSource(gunler, null);
            cbypizin1.DisplayMember = "Key";
            cbypizin1.ValueMember = "Value";

            cbypizin2.DataSource = new BindingSource(gunler, null);
            cbypizin2.DisplayMember = "Key";
            cbypizin2.ValueMember = "Value";

            cbypizin2.Visible = false;
            lblizin2.Visible = false;

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
                    cmd.CommandText = "SELECT * FROM personel";
                    dr = cmd.ExecuteReader();

                    // Eğer veri varsa DataGridView'i temizle ve veriyi ekle
                    if (dr.HasRows)
                    {
                        datagridpersonel.Rows.Clear();
                        while (dr.Read())
                        {
                            datagridpersonel.Rows.Add(
                                dr["id"].ToString(),
                                dr["ad"].ToString(),
                                dr["soyad"].ToString(),
                                dr["rol"].ToString(),
                                dr["sicil_no"].ToString(),
                                dr["kadro"].ToString(),
                                dr["unvan"].ToString(),
                                dr["email"].ToString(),
                                dr["sifre"].ToString(),
                                dr["telefon"].ToString(),
                                dr["tc_no"].ToString(),
                                dr["adres"].ToString(),
                                gunler[dr["izin_1"].ToString()], 
                                gunler[dr["izin_2"].ToString()]
                            );
                        }
                        // Veritabanı bağlantısını kapat
                        baglan.Close();
                    }
                    else
                    {
                        MessageBox.Show("Personel Bilgisi Bulunamadı!");
                    }
                }
                catch (Exception ex)
                {
                    // Hata durumunda kullanıcıya bilgi ver
                    MessageBox.Show("Bir sorun oluştu!\n" + ex.Message);
                }
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            string baglanti = "Server=localhost;Database=personelotomasyon;Uid=root;Pwd=''";

            // Seçili satırı sil
            if (datagridpersonel.SelectedRows.Count > 0)
            {
                // Seçili satırın indeksini al
                int selectedIndex = datagridpersonel.CurrentRow.Index;

                // Silme işlemi için sorgu
                string silme = "DELETE FROM personel WHERE id = @id";

                using (var baglan = new MySqlConnection(baglanti))
                {
                    baglan.Open();

                    // MySqlCommand nesnesi oluştur ve parametreleri ekle
                    using (MySqlCommand cmd = new MySqlCommand(silme, baglan))
                    {
                        // Seçili satırın gün adını al
                        string selectedGünAdı = datagridpersonel.Rows[selectedIndex].Cells["id"].Value.ToString();

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

        private void cb_kadro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbkadro.SelectedIndex == 0)
            {
                cbypizin2.Visible = false;
                lblizin2.Visible = false;
            }
            else
            {
                cbypizin2.Visible = true;
                lblizin2.Visible = true;
            }
        }

        private void btnciktial_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.OverwritePrompt = false;
            save.Title = "PDF Dosyaları";
            save.DefaultExt = "pdf";
            save.Filter = "PDF Dosyaları (*.pdf)|*.pdf|Tüm Dosyalar(*.*)|*.*";
            if (save.ShowDialog() == DialogResult.OK)
            {
                PdfPTable pdfTable = new PdfPTable(datagridpersonel.ColumnCount);

                float pageWidth = PageSize.A2.Width; // Sayfa genişliği
                float tableWidth = pageWidth * 0.8f; // Tablo genişliği (sayfa genişliğinin %80'i)

                pdfTable.DefaultCell.Padding = 6;
                pdfTable.WidthPercentage = 100; // Tabloyu sayfanın tam genişliğine yay
                pdfTable.TotalWidth = tableWidth;
                pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;

                // Sayfa genişliğinin yarısı kadar boş hücre ekle (ortalamak için)
                PdfPCell emptyCell = new PdfPCell();
                emptyCell.Colspan = datagridpersonel.ColumnCount;
                emptyCell.Border = 0; // Kenarlığı olmayan bir hücre
                pdfTable.AddCell(emptyCell);

                foreach (DataGridViewColumn column in datagridpersonel.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    pdfTable.AddCell(cell);
                }

                try
                {
                    foreach (DataGridViewRow row in datagridpersonel.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            // Eğer hücre değeri null değilse, PDF tabloya ekle
                            if (cell.Value != null)
                            {
                                pdfTable.AddCell(cell.Value.ToString());
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
                    Paragraph title = new Paragraph("Personel Listesi");
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

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (txtypsicil.Text != null && txtypad.Text != null && txtypsoyad.Text != null && cbkadro.Text != null && txtypadres.Text != null && txtyptc.Text != null && txtypsifre.Text != null && txtypmail.Text != null && txtyptel.Text != null && txtypunvan.Text != null && cbypizin1.Text != null && cbypol.Text != null)
            {
                // Veritabanı bağlantı bilgilerini içeren string
                string baglanti = "Server=localhost;Database=personelotomasyon;Uid=root;Pwd=''";

                // MySqlCommand ve MySqlDataReader nesneleri
                MySqlCommand cmd;

                using (var baglan = new MySqlConnection(baglanti))
                {
                    baglan.Open();

                    // Sicil numarasının benzersiz olmasını sağlayan SQL sorgusu
                    string sicilKontrolSorgu = "SELECT COUNT(*) FROM personel WHERE sicil_no = @sicil_no";
                    cmd = new MySqlCommand(sicilKontrolSorgu, baglan);
                    cmd.Parameters.AddWithValue("@sicil_no", txtypsicil.Text);

                    int sicilNoSayisi = Convert.ToInt32(cmd.ExecuteScalar());

                    if (sicilNoSayisi > 0)
                    {
                        MessageBox.Show("Bu sicil numarası zaten kullanılmaktadır. Lütfen farklı bir sicil numarası giriniz.");
                    }
                    else
                    {
                        // Sicil numarası benzersizse özel gün eklemek için SQL sorgusu
                        string sorgu = "INSERT INTO personel (ad, soyad, rol, sicil_no, kadro, unvan, email, sifre, telefon, tc_no, adres, izin_1, izin_2) VALUES (@ad, @soyad, @rol, @sicil_no, @kadro, @unvan, @email, @sifre, @telefon, @tc_no, @adres, @izin_1, @izin_2)";
                        cmd = new MySqlCommand(sorgu, baglan);

                        // Parametreleri ekleyerek SQL sorgusunu güvenli hale getir
                        cmd.Parameters.AddWithValue("@ad", txtypad.Text);
                        cmd.Parameters.AddWithValue("@soyad", txtypsoyad.Text);
                        cmd.Parameters.AddWithValue("@rol", cbypol.Text);
                        cmd.Parameters.AddWithValue("@sicil_no", txtypsicil.Text);
                        cmd.Parameters.AddWithValue("@kadro", cbkadro.Text);
                        cmd.Parameters.AddWithValue("@unvan", txtypunvan.Text);
                        cmd.Parameters.AddWithValue("@email", txtypmail.Text);
                        cmd.Parameters.AddWithValue("@sifre", txtypsifre.Text);
                        cmd.Parameters.AddWithValue("@telefon", txtyptel.Text);
                        cmd.Parameters.AddWithValue("@tc_no", txtyptc.Text);
                        cmd.Parameters.AddWithValue("@adres", txtypadres.Text);

                        // Eğer izin1.SelectedItem'ı kullanarak seçili öğeyi almak istiyorsanız
                        string izin1 = cbypizin1.SelectedItem != null ? ((KeyValuePair<string, string>)cbypizin1.SelectedItem).Value : "";
                        string izin2 = cbypizin1.SelectedItem != null ? ((KeyValuePair<string, string>)cbypizin2.SelectedItem).Value : "";

                        cmd.Parameters.AddWithValue("@izin_1", izin1);
                        cmd.Parameters.AddWithValue("@izin_2", izin2);

                        // SQL sorgusunu çalıştır
                        cmd.ExecuteNonQuery();

                        // Veritabanı bağlantısını kapat
                        baglan.Close();

                        // Veri ekledikten sonra DataGridView'i güncelle
                        KayıtGoster();
                    }
                }
            }
            else
            {
                MessageBox.Show("Tüm Alanları Doldurunuz!");
            }
        }
        private void btnguncelle_Click(object sender, EventArgs e)
        {
            string baglanti = "Server=localhost;Database=personelotomasyon;Uid=root;Pwd=''";

            // Seçili satırı güncelle
            if (datagridpersonel.SelectedRows.Count > 0)
            {
                // Seçili satırın indeksini al
                int selectedIndex = datagridpersonel.CurrentRow.Index;

                // Güncelleme işlemi için sorgu
                string guncelle = "UPDATE personel SET ad = @ad, soyad = @soyad, rol = @rol, sicil_no = @sicil_no, kadro = @kadro, unvan = @unvan, email = @email, sifre = @sifre, telefon = @telefon, tc_no = @tc_no, adres=@adres, izin_1 = @izin_1, izin_2 = @izin_2 WHERE id = @id";

                using (var baglan = new MySqlConnection(baglanti))
                {
                    baglan.Open();

                    // MySqlCommand nesnesi oluştur ve parametreleri ekle
                    using (MySqlCommand cmd = new MySqlCommand(guncelle, baglan))
                    {
                        // Seçili satırın id'sini al
                        string selectedId = datagridpersonel.Rows[selectedIndex].Cells["id"].Value.ToString();

                        // Parametreleri ekleyerek SQL sorgusunu güncel hale getir
                        cmd.Parameters.AddWithValue("@id", selectedId);
                        cmd.Parameters.AddWithValue("@ad", txtypad.Text);
                        cmd.Parameters.AddWithValue("@soyad", txtypsoyad.Text);
                        cmd.Parameters.AddWithValue("@rol", cbypol.Text);
                        cmd.Parameters.AddWithValue("@sicil_no", txtypsicil.Text);
                        cmd.Parameters.AddWithValue("@kadro", cbkadro.Text);
                        cmd.Parameters.AddWithValue("@unvan", txtypunvan.Text);
                        cmd.Parameters.AddWithValue("@email", txtypmail.Text);
                        cmd.Parameters.AddWithValue("@sifre", txtypsifre.Text);
                        cmd.Parameters.AddWithValue("@telefon", txtyptel.Text);
                        cmd.Parameters.AddWithValue("@tc_no", txtyptc.Text);
                        cmd.Parameters.AddWithValue("@adres", txtypadres.Text);
                        // Eğer cb_izin1.SelectedItem'ı kullanarak seçili öğeyi almak istiyorsanız
                        string izin1 = cbypizin1.SelectedItem != null ? ((KeyValuePair<string, string>)cbypizin1.SelectedItem).Value : "";
                        string izin2 = cbypizin1.SelectedItem != null ? ((KeyValuePair<string, string>)cbypizin2.SelectedItem).Value : "";

                        cmd.Parameters.AddWithValue("@izin_1", izin1);
                        cmd.Parameters.AddWithValue("@izin_2", izin2);

                        // SQL sorgusunu çalıştır
                        cmd.ExecuteNonQuery();
                    }

                    // Veritabanı bağlantısını kapat
                    baglan.Close();

                    // Veri güncellendikten sonra DataGridView'i güncelle
                    KayıtGoster();

                    // TextBox'ları temizle
                    Clear();
                }
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz satırı seçin.");
            }
        }

        private void Clear()
        {
            // TextBox'ları temizle
            txtypad.Text = "";
            txtypsoyad.Text = "";
            cbypol.SelectedIndex = -1;
            txtypsicil.Text = "";
            cbkadro.SelectedIndex = -1;
            txtypunvan.Text = "";
            txtypmail.Text = "";
            txtypsifre.Text = "";
            txtyptel.Text = "";
            txtypadres.Text = "";
            txtyptc.Text = "";
            cbypizin1.SelectedIndex = -1;
            cbypizin2.SelectedIndex = -1;
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            this.Close();
            frmyonetici adm = new frmyonetici();
            adm.Show();
        }

        private void datagridpersonel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                datagridpersonel.ClearSelection();
                datagridpersonel.Rows[e.RowIndex].Selected = true;

                DataGridViewRow selectedRow = datagridpersonel.Rows[e.RowIndex];

                txtypad.Text = selectedRow.Cells["ad"].Value?.ToString();
                txtypsoyad.Text = selectedRow.Cells["soyad"].Value?.ToString();
                txtypsicil.Text = selectedRow.Cells["sicil_no"].Value?.ToString();
                cbkadro.Text = selectedRow.Cells["kadro"].Value?.ToString();
                txtypunvan.Text = selectedRow.Cells["unvan"].Value?.ToString();
                cbypol.Text = selectedRow.Cells["rol"].Value?.ToString();
                txtypmail.Text = selectedRow.Cells["email"].Value?.ToString();
                txtypsifre.Text = selectedRow.Cells["sifre"].Value?.ToString();
                txtyptel.Text = selectedRow.Cells["telefon"].Value?.ToString();
                txtyptc.Text = selectedRow.Cells["tc_no"].Value?.ToString();
                txtypadres.Text = selectedRow.Cells["adres"].Value?.ToString();
                cbypizin1.Text = selectedRow.Cells["izin_1"].Value?.ToString();
                cbypizin2.Text = selectedRow.Cells["izin_2"].Value?.ToString();


            }
        }

        private void pnl_personel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void datagridpersonel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cb_izin2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        { 
        }
            
        
        }
    }
    

