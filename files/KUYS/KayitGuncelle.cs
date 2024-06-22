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
            Backend.Kayit.Guncelle.Id(EskiId, YeniId);
            id_textbox.Text = "";
            yeni_id_textbox.Text = "";
            mainForm.VerileriYukleKayit();
        }

        private void btnAdSoyadGuncelle_Click(object sender, EventArgs e)
        {
            string Id = id_textbox.Text;
            string YeniAd = yeni_ad_textbox.Text;
            Backend.Kayit.Guncelle.Ad(Id, YeniAd);
            yeni_ad_textbox.Text = "";
            mainForm.VerileriYukleKayit();
        }

        private void btnSinifGuncelle_Click(object sender, EventArgs e)
        {
            string Id = id_textbox.Text;
            string YeniSinif = yeni_sinif_combobox.Text;
            Backend.Kayit.Guncelle.Sinif(Id, YeniSinif);
            yeni_sinif_combobox.Text = "9/A";
            mainForm.VerileriYukleKayit();
        }

        private void btnNumaraGuncelle_Click(object sender, EventArgs e)
        {
            string Id = id_textbox.Text;
            string YeniNumara = yeni_numara_textbox.Text;
            Backend.Kayit.Guncelle.Numara(Id, YeniNumara);
            yeni_numara_textbox.Text = "";
            mainForm.VerileriYukleKayit();
        }

        private void btnKitapAdiGuncelle_Click(object sender, EventArgs e)
        {
            string Id = id_textbox.Text;
            string YeniKitapAdi = yeni_kitap_adi_textbox.Text;
            Backend.Kayit.Guncelle.KitapAdi(Id, YeniKitapAdi);
            yeni_kitap_adi_textbox.Text = "";
            mainForm.VerileriYukleKayit();
        }

        private void btnKitapYazariGuncelle_Click(object sender, EventArgs e)
        {
            string Id = id_textbox.Text;
            string YeniKitapYazari = yeni_kitap_yazari_textbox.Text;
            Backend.Kayit.Guncelle.KitapYazari(Id, YeniKitapYazari);
            yeni_kitap_yazari_textbox.Text = "";
            mainForm.VerileriYukleKayit();
        }

        private void btnKitaplikGuncelle_Click(object sender, EventArgs e)
        {
            string Id = id_textbox.Text;
            string YeniKitaplik = yeni_kitaplik_combobox.Text;
            Backend.Kayit.Guncelle.Kitaplik(Id, YeniKitaplik);
            yeni_kitaplik_combobox.Text = "A1";
            mainForm.VerileriYukleKayit();
        }

        private void btnKitapRafiGuncelle_Click(object sender, EventArgs e)
        {
            string Id = id_textbox.Text;
            string YeniKitapRafi = yeni_kitap_rafi_combobox.Text;
            Backend.Kayit.Guncelle.KitapRafi(Id, YeniKitapRafi);
            yeni_kitap_rafi_combobox.Text = "1";
            mainForm.VerileriYukleKayit();
        }

        private void btnSonTeslimTarihiGuncelle_Click(object sender, EventArgs e)
        {
            string Id = id_textbox.Text;
            string YeniSonTeslimTarihi = yeni_son_teslim_tarihi_datepicker.Value.ToString("yyyy/MM/dd");
            Backend.Kayit.Guncelle.SonTeslimTarihi(Id, YeniSonTeslimTarihi);
            yeni_son_teslim_tarihi_datepicker.Value = DateTime.Now;
            mainForm.VerileriYukleKayit();
        }

        private void btnTeslimDurumuGuncelle_Click(object sender, EventArgs e)
        {
            string Id = id_textbox.Text;
            string YeniTeslimDurumu = yeni_teslim_durumu_combobox.Text;
            Backend.Kayit.Guncelle.TeslimDurumu(Id, YeniTeslimDurumu);
            yeni_teslim_durumu_combobox.Text = "";
            mainForm.VerileriYukleKayit();
        }
    }
}
