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
    public partial class KayitSil : Form
    {
        private Main mainForm;
        public KayitSil()
        {
            InitializeComponent();
        }

        public KayitSil(Main callingForm)
        {
            InitializeComponent();
            mainForm = callingForm;
        }

        private void btnKayitSil_Click(object sender, EventArgs e)
        {
            string Id = silinecek_id_textbox.Text;
            if (Id != "" && int.TryParse(Id, out int checkInt1) == true)
            {
                if (checkInt1 >= 0)
                {
                    Backend.Kayit.Sil(Id);
                    silinecek_id_textbox.Text = "";
                    mainForm.VerileriYukleKayit();
                    MessageBox.Show($"{Id} numaralı kayıt başarıyla silindi!");
                }
                else if (checkInt1 < 0)
                {
                    MessageBox.Show("""ID değeri "-" (eksi) değerler alamaz! Lütfen doğru ID değerini girip tekrar deneyin.""");
                }
            }
            else if (Id == "")
            {
                MessageBox.Show("Silinecek ID değeri boş bırakılamaz! Lütfen doğru ID değerini girip tekrar deneyin.");
            }
            else if (int.TryParse(Id, out int checkInt2) == false)
            {
                MessageBox.Show("Silmeye çalıştığınız ID değeri Tam Sayı değil! ID değerleri Tam Sayı olmalıdır. Lütfen doğru ID değerini girip tekrar deneyin.");
            }
        }
    }
}
