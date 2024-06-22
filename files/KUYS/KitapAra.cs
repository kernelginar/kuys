using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KUYS
{
    public partial class KitapAra : Form
    {
        public KitapAra()
        {
            InitializeComponent();
            this.Load += new EventHandler(KitapAra_Load);
        }

        private void KitapAra_Load(object sender, EventArgs e)
        {
            // Stil ve tema ayarlama
            Color headerBackColor = ColorTranslator.FromHtml("#156082");
            Color headerForeColor = ColorTranslator.FromHtml("#FFFFFF");

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = headerBackColor;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = headerForeColor;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);

            dataGridView1.CellFormatting += new DataGridViewCellFormattingEventHandler(DataGridViewRenklendir);
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

        private void btnIDAra_Click(object sender, EventArgs e)
        {
            string QueryKeywords = kitap_sorgu_textbox.Text;
            try
            {
                string dbPath = "database/kutuphane.db";
                string connectionString = $"Data Source={dbPath};Version=3";
                string Category = "ID";
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    string SearchIdQuery = $"""SELECT * FROM Kitap WHERE "{Category}" LIKE '{QueryKeywords}'""";
                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(SearchIdQuery, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void btnKitapAdiAra_Click(object sender, EventArgs e)
        {
            string QueryKeywords = kitap_sorgu_textbox.Text;
            try
            {
                string dbPath = "database/kutuphane.db";
                string connectionString = $"Data Source={dbPath};Version=3";
                string Category = "Kitap Adı";
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    string SearchKitapAdiQuery = $"""SELECT * FROM Kitap WHERE "{Category}" LIKE '{QueryKeywords}%'""";
                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(SearchKitapAdiQuery, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void btnKitapYazariAra_Click(object sender, EventArgs e)
        {
            string QueryKeywords = kitap_sorgu_textbox.Text;
            try
            {
                string dbPath = "database/kutuphane.db";
                string connectionString = $"Data Source={dbPath};Version=3";
                string Category = "Kitap Yazarı";
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    string SearchKitapYazariQuery = $"""SELECT * FROM Kitap WHERE "{Category}" LIKE '{QueryKeywords}%'""";
                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(SearchKitapYazariQuery, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void btnKitaplikAra_Click(object sender, EventArgs e)
        {
            string QueryKeywords = kitap_sorgu_textbox.Text;
            try
            {
                string dbPath = "database/kutuphane.db";
                string connectionString = $"Data Source={dbPath};Version=3";
                string Category = "Kitaplık";
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    string SearchKitaplikQuery = $"""SELECT * FROM Kitap WHERE "{Category}" LIKE '{QueryKeywords}%'""";
                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(SearchKitaplikQuery, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }
    }
}
