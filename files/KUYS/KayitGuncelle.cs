using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backend;

namespace KUYS
{
    public partial class KayitGuncelle : Form
    {
        private Main mainForm;

        public KayitGuncelle()
        {
            InitializeComponent();
        }

        public KayitGuncelle(Main callingForm)
        {
            InitializeComponent();
            mainForm = callingForm;
        }

        private void btnIDGuncelle_Click(object sender, EventArgs e)
        {
            string EskiId = id_textbox.Text;
            string YeniId = yeni_id_textbox.Text;
            if (EskiId != "" && YeniId != "" && int.TryParse(EskiId, out int checkInt1) == true && int.TryParse(YeniId, out int checkInt2) == true)
            {
                if (checkInt1 >= 0 && checkInt2 >= 0)
                {
                    Backend.Kayit.Guncelle.Id(EskiId, YeniId);
                    id_textbox.Text = "";
                    yeni_id_textbox.Text = "";
                    mainForm.VerileriYukleKayit();
                    MessageBox.Show($""" "{EskiId}" numaralı kayıt ID değeri "{YeniId}" olarak değiştirildi.""");
                }
                else if (checkInt1 < 0)
                {
                    MessageBox.Show("""ID değeri "-" (eksi) değerler alamaz! Lütfen doğru ID değerini girip tekrar deneyin.""");
                }
                else if (checkInt2 < 0)
                {
                    MessageBox.Show("""ID değeri "-" (eksi) değerler alamaz! Lütfen doğru ID değerini girip tekrar deneyin.""");
                }
            }
            else if (EskiId == "" && YeniId == "")
            {
                MessageBox.Show("İki ID değerini de boş bırakamazsınız! Lütfen doğru ID değerlerini girip tekrar deneyin.");
            }
            else if (EskiId == "")
            {
                MessageBox.Show("Güncellenecek olan kaydın ID değeri boş bırakılamaz! Lütfen doğru ID değerini girip tekrar deneyin.");
            }
            else if (int.TryParse(EskiId, out int checkInt3) == false)
            {
                MessageBox.Show("Eski ID değeri Tam Sayı değil! ID değerleri Tam Sayı olmalıdır. Lütfen doğru ID değerini girip tekrar deneyin.");
            }
            else if (YeniId == "")
            {
                MessageBox.Show("Eski ID'nin yerine koymak istediğiniz Yeni ID değeri boş bırakılamaz! Lütfen doğru ID değerini girip tekrar deneyin.");
            }
            else if (int.TryParse(YeniId, out int checkInt4) == false)
            {
                MessageBox.Show("Eski ID değeri Tam Sayı değil! ID değerleri Tam Sayı olmalıdır. Lütfen doğru ID değerini girip tekrar deneyin.");
            }
        }

        private void btnAdSoyadGuncelle_Click(object sender, EventArgs e)
        {
            string Id = id_textbox.Text;
            string YeniAd = yeni_ad_textbox.Text;
            if (Id != "" && YeniAd != "" && int.TryParse(Id, out int checkInt1) == true)
            {
                if (checkInt1 >= 0)
                {
                    Backend.Kayit.Guncelle.Ad(Id, YeniAd);
                    yeni_ad_textbox.Text = "";
                    mainForm.VerileriYukleKayit();
                    MessageBox.Show($""" "{Id}" numaralı kaydın "Ad - Soyad" değeri "{YeniAd}" olarak değiştirildi.""");
                }
                else if (checkInt1 < 0)
                {
                    MessageBox.Show("""ID değeri "-" (eksi) değerler alamaz! Lütfen doğru ID değerini girip tekrar deneyin.""");
                }
            }
            else if (Id == "")
            {
                MessageBox.Show("Güncellenecek olan kaydın ID değeri boş bırakılamaz! Lütfen doğru ID değerini girip tekrar deneyin.");
            }
            else if (int.TryParse(Id, out int checkInt2) == false)
            {
                MessageBox.Show("Güncellenecek olan kaydın ID değeri Tam Sayı değil! ID değeri Tam Sayı değerleri olmalıdır. Lütfen doğru ID değerlerini girip tekrar deneyin.");
            }
            else if (YeniAd == "")
            {
                MessageBox.Show("Bir kaydı isimsiz olarak güncelleyemezsiniz! Lütfen bir isim giriniz.");
            }
        }

