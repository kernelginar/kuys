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
    public partial class KitapEkle : Form
    {
        private Main mainForm;
        public KitapEkle()
        {
            InitializeComponent();
        }

        public KitapEkle(Main callingForm)
        {
            InitializeComponent();
            mainForm = callingForm;
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            string Id = id_textbox.Text;
            string KitapAdi = kitap_adi_textbox.Text;
            string KitapYazari = kitap_yazari_textbox.Text;
            string Kitaplik = kitaplik_combobox.Text;
            string KitapRafi = kitap_rafi_combobox.Text;
            Backend.Kitap.Ekle(Id, KitapAdi, KitapYazari, Kitaplik, KitapRafi);

            id_textbox.Text = "";
            kitap_adi_textbox.Text = "";
            kitap_yazari_textbox.Text = "";
            kitaplik_combobox.Text = "A1";
            kitap_rafi_combobox.Text = "1";

            mainForm.VerileriYukleKitap();
        }
    }
}
