namespace KUYS
{
    partial class KitapEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapEkle));
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            id_textbox = new TextBox();
            kitap_adi_textbox = new TextBox();
            kitap_yazari_textbox = new TextBox();
            kitaplik_combobox = new ComboBox();
            kitap_rafi_combobox = new ComboBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnKitapEkle = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.8998756F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.10013F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(id_textbox, 1, 0);
            tableLayoutPanel1.Controls.Add(kitap_adi_textbox, 1, 1);
            tableLayoutPanel1.Controls.Add(kitap_yazari_textbox, 1, 2);
            tableLayoutPanel1.Controls.Add(kitaplik_combobox, 1, 3);
            tableLayoutPanel1.Controls.Add(kitap_rafi_combobox, 1, 4);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(532, 182);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(4, 1);
            label1.Name = "label1";
            label1.Size = new Size(24, 35);
            label1.TabIndex = 0;
            label1.Text = "ID";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Left;
            label2.Location = new Point(4, 37);
            label2.Name = "label2";
            label2.Size = new Size(71, 35);
            label2.TabIndex = 1;
            label2.Text = "Kitap Adı";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Left;
            label3.Location = new Point(4, 73);
            label3.Name = "label3";
            label3.Size = new Size(87, 35);
            label3.TabIndex = 2;
            label3.Text = "Kitap Yazarı";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Left;
            label4.Location = new Point(4, 109);
            label4.Name = "label4";
            label4.Size = new Size(59, 35);
            label4.TabIndex = 3;
            label4.Text = "Kitaplık";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Left;
            label5.Location = new Point(4, 145);
            label5.Name = "label5";
            label5.Size = new Size(74, 36);
            label5.TabIndex = 4;
            label5.Text = "Kitap Rafı";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // id_textbox
            // 
            id_textbox.Dock = DockStyle.Fill;
            id_textbox.Location = new Point(110, 5);
            id_textbox.Margin = new Padding(3, 4, 3, 4);
            id_textbox.Name = "id_textbox";
            id_textbox.Size = new Size(418, 27);
            id_textbox.TabIndex = 5;
            // 
            // kitap_adi_textbox
            // 
            kitap_adi_textbox.Dock = DockStyle.Fill;
            kitap_adi_textbox.Location = new Point(110, 41);
            kitap_adi_textbox.Margin = new Padding(3, 4, 3, 4);
            kitap_adi_textbox.Name = "kitap_adi_textbox";
            kitap_adi_textbox.Size = new Size(418, 27);
            kitap_adi_textbox.TabIndex = 6;
            // 
            // kitap_yazari_textbox
            // 
            kitap_yazari_textbox.Dock = DockStyle.Fill;
            kitap_yazari_textbox.Location = new Point(110, 77);
            kitap_yazari_textbox.Margin = new Padding(3, 4, 3, 4);
            kitap_yazari_textbox.Name = "kitap_yazari_textbox";
            kitap_yazari_textbox.Size = new Size(418, 27);
            kitap_yazari_textbox.TabIndex = 7;
            // 
            // kitaplik_combobox
            // 
            kitaplik_combobox.Dock = DockStyle.Fill;
            kitaplik_combobox.FormattingEnabled = true;
            kitaplik_combobox.Items.AddRange(new object[] { "A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8", "A9", "A10", "B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8", "B9", "B10", "C1", "C2", "C3", "C4", "C5", "C6", "C7", "C8", "C9", "C10" });
            kitaplik_combobox.Location = new Point(110, 113);
            kitaplik_combobox.Margin = new Padding(3, 4, 3, 4);
            kitaplik_combobox.Name = "kitaplik_combobox";
            kitaplik_combobox.Size = new Size(418, 28);
            kitaplik_combobox.TabIndex = 8;
            kitaplik_combobox.Text = "A1";
            // 
            // kitap_rafi_combobox
            // 
            kitap_rafi_combobox.Dock = DockStyle.Fill;
            kitap_rafi_combobox.FormattingEnabled = true;
            kitap_rafi_combobox.Items.AddRange(new object[] { "1", "2", "3", "4" });
            kitap_rafi_combobox.Location = new Point(110, 149);
            kitap_rafi_combobox.Margin = new Padding(3, 4, 3, 4);
            kitap_rafi_combobox.Name = "kitap_rafi_combobox";
            kitap_rafi_combobox.Size = new Size(418, 28);
            kitap_rafi_combobox.TabIndex = 9;
            kitap_rafi_combobox.Text = "1";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(btnKitapEkle, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Right;
            tableLayoutPanel2.Location = new Point(407, 182);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(125, 43);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // btnKitapEkle
            // 
            btnKitapEkle.Dock = DockStyle.Fill;
            btnKitapEkle.Location = new Point(3, 4);
            btnKitapEkle.Margin = new Padding(3, 4, 3, 4);
            btnKitapEkle.Name = "btnKitapEkle";
            btnKitapEkle.Size = new Size(119, 35);
            btnKitapEkle.TabIndex = 0;
            btnKitapEkle.Text = "Kitap Ekle";
            btnKitapEkle.UseVisualStyleBackColor = true;
            btnKitapEkle.Click += btnKitapEkle_Click;
            // 
            // KitapEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 225);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(550, 272);
            MinimumSize = new Size(550, 272);
            Name = "KitapEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kitap Ekle";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox id_textbox;
        private TextBox kitap_adi_textbox;
        private TextBox kitap_yazari_textbox;
        private ComboBox kitaplik_combobox;
        private ComboBox kitap_rafi_combobox;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnKitapEkle;
    }
}