        private void btnSinifGuncelle_Click(object sender, EventArgs e)
        {
            string Id = id_textbox.Text;
            string YeniSinif = yeni_sinif_combobox.Text;
            if (Id != "" && YeniSinif != "" && int.TryParse(Id, out int checkInt1) == true)
            {
                if (checkInt1 >= 0)
                {
                    Backend.Kayit.Guncelle.Sinif(Id, YeniSinif);
                    yeni_sinif_combobox.Text = "9/A";
                    mainForm.VerileriYukleKayit();
                    MessageBox.Show($""" "{Id}" numaralı kaydın "Sınıf" değeri "{YeniSinif}" olarak değiştirildi.""");
                }
                else if (checkInt1 < 0)
                {
                    MessageBox.Show("""ID değeri "-" (eksi) değerler alamaz! Lütfen doğru ID değerini girip tekrar deneyin.""");
                }
            }
            else if (Id == "")
            {
                MessageBox.Show("Güncellenecek olan kaydın ID değeri boş bırakılamaz! Lütfen doğru ID değerini girip tekrar deneyin.");
            }
            else if (int.TryParse(Id, out int checkInt2) == false)
            {
                MessageBox.Show("Güncellenecek olan kaydın ID değeri Tam Sayı değil! ID değeri Tam Sayı değerleri olmalıdır. Lütfen doğru ID değerlerini girip tekrar deneyin.");
            }
            else if (YeniSinif == "")
            {
                MessageBox.Show("""Bir kaydı Sınıf tanımlanmamış olarak güncelleyemezsiniz! Kaydını yaptığınız kişi "Öğrenci" değilse "Öğretmen" sınıfına atayarak güncelleme yapın.""");
            }
        }

        private void btnNumaraGuncelle_Click(object sender, EventArgs e)
        {
            string Id = id_textbox.Text;
            string YeniNumara = yeni_numara_textbox.Text;
            if (Id != "" && YeniNumara != "" && int.TryParse(Id, out int checkInt1) == true && int.TryParse(YeniNumara, out int checkInt2) == true)
            {
                if (checkInt1 >= 0 && checkInt2 >= 0)
                {
                    Backend.Kayit.Guncelle.Numara(Id, YeniNumara);
                    yeni_numara_textbox.Text = "";
                    mainForm.VerileriYukleKayit();
                    MessageBox.Show($""" "{Id}" numaralı kaydın "Numara" değeri "{YeniNumara}" olarak değiştirildi.""");
                }
                else if (checkInt1 < 0)
                {
                    MessageBox.Show("""ID değeri "-" (eksi) değerler alamaz! Lütfen doğru ID değerini girip tekrar deneyin.""");
                }
                else if (checkInt2 < 0)
                {
                    MessageBox.Show("""Numara değeri "-" (eksi) değerler alamaz! Lütfen doğru Numara değerini girip tekrar deneyin.""");
                }
            }
            else if (Id == "")
            {
                MessageBox.Show("Güncellenecek olan kaydın ID değeri boş bırakılamaz! Lütfen doğru ID değerini girip tekrar deneyin.");
            }
            else if (int.TryParse(Id, out int checkInt3) == false)
            {
                MessageBox.Show("Güncellenecek olan kaydın ID değeri Tam Sayı değil! ID değeri Tam Sayı değerleri olmalıdır. Lütfen doğru ID değerlerini girip tekrar deneyin.");
            }
            else if (YeniNumara == "")
            {
                MessageBox.Show("Bir kaydı Numara tanımlanmamış olarak güncelleyemezsiniz! Eğer kaydını yaptığınız kişi Öğretmen ise Numara değerine 0 (Sıfır) yazarak devam edin.");
            }
            else if (int.TryParse(YeniNumara, out int checkInt4) == false)
            {
                MessageBox.Show("Tam Sayı olmayan bir Numara girişi yaptınız! Bir kaydın Numara değeri Tam Sayı olmalıdır. Lütfen doğru Numara değerini girip tekrar deneyin.");
            }
        }

