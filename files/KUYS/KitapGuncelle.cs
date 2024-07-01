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
    public partial class KitapGuncelle : Form
    {
        private Main mainForm;

        public KitapGuncelle()
        {
            InitializeComponent();
        }

        public KitapGuncelle(Main callingForm)
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
                    Backend.Kitap.Guncelle.Id(EskiId, YeniId);
                    id_textbox.Text = "";
                    yeni_id_textbox.Text = "";
                    mainForm.VerileriYukleKitap();
                    MessageBox.Show($""" "{EskiId}" numaralı kitap kaydının ID değeri "{YeniId}" olarak değiştirildi.""");
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
                MessageBox.Show("Güncellenecek olan kitap kaydının ID değeri boş bırakılamaz! Lütfen doğru ID değerini girip tekrar deneyin.");
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

        private void btnKitapAdiGuncelle_Click(object sender, EventArgs e)
        {
            string Id = id_textbox.Text;
            string YeniKitapAdi = yeni_kitap_adi_textbox.Text;
            if (Id != "" && YeniKitapAdi != "" && int.TryParse(Id, out int checkInt1) == true)
            {
                if (checkInt1 >= 0)
                {
                    Backend.Kitap.Guncelle.KitapAdi(Id, YeniKitapAdi);
                    yeni_kitap_adi_textbox.Text = "";
                    mainForm.VerileriYukleKitap();
                    MessageBox.Show($""" "{Id}" numaralı kitap kaydının "Kitap Adı" değeri "{YeniKitapAdi}" olarak değiştirildi.""");
                }
                else if (checkInt1 < 0)
                {
                    MessageBox.Show("""ID değeri "-" (eksi) değerler alamaz! Lütfen doğru ID değerini girip tekrar deneyin.""");
                }
            }
            else if (Id == "")
            {
                MessageBox.Show("Güncellenecek olan kitap kaydının ID değeri boş bırakılamaz! Lütfen doğru ID değerini girip tekrar deneyin.");
            }
            else if (int.TryParse(Id, out int checkInt2) == false)
            {
                MessageBox.Show("Güncellenecek olan kitap kaydının ID değeri Tam Sayı değil! ID değeri Tam Sayı değerleri olmalıdır. Lütfen doğru ID değerlerini girip tekrar deneyin.");
            }
            else if (YeniKitapAdi == "")
            {
                MessageBox.Show("Bir kitap kaydını Kitap Adı tanımlanmamış olarak güncelleyemezsiniz! Lütfen kitap adını doğru şekilde girip tekrar deneyin.");
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
                    Backend.Kitap.Guncelle.KitapYazari(Id, YeniKitapYazari);
                    yeni_kitap_yazari_textbox.Text = "";
                    mainForm.VerileriYukleKitap();
                    MessageBox.Show($""" "{Id}" numaralı kitap kaydının "Kitap Yazarı" değeri "{YeniKitapYazari}" olarak değiştirildi.""");
                }
                else if (checkInt1 < 0)
                {
                    MessageBox.Show("""ID değeri "-" (eksi) değerler alamaz! Lütfen doğru ID değerini girip tekrar deneyin.""");
                }
            }
            else if (Id == "")
            {
                MessageBox.Show("Güncellenecek olan kitap kaydının ID değeri boş bırakılamaz! Lütfen doğru ID değerini girip tekrar deneyin.");
            }
            else if (int.TryParse(Id, out int checkInt2) == false)
            {
                MessageBox.Show("Güncellenecek olan kitap kaydının ID değeri Tam Sayı değil! ID değeri Tam Sayı değerleri olmalıdır. Lütfen doğru ID değerlerini girip tekrar deneyin.");
            }
            else if (YeniKitapYazari == "")
            {
                MessageBox.Show("Bir kitap kaydını Kitap Yazarı tanımlanmamış olarak güncelleyemezsiniz! Lütfen kitap yazarını doğru şekilde girip tekrar deneyin.");
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
                    Backend.Kitap.Guncelle.Kitaplik(Id, YeniKitaplik);
                    yeni_kitaplik_combobox.Text = "A1";
                    mainForm.VerileriYukleKitap();
                    MessageBox.Show($""" "{Id}" numaralı kitap kaydının "Kitaplık" değeri "{YeniKitaplik}" olarak değiştirildi.""");
                }
                else if (checkInt1 < 0)
                {
                    MessageBox.Show("""ID değeri "-" (eksi) değerler alamaz! Lütfen doğru ID değerini girip tekrar deneyin.""");
                }
            }
            else if (Id == "")
            {
                MessageBox.Show("Güncellenecek olan kitap kaydının ID değeri boş bırakılamaz! Lütfen doğru ID değerini girip tekrar deneyin.");
            }
            else if (int.TryParse(Id, out int checkInt2) == false)
            {
                MessageBox.Show("Güncellenecek olan kitap kaydının ID değeri Tam Sayı değil! ID değeri Tam Sayı değerleri olmalıdır. Lütfen doğru ID değerlerini girip tekrar deneyin.");
            }
            else if (YeniKitaplik == "")
            {
                MessageBox.Show("Bir kitap kaydını Kitaplık tanımlanmamış olarak güncelleyemezsiniz! Lütfen kitaplık değerini doğru şekilde girip tekrar deneyin.");
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
                    Backend.Kitap.Guncelle.KitapRafi(Id, YeniKitapRafi);
                    yeni_kitap_rafi_combobox.Text = "1";
                    mainForm.VerileriYukleKitap();
                    MessageBox.Show($""" "{Id}" numaralı kitap kaydının "Kitap Rafı" değeri "{YeniKitapRafi}" olarak değiştirildi.""");
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
                MessageBox.Show("Güncellenecek olan kitap kaydının ID değeri boş bırakılamaz! Lütfen doğru ID değerini girip tekrar deneyin.");
            }
            else if (int.TryParse(Id, out int checkInt3) == false)
            {
                MessageBox.Show("Güncellenecek olan kitap kaydının ID değeri Tam Sayı değil! ID değeri Tam Sayı değerleri olmalıdır. Lütfen doğru ID değerini girip tekrar deneyin.");
            }
            else if (YeniKitapRafi == "")
            {
                MessageBox.Show("Bir kitap kaydını Kitap Rafı tanımlanmamış olarak güncelleyemezsiniz! Lütfen kitap rafı değerini doğru şekilde girip tekrar deneyin.");
            }
            else if (int.TryParse(YeniKitapRafi, out int checkInt4) == false)
            {
                MessageBox.Show("Güncellenecek olan kitap kaydının Kitap Rafı değeri Tam Sayı değil! Kitap Rafı değeri Tam Sayı değerleri olmalıdır. Lütfen doğru Kitap Rafı değerini girip tekrar deneyin.");
            }
        }
    }
}
