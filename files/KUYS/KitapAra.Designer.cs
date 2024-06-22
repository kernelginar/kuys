namespace KUYS
{
    partial class KitapAra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapAra));
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            kitap_sorgu_textbox = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnIDAra = new Button();
            btnKitapAdiAra = new Button();
            btnKitapYazariAra = new Button();
            btnKitaplikAra = new Button();
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
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(kitap_sorgu_textbox, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1445, 79);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(4, 1);
            label1.Name = "label1";
            label1.Size = new Size(113, 38);
            label1.TabIndex = 0;
            label1.Text = "Aranacak Sorgu";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // kitap_sorgu_textbox
            // 
            kitap_sorgu_textbox.Dock = DockStyle.Fill;
            kitap_sorgu_textbox.Location = new Point(4, 44);
            kitap_sorgu_textbox.Margin = new Padding(3, 4, 3, 4);
            kitap_sorgu_textbox.Name = "kitap_sorgu_textbox";
            kitap_sorgu_textbox.Size = new Size(1437, 27);
            kitap_sorgu_textbox.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Controls.Add(btnIDAra, 0, 0);
            tableLayoutPanel2.Controls.Add(btnKitapAdiAra, 1, 0);
            tableLayoutPanel2.Controls.Add(btnKitapYazariAra, 2, 0);
            tableLayoutPanel2.Controls.Add(btnKitaplikAra, 3, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 79);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1445, 47);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // btnIDAra
            // 
            btnIDAra.Dock = DockStyle.Fill;
            btnIDAra.Location = new Point(4, 5);
            btnIDAra.Margin = new Padding(3, 4, 3, 4);
            btnIDAra.Name = "btnIDAra";
            btnIDAra.Size = new Size(354, 37);
            btnIDAra.TabIndex = 0;
            btnIDAra.Text = "ID";
            btnIDAra.UseVisualStyleBackColor = true;
            btnIDAra.Click += btnIDAra_Click;
            // 
            // btnKitapAdiAra
            // 
            btnKitapAdiAra.Dock = DockStyle.Fill;
            btnKitapAdiAra.Location = new Point(365, 5);
            btnKitapAdiAra.Margin = new Padding(3, 4, 3, 4);
            btnKitapAdiAra.Name = "btnKitapAdiAra";
            btnKitapAdiAra.Size = new Size(354, 37);
            btnKitapAdiAra.TabIndex = 1;
            btnKitapAdiAra.Text = "Kitap Adı";
            btnKitapAdiAra.UseVisualStyleBackColor = true;
            btnKitapAdiAra.Click += btnKitapAdiAra_Click;
            // 
            // btnKitapYazariAra
            // 
            btnKitapYazariAra.Dock = DockStyle.Fill;
            btnKitapYazariAra.Location = new Point(726, 5);
            btnKitapYazariAra.Margin = new Padding(3, 4, 3, 4);
            btnKitapYazariAra.Name = "btnKitapYazariAra";
            btnKitapYazariAra.Size = new Size(354, 37);
            btnKitapYazariAra.TabIndex = 2;
            btnKitapYazariAra.Text = "Kitap Yazarı";
            btnKitapYazariAra.UseVisualStyleBackColor = true;
            btnKitapYazariAra.Click += btnKitapYazariAra_Click;
            // 
            // btnKitaplikAra
            // 
            btnKitaplikAra.Dock = DockStyle.Fill;
            btnKitaplikAra.Location = new Point(1087, 5);
            btnKitaplikAra.Margin = new Padding(3, 4, 3, 4);
            btnKitaplikAra.Name = "btnKitaplikAra";
            btnKitaplikAra.Size = new Size(354, 37);
            btnKitaplikAra.TabIndex = 3;
            btnKitaplikAra.Text = "Kitaplık";
            btnKitaplikAra.UseVisualStyleBackColor = true;
            btnKitaplikAra.Click += btnKitaplikAra_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(dataGridView1, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 126);
            tableLayoutPanel3.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(1445, 782);
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
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
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
            dataGridView1.Location = new Point(3, 4);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1439, 774);
            dataGridView1.TabIndex = 0;
            // 
            // KitapAra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1445, 908);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1460, 944);
            Name = "KitapAra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kitap Ara";
            Load += KitapAra_Load;
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
        private TextBox kitap_sorgu_textbox;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnIDAra;
        private Button btnKitapAdiAra;
        private Button btnKitapYazariAra;
        private Button btnKitaplikAra;
        private TableLayoutPanel tableLayoutPanel3;
        private DataGridView dataGridView1;
    }
}