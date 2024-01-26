using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using static PersonelOtomasyon.cls_Kullanici;

namespace PersonelOtomasyon
{
    public partial class frmpersonel : Form
    {
        public frmpersonel()
        {
            InitializeComponent();
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmpersonel_Load(object sender, EventArgs e)
        {
            datagridpersonelvardiya.Columns.Add("tarih_gun", "Tarih Gün");
            datagridpersonelvardiya.Columns.Add("tarih_saat", "Tarih Saat");
            datagridpersonelvardiya.Columns.Add("bolge", "Bölge");

            string baglanti = "Server=localhost;Database=personelotomasyon;Uid=root;Pwd=''";
            MySqlCommand cmd, cmd2;
            MySqlDataReader dr, dr2;

            using (var baglan = new MySqlConnection(baglanti))
            {
                try
                {
                    baglan.Open();
                    cmd = new MySqlCommand();
                    cmd.Connection = baglan;
                    cmd.CommandText = "SELECT * FROM personel where id='" + kullanici.Id + "'";
                    dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        txtadsoy.Text = dr["ad"].ToString() + " " + dr["soyad"].ToString();
                        txtsicilno.Text = dr["sicil_no"].ToString();
                        txtkadro.Text =  dr["kadro"].ToString();
                        txtunvan.Text = dr["unvan"].ToString();
                        txttel.Text = dr["telefon"].ToString();
                        txtmail.Text = dr["email"].ToString();
                        txtprim.Text = dr["prim"].ToString();

                        baglan.Close();

                        try
                        {
                            baglan.Open();
                            cmd2 = new MySqlCommand();
                            cmd2.Connection = baglan;
                            cmd2.CommandText = "SELECT * FROM vardiya where sicil_no='" + kullanici.SicilNo + "'";
                            dr2 = cmd2.ExecuteReader();
                            if (dr2.HasRows)
                            {
                                datagridpersonelvardiya.Rows.Clear();
                                while (dr2.Read())
                                {
                                    datagridpersonelvardiya.Rows.Add(
                                        dr2["tarih_gun"].ToString(),
                                        dr2["tarih_saat"].ToString(),
                                        dr2["bolge"].ToString()
                                    );
                                }
                                baglan.Close();
                            }
                            else
                            {
                                MessageBox.Show("Personele Ait Vardiya Bilgisi Bulunamadı!");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Bir sorun oluştu!\n" + ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bir Hata Oluştu!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir sorun oluştu!\n" + ex.Message);
                }
            }
        }

        private void btncikti_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.OverwritePrompt = false;
            save.Title = "PDF Dosyaları";
            save.DefaultExt = "pdf";
            save.Filter = "PDF Dosyaları (*.pdf)|*.pdf|Tüm Dosyalar(*.*)|*.*";
            if (save.ShowDialog() == DialogResult.OK)
            {
                PdfPTable pdfTable = new PdfPTable(datagridpersonelvardiya.ColumnCount);

                float pageWidth = PageSize.A2.Width; // Sayfa genişliği
                float tableWidth = pageWidth * 0.8f; // Tablo genişliği (sayfa genişliğinin %80'i)

                pdfTable.DefaultCell.Padding = 6;
                pdfTable.WidthPercentage = 100; // Tabloyu sayfanın tam genişliğine yay
                pdfTable.TotalWidth = tableWidth;
                pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;

                // Sayfa genişliğinin yarısı kadar boş hücre ekle (ortalamak için)
                PdfPCell emptyCell = new PdfPCell();
                emptyCell.Colspan = datagridpersonelvardiya.ColumnCount;
                emptyCell.Border = 0; // Kenarlığı olmayan bir hücre
                pdfTable.AddCell(emptyCell);

                foreach (DataGridViewColumn column in datagridpersonelvardiya.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    pdfTable.AddCell(cell);
                }

                try
                {
                    foreach (DataGridViewRow row in datagridpersonelvardiya.Rows)
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
                    Paragraph title = new Paragraph(kullanici.AdSoyad + " Personel Vardiya Programi");
                    title.Alignment = Element.ALIGN_BASELINE;
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

        private void pnl_per_profil_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_giris_paneli_Click(object sender, EventArgs e)
        {

        }

      

        private void lbl_ad_soyad_Click(object sender, EventArgs e)
        {

        }

        private void datagridpersonelvardiya_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
