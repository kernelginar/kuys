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
    public partial class KitapSil : Form
    {
        private Main mainForm;
        public KitapSil()
        {
            InitializeComponent();
        }

        public KitapSil(Main callingForm)
        {
            InitializeComponent();
            mainForm = callingForm;
        }

        private void btnKitapSil_Click(object sender, EventArgs e)
        {
            string Id = silinecek_id_textbox.Text;
            Backend.Kitap.Sil(Id);

            silinecek_id_textbox.Text = "";

            mainForm.VerileriYukleKitap();
        }
    }
}
