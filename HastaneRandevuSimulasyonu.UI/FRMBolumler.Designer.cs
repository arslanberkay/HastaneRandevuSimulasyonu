namespace HastaneRandevuSimulasyonu.UI
{
    partial class FRMBolumler
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
            label1 = new Label();
            label2 = new Label();
            txtBolumAdi = new TextBox();
            txtBolumAciklamasi = new TextBox();
            btnBolumEkle = new Button();
            btnBolumSil = new Button();
            btnBolumGuncelle = new Button();
            dgvBolumler = new DataGridView();
            groupBox1 = new GroupBox();
            btnGec = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBolumler).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 45);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(35, 25);
            label1.TabIndex = 0;
            label1.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 81);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 0;
            label2.Text = "Açıklama";
            // 
            // txtBolumAdi
            // 
            txtBolumAdi.Location = new Point(118, 39);
            txtBolumAdi.Name = "txtBolumAdi";
            txtBolumAdi.Size = new Size(270, 31);
            txtBolumAdi.TabIndex = 0;
            // 
            // txtBolumAciklamasi
            // 
            txtBolumAciklamasi.Location = new Point(118, 81);
            txtBolumAciklamasi.Multiline = true;
            txtBolumAciklamasi.Name = "txtBolumAciklamasi";
            txtBolumAciklamasi.Size = new Size(270, 91);
            txtBolumAciklamasi.TabIndex = 1;
            // 
            // btnBolumEkle
            // 
            btnBolumEkle.Location = new Point(66, 229);
            btnBolumEkle.Name = "btnBolumEkle";
            btnBolumEkle.Size = new Size(110, 43);
            btnBolumEkle.TabIndex = 1;
            btnBolumEkle.Text = "Ekle";
            btnBolumEkle.UseVisualStyleBackColor = true;
            btnBolumEkle.Click += btnBolumEkle_Click;
            // 
            // btnBolumSil
            // 
            btnBolumSil.Location = new Point(196, 229);
            btnBolumSil.Name = "btnBolumSil";
            btnBolumSil.Size = new Size(110, 43);
            btnBolumSil.TabIndex = 2;
            btnBolumSil.Text = "Sil";
            btnBolumSil.UseVisualStyleBackColor = true;
            btnBolumSil.Click += btnBolumSil_Click;
            // 
            // btnBolumGuncelle
            // 
            btnBolumGuncelle.Location = new Point(336, 229);
            btnBolumGuncelle.Name = "btnBolumGuncelle";
            btnBolumGuncelle.Size = new Size(110, 43);
            btnBolumGuncelle.TabIndex = 3;
            btnBolumGuncelle.Text = "Güncelle";
            btnBolumGuncelle.UseVisualStyleBackColor = true;
            btnBolumGuncelle.Click += btnBolumGuncelle_Click;
            // 
            // dgvBolumler
            // 
            dgvBolumler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBolumler.Location = new Point(43, 289);
            dgvBolumler.Name = "dgvBolumler";
            dgvBolumler.RowHeadersWidth = 51;
            dgvBolumler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBolumler.Size = new Size(878, 269);
            dgvBolumler.TabIndex = 3;
            dgvBolumler.CellClick += dgvBolumler_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtBolumAciklamasi);
            groupBox1.Controls.Add(txtBolumAdi);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(43, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(416, 185);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bölüm Bilgileri";
            // 
            // btnGec
            // 
            btnGec.Location = new Point(811, 564);
            btnGec.Name = "btnGec";
            btnGec.Size = new Size(110, 43);
            btnGec.TabIndex = 4;
            btnGec.Text = "Geç";
            btnGec.UseVisualStyleBackColor = true;
            btnGec.Click += btnGec_Click;
            // 
            // FRMBolumler
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 639);
            Controls.Add(groupBox1);
            Controls.Add(dgvBolumler);
            Controls.Add(btnGec);
            Controls.Add(btnBolumGuncelle);
            Controls.Add(btnBolumSil);
            Controls.Add(btnBolumEkle);
            Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "FRMBolumler";
            Text = "FRMBolumler";
            ((System.ComponentModel.ISupportInitialize)dgvBolumler).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtBolumAdi;
        private TextBox txtBolumAciklamasi;
        private Button btnBolumEkle;
        private Button btnBolumSil;
        private Button btnBolumGuncelle;
        private DataGridView dgvBolumler;
        private GroupBox groupBox1;
        private Button btnGec;
    }
}