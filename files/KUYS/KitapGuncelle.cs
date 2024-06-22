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
            Backend.Kitap.Guncelle.Id(EskiId, YeniId);

            id_textbox.Text = "";
            yeni_id_textbox.Text = "";

            mainForm.VerileriYukleKitap();
        }

        private void btnKitapAdiGuncelle_Click(object sender, EventArgs e)
        {
            string Id = id_textbox.Text;
            string YeniKitapAdi = yeni_kitap_adi_textbox.Text;
            Backend.Kitap.Guncelle.KitapAdi(Id, YeniKitapAdi);

            yeni_kitap_adi_textbox.Text = "";

            mainForm.VerileriYukleKitap();
        }

        private void btnKitapYazariGuncelle_Click(object sender, EventArgs e)
        {
            string Id = id_textbox.Text;
            string YeniKitapYazari = yeni_kitap_yazari_textbox.Text;
            Backend.Kitap.Guncelle.KitapYazari(Id, YeniKitapYazari);

            yeni_kitap_yazari_textbox.Text = "";

            mainForm.VerileriYukleKitap();
        }

        private void btnKitaplikGuncelle_Click(object sender, EventArgs e)
        {
            string Id = id_textbox.Text;
            string YeniKitaplik = yeni_kitaplik_combobox.Text;
            Backend.Kitap.Guncelle.Kitaplik(Id, YeniKitaplik);

            yeni_kitaplik_combobox.Text = "A1";

            mainForm.VerileriYukleKitap();
        }

        private void btnKitapRafiGuncelle_Click(object sender, EventArgs e)
        {
            string Id = id_textbox.Text;
            string YeniKitapRafi = yeni_kitap_rafi_combobox.Text;
            Backend.Kitap.Guncelle.KitapRafi(Id, YeniKitapRafi);

            yeni_kitap_rafi_combobox.Text = "1";

            mainForm.VerileriYukleKitap();
        }
    }
}
