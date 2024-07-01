using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backend;
using KUYS;

namespace KUYS
{
    public partial class KayitEkle : Form
    {
        private Main mainForm;

        public KayitEkle()
        {
            InitializeComponent();
        }

        public KayitEkle(Main callingForm)
        {
            InitializeComponent();
            mainForm = callingForm;
        }

        private void btnKayitEkle_Click(object sender, EventArgs e)
        {
            string Id = id_textbox.Text;
            string Ad = ad_textbox.Text;
            string Sinif = sinif_combobox.Text;
            string Numara = numara_textbox.Text;
            string KitapAdi = kitap_adi_textbox.Text;
            string KitapYazari = kitap_yazari_textbox.Text;
            string Kitaplik = kitaplik_combobox.Text;
            string KitapRafi = kitap_rafi_combobox.Text;
            string KitapAlinmaTarihi = DateTime.Now.ToString("yyyy/MM/dd - HH:mm");
            string KitapSonTeslimTarihi = kitap_son_teslim_tarihi_datepicker.Value.ToString("yyyy/MM/dd");
            string TeslimDurumu = "Etmedi";
            if (Id != "" && Ad != "" && Sinif != "" && Numara != "" && KitapAdi != "" && KitapYazari != "" && Kitaplik != "" && KitapRafi != "" && TeslimDurumu != "" && int.TryParse(Id, out int checkInt1) == true && int.TryParse(Numara, out int checkInt2) == true && int.TryParse(KitapRafi, out int checkInt3))
            {
                if (checkInt1 >= 0 && checkInt2 >= 0 && checkInt3 >= 0)
                {
                    Backend.Kayit.Ekle(Id, Ad, Sinif, Numara, KitapAdi, KitapYazari, Kitaplik, KitapRafi, KitapAlinmaTarihi, KitapSonTeslimTarihi, TeslimDurumu);
                    id_textbox.Clear();
                    ad_textbox.Clear();
                    sinif_combobox.Text = "9/A";
                    numara_textbox.Clear();
                    kitap_adi_textbox.Clear();
                    kitap_yazari_textbox.Clear();
                    kitaplik_combobox.Text = "A1";
                    kitap_rafi_combobox.Text = "1";
                    kitap_son_teslim_tarihi_datepicker.Value = DateTime.Now;
                    mainForm.VerileriYukleKayit();
                    MessageBox.Show($"""{Id} numaralı "{Ad}" isimli kayıt başarıyla eklenmiştir! Son teslim tarihi: {KitapSonTeslimTarihi}""");
                }
                else if (checkInt1 < 0)
                {
                    MessageBox.Show("""ID değeri "-" (eksi) değerler alamaz! Lütfen doğru ID değerini girip tekrar deneyin.""");
                }
                else if (checkInt2 < 0)
                {
                    MessageBox.Show("""Numara değeri "-" (eksi) değerler alamaz! Lütfen doğru Numara değerini girip tekrar deneyin.""");
                }
                else if (checkInt3 < 0)
                {
                    MessageBox.Show("""Kitap Rafı değeri "-" (eksi) değerler alamaz! Lütfen doğru Kitap Rafı değerini girin ve tekrar deneyin.""");
                }
            }
            else if (Id == "")
            {
                MessageBox.Show("ID değeri boş bırakılamaz! Lütfen doğru bir ID değeri girin.");
            }
            else if (int.TryParse(Id, out int checkInt4) == false)
            {
                MessageBox.Show("Bir kaydın ID değerini Tam Sayı haricinde bir değer kullanarak tanımlayamazsınız! Lütfen doğru ID değerini girin ve tekrar deneyin.");
            }
            else if (Ad == "")
            {
                MessageBox.Show("Bir kaydı Ad tanımlanmamış olarak kaydedemezsiniz! Lütfen doğru bir isim girip tekrar deneyin.");
            }
            else if (Sinif == "")
            {
                MessageBox.Show("""Bir kaydı Sınıf tanımlanmamış olarak kaydedemezsiniz! Eğer kaydını yaptığınız kişi Öğrenci değilse Sınıf değerini "Öğretmen" olarak girin ve devam edin.""");
            }
            else if (Numara == "")
            {
                MessageBox.Show("""Bir kaydı Numara tanımlanmamış olarak kaydedemezsiniz! Eğer kaydını yaptığınız kişi Öğrenci değilse Numara değerini "0" (sıfır) olarak girin ve devam edin.""");
            }
            else if (int.TryParse(Numara, out int checkInt5) == false)
            {
                MessageBox.Show("Tam Sayı olmayan bir Numara girmeye çalışıyorsunuz! Numaralar Tam Sayı değerlerine sahip olmalı. Lütfen doğru Numara değeri girip tekrar deneyin.");
            }
            else if (checkInt5 < 0)
            {
                MessageBox.Show("""Numara değeri "-" (eksi) değerler alamaz! Lütfen doğru Numara değerini girin ve tekrar deneyin.""");
            }
            else if (KitapAdi == "")
            {
                MessageBox.Show("""Bir kaydı Kitap Adı tanımlanmamış olarak kaydedemezsiniz! Lütfen doğru Kitap Adı değerini girin ve tekrar deneyin.""");
            }
            else if (KitapYazari == "")
            {
                MessageBox.Show("""Bir kaydı Kitap Yazarı tanımlanmamış olarak kaydedemezsiniz! Lütfen doğru Kitap Yazarı değerini girin ve tekrar deneyin.""");
            }
            else if (Kitaplik == "")
            {
                MessageBox.Show("""Bir kaydı Kitaplık tanımlanmamış olarak kaydedemezsiniz! Lütfen doğru Kitaplık değerini girin ve tekrar deneyin.""");
            }
            else if (KitapRafi == "")
            {
                MessageBox.Show("""Bir kaydı Kitap Rafı tanımlanmamış olarak kaydedemezsiniz! Lütfen doğru Kitap Rafı değerini girin ve tekrar deneyin.""");
            }
            else if (int.TryParse(KitapRafi, out int checkInt6) == false)
            {
                MessageBox.Show("Kitap Rafı değerini Tam Sayı olarak girmediniz! Kitap Rafı Tam Sayı değerleri almalıdır. Lütfen doğru Kitap Rafı değerini girin ve tekrar deneyin.");
            }
        }
    }
}