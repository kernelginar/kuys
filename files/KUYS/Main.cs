using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;

namespace KUYS
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
            this.Load += new EventHandler(Main_Load);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // Stil ve tema ayarlama
            Color headerBackColor = ColorTranslator.FromHtml("#156082");
            Color headerForeColor = ColorTranslator.FromHtml("#FFFFFF");

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = headerBackColor;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = headerForeColor;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);

            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = headerBackColor;
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = headerForeColor;
            dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);

            dataGridView1.CellFormatting += new DataGridViewCellFormattingEventHandler(DataGridViewRenklendir);
            dataGridView2.CellFormatting += new DataGridViewCellFormattingEventHandler(DataGridViewRenklendir);
            VerileriYukleKayit();
            VerileriYukleKitap();
        }

        public void VerileriYukleKayit()
        {
            string dbPath = "database/kutuphane.db";
            string connectionString = $"Data Source={dbPath};Version=3";
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    string Query = "SELECT * FROM Kayıt";
                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(Query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void VerileriYukleKitap()
        {
            string dbPath = "database/kutuphane.db";
            string connectionString = $"Data Source={dbPath};Version=3";
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    string Query = "SELECT * FROM Kitap";
                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(Query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView2.DataSource = dataTable;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void DataGridViewRenklendir(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Color cellBackColor1 = ColorTranslator.FromHtml("#c0e6f5");
            Color cellForeColor1 = ColorTranslator.FromHtml("#000000");

            Color cellBackColor2 = ColorTranslator.FromHtml("#ffffff");
            Color cellForeColor2 = ColorTranslator.FromHtml("#000000");

            // Alternatif satırları renklendirme
            if (e.RowIndex % 2 == 0)
            {
                e.CellStyle.BackColor = cellBackColor1;
                e.CellStyle.ForeColor = cellForeColor1;
            }
            else
            {
                e.CellStyle.BackColor = cellBackColor2;
                e.CellStyle.ForeColor = cellForeColor2;
            }
        }

        private void btnKayitAra_Click(object sender, EventArgs e)
        {
            KayitAra kayitAra = new KayitAra();
            kayitAra.Show();
        }

        private void btnKayitEkle_Click(object sender, EventArgs e)
        {
            KayitEkle kayitEkle = new KayitEkle(this);
            kayitEkle.Show();
        }

        private void btnKayitGuncelle_Click(object sender, EventArgs e)
        {
            KayitGuncelle kayitGuncelle = new KayitGuncelle(this);
            kayitGuncelle.Show();
        }

        private void btnKayitSil_Click(object sender, EventArgs e)
        {
            KayitSil kayitSil = new KayitSil(this);
            kayitSil.Show();
        }

        private void btnKitapAra_Click(object sender, EventArgs e)
        {
            KitapAra kitapAra = new KitapAra();
            kitapAra.Show();
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            KitapEkle kitapEkle = new KitapEkle(this);
            kitapEkle.Show();
        }

        private void btnKitapSil_Click(object sender, EventArgs e)
        {
            KitapSil kitapSil = new KitapSil(this);
            kitapSil.Show();
        }

        private void btnKitapGuncelle_Click(object sender, EventArgs e)
        {
            KitapGuncelle kitapGuncelle = new KitapGuncelle(this);
            kitapGuncelle.Show();
        }
    }
}