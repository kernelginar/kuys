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
            if (Id != "" && KitapAdi != "" && KitapYazari != "" && Kitaplik != "" && KitapRafi != "" && int.TryParse(Id, out int checkInt1) == true && int.TryParse(KitapRafi, out int checkInt2) == true)
            {
                if (checkInt1 >= 0 && checkInt2 >= 1)
                {
                    Backend.Kitap.Ekle(Id, KitapAdi, KitapYazari, Kitaplik, KitapRafi);
                    id_textbox.Text = "";
                    kitap_adi_textbox.Text = "";
                    kitap_yazari_textbox.Text = "";
                    kitaplik_combobox.Text = "A1";
                    kitap_rafi_combobox.Text = "1";
                    mainForm.VerileriYukleKitap();
                    MessageBox.Show($""" "{Id}" ID numaralı "{KitapYazari}" adlı kişiye ait "{KitapAdi}" kitabı başarıyla eklenmiştir! Kitaplık: "{Kitaplik}", Kitap Rafı: "{KitapRafi}" """);
                }
                else if (checkInt1 < 0)
                {
                    MessageBox.Show("""ID değeri "-" (eksi) değerler alamaz! Lütfen doğru ID değerini girip tekrar deneyin.""");
                }
                else if (checkInt2 < 1)
                {
                    MessageBox.Show("""Kitap Rafı değeri "1"den küçük ve "-" (eksi) değerleri alamaz! Lütfen doğru Kitap Rafı değerini girip tekrar deneyin.""");
                }
            }
            else if (Id == "")
            {
                MessageBox.Show("ID değeri boş bırakılamaz! Lütfen doğru bir ID değeri girin.");
            }
            else if (int.TryParse(Id, out int checkInt3) == false)
            {
                MessageBox.Show("Bir kaydın ID değerini Tam Sayı haricinde bir değer kullanarak tanımlayamazsınız! Lütfen doğru ID değerini girin ve tekrar deneyin.");
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
            else if (int.TryParse(KitapRafi, out int checkInt4) == false)
            {
                MessageBox.Show("Kitap Rafı değerini Tam Sayı olarak girmediniz! Kitap Rafı Tam Sayı değerleri almalıdır. Lütfen doğru Kitap Rafı değerini girin ve tekrar deneyin.");
            }
        }
    }
}