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

        private void KayitEkle_Load(object sender, EventArgs e)
        {

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
        }
    }
}
