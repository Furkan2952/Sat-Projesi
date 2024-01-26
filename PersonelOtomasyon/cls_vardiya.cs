using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PersonelOtomasyon
{
    internal class cls_vardiya
    {
        public class vardiyalar
        {
            public DateTime Baslangic { get; set; }
            public DateTime Bitis { get; set; }
            public int Fark { get; private set; }

            public vardiyalar(DateTime baslangic, DateTime bitis)
            {
                Baslangic = baslangic;
                Bitis = bitis;
                Fark = (int)(Bitis - Baslangic).TotalDays + 1;
                OtoEkle();
            }
            private string dbConnectionString = "Server=localhost;Database=personelotomasyon;Uid=root;Pwd=''";

            public void VardiyaEkle(int sicil, DateTime tarih, string yer, string saat)
            {
                using (var baglan = new MySqlConnection(dbConnectionString))
                {
                    baglan.Open();

                    // Kullanıcıyı sorgula
                    string kullaniciSorgu = $"SELECT * FROM personel WHERE sicil_no = '{sicil}'";
                    var kullaniciCmd = new MySqlCommand(kullaniciSorgu, baglan);

                    using (var kullaniciReader = kullaniciCmd.ExecuteReader())
                    {
                        if (kullaniciReader.Read())
                        {
                            // Kullanıcıyı bulduğumuzda vardiya ekleyebiliriz
                            string isim = kullaniciReader["ad"].ToString();
                            string soyisim = kullaniciReader["soyad"].ToString();

                            kullaniciReader.Close(); // Close the reader after retrieving the required information

                            string vardiyaEkleSorgu = @"INSERT INTO vardiya (ad, soyad, sicil_no, tarih_gun, tarih_saat, bolge) VALUES (@ad, @soyad, @sicil_no, @tarih_gun, @tarih_saat, @bolge)";

                            var vardiyaEkleCmd = new MySqlCommand(vardiyaEkleSorgu, baglan);

                            // Parametreleri ekleyerek SQL sorgusunu güvenli hale getir
                            vardiyaEkleCmd.Parameters.AddWithValue("@ad", isim);
                            vardiyaEkleCmd.Parameters.AddWithValue("@soyad", soyisim);
                            vardiyaEkleCmd.Parameters.AddWithValue("@sicil_no", sicil);
                            vardiyaEkleCmd.Parameters.AddWithValue("@tarih_gun", tarih);
                            vardiyaEkleCmd.Parameters.AddWithValue("@tarih_saat", saat);
                            vardiyaEkleCmd.Parameters.AddWithValue("@bolge", yer);

                            // Vardiya ekleyen SQL sorgusunu çalıştır
                            vardiyaEkleCmd.ExecuteNonQuery();
                        }
                        else
                        {
                            // Kullanıcı bulunamadı, hata işleme yapılabilir
                        }
                    }
                }
            }

            public bool VardiyaKontrol(int sicilNo, DateTime tarih)
            {       
                if (!IzinKontrol(sicilNo, tarih) && !IsKontrol(sicilNo, tarih) && !TatilKontrol(sicilNo, tarih))
                {
                    return true;
                }

                return false;
            }
            public bool IzinKontrol(int sicilNo, DateTime tarih)
            {
                using (var baglan = new MySqlConnection(dbConnectionString))
                {
                    baglan.Open();

                    // İzin kontrolü için SQL sorgusu
                    string sorgu = $"SELECT COUNT(*) FROM izin WHERE sicil_no = '{sicilNo}' AND tarih = '{tarih.ToString("yyyy-MM-dd")}'";
                    var cmd = new MySqlCommand(sorgu, baglan);

                    // İzin sayısını al
                    int izinSayisi = Convert.ToInt32(cmd.ExecuteScalar());

                    // Veritabanı bağlantısını kapat
                    baglan.Close();

                    // İzin sayısı 0'dan büyükse izinli, aksi takdirde izinli değil
                    return izinSayisi > 0;
                }
            }
            public bool IsKontrol(int sicilNo, DateTime tarih)
            {
                using (var baglan = new MySqlConnection(dbConnectionString))
                {
                    baglan.Open();

                    // Çalışma kontrolü için SQL sorgusu
                    string sorgu = $"SELECT COUNT(*) FROM vardiya WHERE sicil_no = '{sicilNo}' AND tarih_gun = '{tarih.ToString("yyyy-MM-dd")}'";
                    var cmd = new MySqlCommand(sorgu, baglan);

                    // Çalışma sayısını al
                    int calismaSayisi = Convert.ToInt32(cmd.ExecuteScalar());

                    // Veritabanı bağlantısını kapat
                    baglan.Close();

                    // Çalışma sayısı 0'dan büyükse çalışıyor, aksi takdirde çalışmıyor
                    return calismaSayisi > 0;
                }
            }
            public bool TatilKontrol(int sicilNo, DateTime tarih)
            {
                using (var baglan = new MySqlConnection(dbConnectionString))
                {
                    baglan.Open();

                    // Tatil günü kontrolü için SQL sorgusu
                    string kontrolSorgu1 = $"SELECT izin_1 FROM personel WHERE sicil_no = '{sicilNo}'";
                    string kontrolSorgu2 = $"SELECT izin_2 FROM personel WHERE sicil_no = '{sicilNo}'";

                    var kontrolCmd1 = new MySqlCommand(kontrolSorgu1, baglan);
                    var kontrolCmd2 = new MySqlCommand(kontrolSorgu2, baglan);

                    // Tatil günleri bilgisini al
                    string izin_1 = kontrolCmd1.ExecuteScalar()?.ToString();
                    string izin_2 = kontrolCmd2.ExecuteScalar()?.ToString();

                    // Veritabanı bağlantısını kapat
                    baglan.Close();

                    // Türkçe gün adı al
                    string bugununGunu = tarih.ToString("dddd", new CultureInfo("tr-TR"));

                    // Tatil günü kontrolü
                    return izin_1 == bugununGunu || izin_2 == bugununGunu;
                }
            }
            public bool OzelGunKontrol(DateTime tarih)
            {
                using (var baglan = new MySqlConnection(dbConnectionString))
                {
                    baglan.Open();

                    // Özel gün kontrolü için SQL sorgusu
                    string sorgu = $"SELECT COUNT(*) FROM ozelgun WHERE tarih = '{tarih.ToString("yyyy-MM-dd")}'";
                    var cmd = new MySqlCommand(sorgu, baglan);

                    // Özel gün sayısını al
                    int ozelGunSayisi = Convert.ToInt32(cmd.ExecuteScalar());

                    // Veritabanı bağlantısını kapat
                    baglan.Close();

                    // Özel gün sayısı 0'dan büyükse özel gün, aksi takdirde değil
                    return ozelGunSayisi > 0;
                }
            }
            public void MesaiEkle(int sicil, string saat)
            {
                using (var baglan = new MySqlConnection(dbConnectionString))
                {
                    baglan.Open();

                    // Kullanıcıyı sorgula
                    string kullaniciSorgu = $"SELECT * FROM personel WHERE sicil_no = '{sicil}'";
                    var kullaniciCmd = new MySqlCommand(kullaniciSorgu, baglan);

                    using (var kullaniciReader = kullaniciCmd.ExecuteReader())
                    {
                        if (kullaniciReader.Read())
                        {
                            // Kullanıcıyı bulduğumuzda mesai ekleyebiliriz
                            string isim = kullaniciReader["ad"].ToString();
                            string soyisim = kullaniciReader["soyad"].ToString();

                            kullaniciReader.Close();

                            string mesaiEkleSorgu = @"INSERT INTO mesai (ad, soyad, sicil_no, tarih_saat) VALUES (@ad, @soyad, @sicil_no, @tarih_saat)";

                            var mesaiEkleCmd = new MySqlCommand(mesaiEkleSorgu, baglan);

                            // Parametreleri ekleyerek SQL sorgusunu güvenli hale getir
                            mesaiEkleCmd.Parameters.AddWithValue("@ad", isim);
                            mesaiEkleCmd.Parameters.AddWithValue("@soyad", soyisim);
                            mesaiEkleCmd.Parameters.AddWithValue("@sicil_no", sicil);
                            mesaiEkleCmd.Parameters.AddWithValue("@tarih_saat", saat);

                            // Mesai ekleyen SQL sorgusunu çalıştır
                            mesaiEkleCmd.ExecuteNonQuery();
                        }
                        else
                        {
                            // Kullanıcı bulunamadı, hata işleme yapılabilir
                        }
                    }

                    // Veritabanı bağlantısını kapat
                    baglan.Close();
                }



            }

            public bool OtoEkle()
            {
                if (Fark > 0)
                {
                    string[] saat1 = { "00:00-08:00", "08:00-16:00", "16:00-24:00" };
                    string[] saat2 = { "08:00-16:00", "09:00-17:00" };

                    List<int> siciller = new List<int>();


                    using (var baglan = new MySqlConnection(dbConnectionString))
                    {
                        baglan.Open();

                        // Kullanıcıyı sorgula
                        string listeSorgu = $"SELECT sicil_no FROM personel";
                        var kullaniciCmd = new MySqlCommand(listeSorgu, baglan);

                        using (var listeReader = kullaniciCmd.ExecuteReader())
                        {
                            while (listeReader.Read())
                            {
                                siciller.Add(Convert.ToInt32(listeReader["sicil_no"]));
                            }
                        }

                        // Veritabanı bağlantısını kapat
                        baglan.Close();
                    }


                    for (int gun = 0; gun < Fark; gun++)
                    {
                        DateTime simdi = Baslangic.AddDays(gun);
                        int vardiya1 = 0;
                        int vardiya2 = 0;
                        int vardiya3 = 0;

                        int vardiya4 = 0;
                        int vardiya5 = 0;

                        int kampusGiris = 0;
                        int kampusIci = 0;

                        if (OzelGunKontrol(simdi))
                        {
                            if (siciller.Any())
                            {
                                foreach (int sicil in siciller)
                                {
                                    if (VardiyaKontrol(sicil, simdi))
                                    {
                                        if (vardiya1 == 0)
                                        {
                                            vardiya1++;
                                            MesaiEkle(sicil, "8");
                                            VardiyaEkle(sicil, simdi, "Kampus Girisi", "00:00-08:00");
                                        }
                                        else if (vardiya2 == 0)
                                        {
                                            vardiya2++;
                                            MesaiEkle(sicil, "8");
                                            VardiyaEkle(sicil, simdi, "Kampus Girisi", "08:00-16:00");
                                        }
                                        else if (vardiya3 == 0)
                                        {
                                            vardiya3++;
                                            MesaiEkle(sicil, "8");
                                            VardiyaEkle(sicil, simdi, "Kampus Girisi", "16:00-24:00");
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (siciller.Any())
                            {
                                foreach (int sicil in siciller)
                                {
                                    if (VardiyaKontrol(sicil, simdi))
                                    {
                                        if (kampusGiris < kampusIci)
                                        {
                                            string saat = null; ;
                                            int enKucukVardiya = Math.Min(vardiya1, Math.Min(vardiya2, vardiya3));

                                            if (enKucukVardiya == vardiya1)
                                            {
                                                saat = saat1[0];
                                                vardiya1++;
                                            }
                                            else if (enKucukVardiya == vardiya2)
                                            {
                                                saat = saat1[1];
                                                vardiya2++;
                                            }
                                            else if (enKucukVardiya == vardiya3)
                                            {
                                                saat = saat1[2];
                                                vardiya3++;
                                                kampusGiris++;
                                            }

                                            VardiyaEkle(sicil, simdi, "Kampus Girisi", saat);
                                        }
                                        else
                                        {
                                            string saat = null;
                                            if (vardiya4 < vardiya5)
                                            {
                                                saat = saat2[0];
                                                vardiya4++;
                                            }
                                            else
                                            {
                                                saat = saat2[1];
                                                vardiya5++;
                                                kampusIci++;
                                            }

                                            VardiyaEkle(sicil, simdi, "Kampus Ici", saat);
                                        }
                                    }
                                }
                            }
                        }
                    }

                    return false;
                }

                return false; // Eğer Fark 0 veya negatifse, false döndürülüyor.
            }
        }
    }
}