        private void btnKitapAdiGuncelle_Click(object sender, EventArgs e)
        {
            string Id = id_textbox.Text;
            string YeniKitapAdi = yeni_kitap_adi_textbox.Text;
            if (Id != "" && YeniKitapAdi != "" && int.TryParse(Id, out int checkInt1) == true)
            {
                if (checkInt1 >= 0)
                {
                    Backend.Kayit.Guncelle.KitapAdi(Id, YeniKitapAdi);
                    yeni_kitap_adi_textbox.Text = "";
                    mainForm.VerileriYukleKayit();
                    MessageBox.Show($""" "{Id}" numaralı kaydın "Kitap Adı" değeri "{YeniKitapAdi}" olarak değiştirildi.""");
                }
                else if (checkInt1 < 0)
                {
                    MessageBox.Show("""ID değeri "-" (eksi) değerler alamaz! Lütfen doğru ID değerini girip tekrar deneyin.""");
                }
            }
            else if (Id == "")
            {
                MessageBox.Show("Güncellenecek olan kaydın ID değeri boş bırakılamaz! Lütfen doğru ID değerini girip tekrar deneyin.");
            }
            else if (int.TryParse(Id, out int checkInt2) == false)
            {
                MessageBox.Show("Güncellenecek olan kaydın ID değeri Tam Sayı değil! ID değeri Tam Sayı değerleri olmalıdır. Lütfen doğru ID değerlerini girip tekrar deneyin.");
            }
            else if (YeniKitapAdi == "")
            {
                MessageBox.Show("Bir kaydı Kitap Adı tanımlanmamış olarak güncelleyemezsiniz! Lütfen kitap adını doğru şekilde girip tekrar deneyin.");
            }
        }

        private void btnKitapYazariGuncelle_Click(object sender, EventArgs e)
        {
            string Id = id_textbox.Text;
            string YeniKitapYazari = yeni_kitap_yazari_textbox.Text;
            if (Id != "" && YeniKitapYazari != "" && int.TryParse(Id, out int checkInt1) == true)
            {
                if (checkInt1 >= 0)
                {
                    Backend.Kayit.Guncelle.KitapYazari(Id, YeniKitapYazari);
                    yeni_kitap_yazari_textbox.Text = "";
                    mainForm.VerileriYukleKayit();
                    MessageBox.Show($""" "{Id}" numaralı kaydın "Kitap Yazarı" değeri "{YeniKitapYazari}" olarak değiştirildi.""");
                }
                else if (checkInt1 < 0)
                {
                    MessageBox.Show("""ID değeri "-" (eksi) değerler alamaz! Lütfen doğru ID değerini girip tekrar deneyin.""");
                }
            }
            else if (Id == "")
            {
                MessageBox.Show("Güncellenecek olan kaydın ID değeri boş bırakılamaz! Lütfen doğru ID değerini girip tekrar deneyin.");
            }
            else if (int.TryParse(Id, out int checkInt2) == false)
            {
                MessageBox.Show("Güncellenecek olan kaydın ID değeri Tam Sayı değil! ID değeri Tam Sayı değerleri olmalıdır. Lütfen doğru ID değerlerini girip tekrar deneyin.");
            }
            else if (YeniKitapYazari == "")
            {
                MessageBox.Show("Bir kaydı Kitap Yazarı tanımlanmamış olarak güncelleyemezsiniz! Lütfen kitap yazarını doğru şekilde girip tekrar deneyin.");
            }
        }

