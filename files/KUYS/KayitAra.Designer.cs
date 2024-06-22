namespace KUYS
{
    partial class KayitAra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KayitAra));
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            kayit_sorgu_textbox = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnIDAra = new Button();
            btnAdAra = new Button();
            btnSinifAra = new Button();
            btnNumaraAra = new Button();
            btnKitapAdiAra = new Button();
            btnKitapYazariAra = new Button();
            btnKitaplikAra = new Button();
            btnTeslimDurumuAra = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(kayit_sorgu_textbox, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1445, 71);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(4, 8);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 0;
            label1.Text = "Aranacak Sorgu";
            // 
            // kayit_sorgu_textbox
            // 
            kayit_sorgu_textbox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            kayit_sorgu_textbox.Location = new Point(4, 39);
            kayit_sorgu_textbox.Name = "kayit_sorgu_textbox";
            kayit_sorgu_textbox.Size = new Size(1437, 27);
            kayit_sorgu_textbox.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tableLayoutPanel2.ColumnCount = 8;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.Controls.Add(btnIDAra, 0, 0);
            tableLayoutPanel2.Controls.Add(btnAdAra, 1, 0);
            tableLayoutPanel2.Controls.Add(btnSinifAra, 2, 0);
            tableLayoutPanel2.Controls.Add(btnNumaraAra, 3, 0);
            tableLayoutPanel2.Controls.Add(btnKitapAdiAra, 4, 0);
            tableLayoutPanel2.Controls.Add(btnKitapYazariAra, 5, 0);
            tableLayoutPanel2.Controls.Add(btnKitaplikAra, 6, 0);
            tableLayoutPanel2.Controls.Add(btnTeslimDurumuAra, 7, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 71);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1445, 43);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // btnIDAra
            // 
            btnIDAra.Dock = DockStyle.Fill;
            btnIDAra.Location = new Point(5, 5);
            btnIDAra.Name = "btnIDAra";
            btnIDAra.Size = new Size(172, 33);
            btnIDAra.TabIndex = 0;
            btnIDAra.Text = "ID";
            btnIDAra.UseVisualStyleBackColor = true;
            btnIDAra.Click += btnIDAra_Click;
            // 
            // btnAdAra
            // 
            btnAdAra.Dock = DockStyle.Fill;
            btnAdAra.Location = new Point(185, 5);
            btnAdAra.Name = "btnAdAra";
            btnAdAra.Size = new Size(172, 33);
            btnAdAra.TabIndex = 1;
            btnAdAra.Text = "Ad - Soyad";
            btnAdAra.UseVisualStyleBackColor = true;
            btnAdAra.Click += btnAdAra_Click;
            // 
            // btnSinifAra
            // 
            btnSinifAra.Dock = DockStyle.Fill;
            btnSinifAra.Location = new Point(365, 5);
            btnSinifAra.Name = "btnSinifAra";
            btnSinifAra.Size = new Size(172, 33);
            btnSinifAra.TabIndex = 2;
            btnSinifAra.Text = "Sınıf";
            btnSinifAra.UseVisualStyleBackColor = true;
            btnSinifAra.Click += btnSinifAra_Click;
            // 
            // btnNumaraAra
            // 
            btnNumaraAra.Dock = DockStyle.Fill;
            btnNumaraAra.Location = new Point(545, 5);
            btnNumaraAra.Name = "btnNumaraAra";
            btnNumaraAra.Size = new Size(172, 33);
            btnNumaraAra.TabIndex = 3;
            btnNumaraAra.Text = "Numara";
            btnNumaraAra.UseVisualStyleBackColor = true;
            btnNumaraAra.Click += btnNumaraAra_Click;
            // 
            // btnKitapAdiAra
            // 
            btnKitapAdiAra.Dock = DockStyle.Fill;
            btnKitapAdiAra.Location = new Point(725, 5);
            btnKitapAdiAra.Name = "btnKitapAdiAra";
            btnKitapAdiAra.Size = new Size(172, 33);
            btnKitapAdiAra.TabIndex = 4;
            btnKitapAdiAra.Text = "Kitap Adı";
            btnKitapAdiAra.UseVisualStyleBackColor = true;
            btnKitapAdiAra.Click += btnKitapAdiAra_Click;
            // 
            // btnKitapYazariAra
            // 
            btnKitapYazariAra.Dock = DockStyle.Fill;
            btnKitapYazariAra.Location = new Point(905, 5);
            btnKitapYazariAra.Name = "btnKitapYazariAra";
            btnKitapYazariAra.Size = new Size(172, 33);
            btnKitapYazariAra.TabIndex = 5;
            btnKitapYazariAra.Text = "Kitap Yazarı";
            btnKitapYazariAra.UseVisualStyleBackColor = true;
            btnKitapYazariAra.Click += btnKitapYazariAra_Click;
            // 
            // btnKitaplikAra
            // 
            btnKitaplikAra.Dock = DockStyle.Fill;
            btnKitaplikAra.Location = new Point(1085, 5);
            btnKitaplikAra.Name = "btnKitaplikAra";
            btnKitaplikAra.Size = new Size(172, 33);
            btnKitaplikAra.TabIndex = 6;
            btnKitaplikAra.Text = "Kitaplık";
            btnKitaplikAra.UseVisualStyleBackColor = true;
            btnKitaplikAra.Click += btnKitaplikAra_Click;
            // 
            // btnTeslimDurumuAra
            // 
            btnTeslimDurumuAra.Dock = DockStyle.Fill;
            btnTeslimDurumuAra.Location = new Point(1265, 5);
            btnTeslimDurumuAra.Name = "btnTeslimDurumuAra";
            btnTeslimDurumuAra.Size = new Size(175, 33);
            btnTeslimDurumuAra.TabIndex = 7;
            btnTeslimDurumuAra.Text = "Teslim Durumu";
            btnTeslimDurumuAra.UseVisualStyleBackColor = true;
            btnTeslimDurumuAra.Click += btnTeslimDurumuAra_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(dataGridView1, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 114);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(1445, 794);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1439, 788);
            dataGridView1.TabIndex = 0;
            // 
            // KayitAra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1445, 908);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1460, 944);
            Name = "KayitAra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kayıt Ara";
            Load += KayitAra_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox kayit_sorgu_textbox;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnIDAra;
        private Button btnAdAra;
        private Button btnSinifAra;
        private Button btnNumaraAra;
        private Button btnKitapAdiAra;
        private Button btnKitapYazariAra;
        private Button btnKitaplikAra;
        private Button btnTeslimDurumuAra;
        private TableLayoutPanel tableLayoutPanel3;
        private DataGridView dataGridView1;
    }
}