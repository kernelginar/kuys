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
            Backend.Kayit.Sil(Id);
            silinecek_id_textbox.Text = "";
            mainForm.VerileriYukleKayit();
        }
    }
}