        private void btnKitaplikGuncelle_Click(object sender, EventArgs e)
        {
            string Id = id_textbox.Text;
            string YeniKitaplik = yeni_kitaplik_combobox.Text;
            if (Id != "" && YeniKitaplik != "" && int.TryParse(Id, out int checkInt1) == true)
            {
                if (checkInt1 >= 0)
                {
                    Backend.Kayit.Guncelle.Kitaplik(Id, YeniKitaplik);
                    yeni_kitaplik_combobox.Text = "A1";
                    mainForm.VerileriYukleKayit();
                    MessageBox.Show($""" "{Id}" numaralı kaydın "Kitaplık" değeri "{YeniKitaplik}" olarak değiştirildi.""");
                }
                else if (checkInt1 < 0)
                {
                    MessageBox.Show("""ID değeri "-" (eksi) değerler alamaz! Lütfen doğru ID değerini girip tekrar deneyin.""");
                }
            }
            else if (Id == "")
            {
                MessageBox.Show("Güncellenecek olan kaydın ID değeri boş bırakılamaz! Lütfen doğru ID değerini girip tekrar deneyin.");
            }
            else if (int.TryParse(Id, out int checkInt2) == false)
            {
                MessageBox.Show("Güncellenecek olan kaydın ID değeri Tam Sayı değil! ID değeri Tam Sayı değerleri olmalıdır. Lütfen doğru ID değerlerini girip tekrar deneyin.");
            }
            else if (YeniKitaplik == "")
            {
                MessageBox.Show("Bir kaydı Kitaplık tanımlanmamış olarak güncelleyemezsiniz! Lütfen kitaplık değerini doğru şekilde girip tekrar deneyin.");
            }
        }

        private void btnKitapRafiGuncelle_Click(object sender, EventArgs e)
        {
            string Id = id_textbox.Text;
            string YeniKitapRafi = yeni_kitap_rafi_combobox.Text;
            if (Id != "" && YeniKitapRafi != "" && int.TryParse(Id, out int checkInt1) == true && int.TryParse(YeniKitapRafi, out int checkInt2) == true)
            {
                if (checkInt1 >= 0 && checkInt2 >= 0)
                {
                    Backend.Kayit.Guncelle.KitapRafi(Id, YeniKitapRafi);
                    yeni_kitap_rafi_combobox.Text = "1";
                    mainForm.VerileriYukleKayit();
                    MessageBox.Show($""" "{Id}" numaralı kaydın "Kitap Rafı" değeri "{YeniKitapRafi}" olarak değiştirildi.""");
                }
                else if (checkInt1 < 0)
                {
                    MessageBox.Show("""ID değeri "-" (eksi) değerler alamaz! Lütfen doğru ID değerini girip tekrar deneyin.""");
                }
                else if (checkInt2 < 0)
                {
                    MessageBox.Show("""Kitap Rafı değeri "-" (eksi) değerler alamaz! Lütfen doğru Kitap Rafı değerini girip tekrar deneyin.""");
                }
            }
            else if (Id == "")
            {
                MessageBox.Show("Güncellenecek olan kaydın ID değeri boş bırakılamaz! Lütfen doğru ID değerini girip tekrar deneyin.");
            }
            else if (int.TryParse(Id, out int checkInt3) == false)
            {
                MessageBox.Show("Güncellenecek olan kaydın ID değeri Tam Sayı değil! ID değeri Tam Sayı değerleri olmalıdır. Lütfen doğru ID değerini girip tekrar deneyin.");
            }
            else if (YeniKitapRafi == "")
            {
                MessageBox.Show("Bir kaydı Kitap Rafı tanımlanmamış olarak güncelleyemezsiniz! Lütfen kitap rafı değerini doğru şekilde girip tekrar deneyin.");
            }
            else if (int.TryParse(YeniKitapRafi, out int checkInt4) == false)
            {
                MessageBox.Show("Güncellenecek olan kaydın Kitap Rafı değeri Tam Sayı değil! Kitap Rafı değeri Tam Sayı değerleri olmalıdır. Lütfen doğru Kitap Rafı değerini girip tekrar deneyin.");
            }
        }

