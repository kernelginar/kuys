namespace KUYS
{
    partial class KitapGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapGuncelle));
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            id_textbox = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            yeni_id_textbox = new TextBox();
            btnIDGuncelle = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            label3 = new Label();
            label4 = new Label();
            yeni_kitap_adi_textbox = new TextBox();
            yeni_kitap_yazari_textbox = new TextBox();
            btnKitapAdiGuncelle = new Button();
            btnKitapYazariGuncelle = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            label5 = new Label();
            label6 = new Label();
            yeni_kitaplik_combobox = new ComboBox();
            yeni_kitap_rafi_combobox = new ComboBox();
            btnKitaplikGuncelle = new Button();
            btnKitapRafiGuncelle = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(id_textbox, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(782, 79);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(267, 39);
            label1.TabIndex = 0;
            label1.Text = "Değiştirilecek Kitap Kaydının ID Değeri";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // id_textbox
            // 
            id_textbox.Dock = DockStyle.Fill;
            id_textbox.Location = new Point(3, 43);
            id_textbox.Margin = new Padding(3, 4, 3, 4);
            id_textbox.Name = "id_textbox";
            id_textbox.Size = new Size(776, 27);
            id_textbox.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(yeni_id_textbox, 0, 1);
            tableLayoutPanel2.Controls.Add(btnIDGuncelle, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 79);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.Size = new Size(782, 121);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Left;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(194, 40);
            label2.TabIndex = 0;
            label2.Text = "Yeni ID (En Son Güncelleyin)";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // yeni_id_textbox
            // 
            yeni_id_textbox.Dock = DockStyle.Fill;
            yeni_id_textbox.Location = new Point(3, 44);
            yeni_id_textbox.Margin = new Padding(3, 4, 3, 4);
            yeni_id_textbox.Name = "yeni_id_textbox";
            yeni_id_textbox.Size = new Size(776, 27);
            yeni_id_textbox.TabIndex = 1;
            // 
            // btnIDGuncelle
            // 
            btnIDGuncelle.Dock = DockStyle.Fill;
            btnIDGuncelle.Location = new Point(3, 84);
            btnIDGuncelle.Margin = new Padding(3, 4, 3, 4);
            btnIDGuncelle.Name = "btnIDGuncelle";
            btnIDGuncelle.Size = new Size(776, 33);
            btnIDGuncelle.TabIndex = 2;
            btnIDGuncelle.Text = "ID Güncelle";
            btnIDGuncelle.UseVisualStyleBackColor = true;
            btnIDGuncelle.Click += btnIDGuncelle_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(label3, 0, 0);
            tableLayoutPanel3.Controls.Add(label4, 1, 0);
            tableLayoutPanel3.Controls.Add(yeni_kitap_adi_textbox, 0, 1);
            tableLayoutPanel3.Controls.Add(yeni_kitap_yazari_textbox, 1, 1);
            tableLayoutPanel3.Controls.Add(btnKitapAdiGuncelle, 0, 2);
            tableLayoutPanel3.Controls.Add(btnKitapYazariGuncelle, 1, 2);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(0, 200);
            tableLayoutPanel3.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel3.Size = new Size(782, 124);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Left;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(102, 41);
            label3.TabIndex = 0;
            label3.Text = "Yeni Kitap Adı";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Left;
            label4.Location = new Point(394, 0);
            label4.Name = "label4";
            label4.Size = new Size(118, 41);
            label4.TabIndex = 1;
            label4.Text = "Yeni Kitap Yazarı";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // yeni_kitap_adi_textbox
            // 
            yeni_kitap_adi_textbox.Dock = DockStyle.Fill;
            yeni_kitap_adi_textbox.Location = new Point(3, 45);
            yeni_kitap_adi_textbox.Margin = new Padding(3, 4, 3, 4);
            yeni_kitap_adi_textbox.Name = "yeni_kitap_adi_textbox";
            yeni_kitap_adi_textbox.Size = new Size(385, 27);
            yeni_kitap_adi_textbox.TabIndex = 2;
            // 
            // yeni_kitap_yazari_textbox
            // 
            yeni_kitap_yazari_textbox.Dock = DockStyle.Fill;
            yeni_kitap_yazari_textbox.Location = new Point(394, 45);
            yeni_kitap_yazari_textbox.Margin = new Padding(3, 4, 3, 4);
            yeni_kitap_yazari_textbox.Name = "yeni_kitap_yazari_textbox";
            yeni_kitap_yazari_textbox.Size = new Size(385, 27);
            yeni_kitap_yazari_textbox.TabIndex = 3;
            // 
            // btnKitapAdiGuncelle
            // 
            btnKitapAdiGuncelle.Dock = DockStyle.Fill;
            btnKitapAdiGuncelle.Location = new Point(3, 86);
            btnKitapAdiGuncelle.Margin = new Padding(3, 4, 3, 4);
            btnKitapAdiGuncelle.Name = "btnKitapAdiGuncelle";
            btnKitapAdiGuncelle.Size = new Size(385, 34);
            btnKitapAdiGuncelle.TabIndex = 4;
            btnKitapAdiGuncelle.Text = "Kitap Adı Güncelle";
            btnKitapAdiGuncelle.UseVisualStyleBackColor = true;
            btnKitapAdiGuncelle.Click += btnKitapAdiGuncelle_Click;
            // 
            // btnKitapYazariGuncelle
            // 
            btnKitapYazariGuncelle.Dock = DockStyle.Fill;
            btnKitapYazariGuncelle.Location = new Point(394, 86);
            btnKitapYazariGuncelle.Margin = new Padding(3, 4, 3, 4);
            btnKitapYazariGuncelle.Name = "btnKitapYazariGuncelle";
            btnKitapYazariGuncelle.Size = new Size(385, 34);
            btnKitapYazariGuncelle.TabIndex = 5;
            btnKitapYazariGuncelle.Text = "Kitap Yazarı Güncelle";
            btnKitapYazariGuncelle.UseVisualStyleBackColor = true;
            btnKitapYazariGuncelle.Click += btnKitapYazariGuncelle_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(label5, 0, 0);
            tableLayoutPanel4.Controls.Add(label6, 1, 0);
            tableLayoutPanel4.Controls.Add(yeni_kitaplik_combobox, 0, 1);
            tableLayoutPanel4.Controls.Add(yeni_kitap_rafi_combobox, 1, 1);
            tableLayoutPanel4.Controls.Add(btnKitaplikGuncelle, 0, 2);
            tableLayoutPanel4.Controls.Add(btnKitapRafiGuncelle, 1, 2);
            tableLayoutPanel4.Dock = DockStyle.Top;
            tableLayoutPanel4.Location = new Point(0, 324);
            tableLayoutPanel4.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel4.Size = new Size(782, 119);
            tableLayoutPanel4.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Left;
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(90, 39);
            label5.TabIndex = 0;
            label5.Text = "Yeni Kitaplık";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Left;
            label6.Location = new Point(394, 0);
            label6.Name = "label6";
            label6.Size = new Size(105, 39);
            label6.TabIndex = 1;
            label6.Text = "Yeni Kitap Rafı";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // yeni_kitaplik_combobox
            // 
            yeni_kitaplik_combobox.Dock = DockStyle.Fill;
            yeni_kitaplik_combobox.FormattingEnabled = true;
            yeni_kitaplik_combobox.Items.AddRange(new object[] { "A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8", "A9", "A10", "B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8", "B9", "B10", "C1", "C2", "C3", "C4", "C5", "C6", "C7", "C8", "C9", "C10" });
            yeni_kitaplik_combobox.Location = new Point(3, 43);
            yeni_kitaplik_combobox.Margin = new Padding(3, 4, 3, 4);
            yeni_kitaplik_combobox.Name = "yeni_kitaplik_combobox";
            yeni_kitaplik_combobox.Size = new Size(385, 28);
            yeni_kitaplik_combobox.TabIndex = 2;
            yeni_kitaplik_combobox.Text = "A1";
            // 
            // yeni_kitap_rafi_combobox
            // 
            yeni_kitap_rafi_combobox.Dock = DockStyle.Fill;
            yeni_kitap_rafi_combobox.FormattingEnabled = true;
            yeni_kitap_rafi_combobox.Items.AddRange(new object[] { "1", "2", "3", "4" });
            yeni_kitap_rafi_combobox.Location = new Point(394, 43);
            yeni_kitap_rafi_combobox.Margin = new Padding(3, 4, 3, 4);
            yeni_kitap_rafi_combobox.Name = "yeni_kitap_rafi_combobox";
            yeni_kitap_rafi_combobox.Size = new Size(385, 28);
            yeni_kitap_rafi_combobox.TabIndex = 3;
            yeni_kitap_rafi_combobox.Text = "1";
            // 
            // btnKitaplikGuncelle
            // 
            btnKitaplikGuncelle.Dock = DockStyle.Fill;
            btnKitaplikGuncelle.Location = new Point(3, 82);
            btnKitaplikGuncelle.Margin = new Padding(3, 4, 3, 4);
            btnKitaplikGuncelle.Name = "btnKitaplikGuncelle";
            btnKitaplikGuncelle.Size = new Size(385, 33);
            btnKitaplikGuncelle.TabIndex = 4;
            btnKitaplikGuncelle.Text = "Kitaplık Güncelle";
            btnKitaplikGuncelle.UseVisualStyleBackColor = true;
            btnKitaplikGuncelle.Click += btnKitaplikGuncelle_Click;
            // 
            // btnKitapRafiGuncelle
            // 
            btnKitapRafiGuncelle.Dock = DockStyle.Fill;
            btnKitapRafiGuncelle.Location = new Point(394, 82);
            btnKitapRafiGuncelle.Margin = new Padding(3, 4, 3, 4);
            btnKitapRafiGuncelle.Name = "btnKitapRafiGuncelle";
            btnKitapRafiGuncelle.Size = new Size(385, 33);
            btnKitapRafiGuncelle.TabIndex = 5;
            btnKitapRafiGuncelle.Text = "Kitap Rafı Güncelle";
            btnKitapRafiGuncelle.UseVisualStyleBackColor = true;
            btnKitapRafiGuncelle.Click += btnKitapRafiGuncelle_Click;
            // 
            // KitapGuncelle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 443);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "KitapGuncelle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kitap Güncelle";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox id_textbox;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private TextBox yeni_id_textbox;
        private Button btnIDGuncelle;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label3;
        private Label label4;
        private TextBox yeni_kitap_adi_textbox;
        private TextBox yeni_kitap_yazari_textbox;
        private Button btnKitapAdiGuncelle;
        private Button btnKitapYazariGuncelle;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label5;
        private Label label6;
        private ComboBox yeni_kitaplik_combobox;
        private ComboBox yeni_kitap_rafi_combobox;
        private Button btnKitaplikGuncelle;
        private Button btnKitapRafiGuncelle;
    }
}