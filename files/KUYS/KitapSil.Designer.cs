namespace KUYS
{
    partial class KitapSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapSil));
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            silinecek_id_textbox = new TextBox();
            btnKitapSil = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(silinecek_id_textbox, 0, 1);
            tableLayoutPanel1.Controls.Add(btnKitapSil, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Size = new Size(339, 92);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(4, 1);
            label1.Name = "label1";
            label1.Size = new Size(143, 29);
            label1.TabIndex = 0;
            label1.Text = "Silinecek Kaydın ID Değeri";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // silinecek_id_textbox
            // 
            silinecek_id_textbox.Dock = DockStyle.Fill;
            silinecek_id_textbox.Location = new Point(4, 34);
            silinecek_id_textbox.Name = "silinecek_id_textbox";
            silinecek_id_textbox.Size = new Size(331, 23);
            silinecek_id_textbox.TabIndex = 1;
            // 
            // btnKitapSil
            // 
            btnKitapSil.Dock = DockStyle.Fill;
            btnKitapSil.Location = new Point(4, 64);
            btnKitapSil.Name = "btnKitapSil";
            btnKitapSil.Size = new Size(331, 24);
            btnKitapSil.TabIndex = 2;
            btnKitapSil.Text = "Kitap Sil";
            btnKitapSil.UseVisualStyleBackColor = true;
            btnKitapSil.Click += btnKitapSil_Click;
            // 
            // KitapSil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 93);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(355, 132);
            MinimumSize = new Size(355, 132);
            Name = "KitapSil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kitap Sil";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox silinecek_id_textbox;
        private Button btnKitapSil;
    }
}