        private void btnSonTeslimTarihiGuncelle_Click(object sender, EventArgs e)
        {
            string Id = id_textbox.Text;
            string YeniSonTeslimTarihi = yeni_son_teslim_tarihi_datepicker.Value.ToString("yyyy/MM/dd");
            if (Id != "" && int.TryParse(Id, out int checkInt1) == true)
            {
                if (checkInt1 >= 0)
                {
                    Backend.Kayit.Guncelle.SonTeslimTarihi(Id, YeniSonTeslimTarihi);
                    yeni_son_teslim_tarihi_datepicker.Value = DateTime.Now;
                    mainForm.VerileriYukleKayit();
                    MessageBox.Show($""" "{Id}" numaralı kaydın "Kitap Son Teslim Tarihi" değeri "{YeniSonTeslimTarihi}" olarak değiştirildi.""");
                }
                else if (checkInt1 < 0)
                {
                    MessageBox.Show("""ID değeri "-" (eksi) değerler alamaz! Lütfen doğru ID değerini girip tekrar deneyin.""");
                }
            }
            else if (Id == "")
            {
                MessageBox.Show("Güncellenecek olan kaydın ID değeri boş bırakılamaz! Lütfen doğru ID değerini girip tekrar deneyin.");
            }
            else if (int.TryParse(Id, out int checkInt2) == false)
            {
                MessageBox.Show("Güncellenecek olan kaydın ID değeri Tam Sayı değil! ID değeri Tam Sayı değerleri olmalıdır. Lütfen doğru ID değerini girip tekrar deneyin.");
            }
        }

        private void btnTeslimDurumuGuncelle_Click(object sender, EventArgs e)
        {
            string Id = id_textbox.Text;
            string YeniTeslimDurumu = yeni_teslim_durumu_combobox.Text;
            if (Id != "" && YeniTeslimDurumu != "" && int.TryParse(Id, out int checkInt1) == true)
            {
                if (checkInt1 >= 0 && YeniTeslimDurumu == "Etti" | YeniTeslimDurumu == "Etmedi")
                {
                    Backend.Kayit.Guncelle.TeslimDurumu(Id, YeniTeslimDurumu);
                    yeni_teslim_durumu_combobox.Text = "";
                    mainForm.VerileriYukleKayit();
                    MessageBox.Show($""" "{Id}" numaralı kaydın "Teslim Durumu" değeri "{YeniTeslimDurumu}" olarak değiştirildi.""");
                }
                else if (checkInt1 < 0)
                {
                    MessageBox.Show("""ID değeri "-" (eksi) değerler alamaz! Lütfen doğru ID değerini girip tekrar deneyin.""");
                }
                else if (YeniTeslimDurumu != "Etti" | YeniTeslimDurumu != "Etmedi")
                {
                    MessageBox.Show("""Bir kaydın Teslim Durumu ancak "Etti/Etmedi" olarak ayarlanabilir. Farklı bir değer girmeyiniz! Lütfen doğru Teslim Durumu değerini girip tekrar deneyin.""");
                }
            }
            else if (Id == "")
            {
                MessageBox.Show("Güncellenecek olan kaydın ID değeri boş bırakılamaz! Lütfen doğru ID değerini girip tekrar deneyin.");
            }
            else if (int.TryParse(Id, out int checkInt2) == false)
            {
                MessageBox.Show("Güncellenecek olan kaydın ID değeri Tam Sayı değil! ID değeri Tam Sayı değerleri olmalıdır. Lütfen doğru ID değerini girip tekrar deneyin.");
            }
            else if (YeniTeslimDurumu == "")
            {
                MessageBox.Show("""Bir kaydı Teslim Durumu tanımlanmamış olarak güncelleyemezsiniz! Lütfen Teslim Durumu değerini "Etti/Etmedi" olarak girip tekrar deneyin.""");
            }
        }
    }
}