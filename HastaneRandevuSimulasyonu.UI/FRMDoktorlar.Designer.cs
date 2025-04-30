namespace HastaneRandevuSimulasyonu.UI
{
    partial class FRMDoktorlar
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
            groupBox1 = new GroupBox();
            mtxtDoktorTelefon = new MaskedTextBox();
            cbBolum = new ComboBox();
            txtDoktorSoyad = new TextBox();
            txtDoktorAd = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            btnDoktorEkle = new Button();
            btnDoktorSil = new Button();
            btnGec = new Button();
            dgvDoktorlar = new DataGridView();
            btnDoktorGuncelle = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDoktorlar).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(mtxtDoktorTelefon);
            groupBox1.Controls.Add(cbBolum);
            groupBox1.Controls.Add(txtDoktorSoyad);
            groupBox1.Controls.Add(txtDoktorAd);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(56, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(384, 211);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Doktor Bilgileri";
            // 
            // mtxtDoktorTelefon
            // 
            mtxtDoktorTelefon.Location = new Point(111, 118);
            mtxtDoktorTelefon.Name = "mtxtDoktorTelefon";
            mtxtDoktorTelefon.Size = new Size(251, 31);
            mtxtDoktorTelefon.TabIndex = 2;
            // 
            // cbBolum
            // 
            cbBolum.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBolum.FormattingEnabled = true;
            cbBolum.Location = new Point(111, 156);
            cbBolum.Name = "cbBolum";
            cbBolum.Size = new Size(252, 33);
            cbBolum.TabIndex = 3;
            // 
            // txtDoktorSoyad
            // 
            txtDoktorSoyad.Location = new Point(111, 76);
            txtDoktorSoyad.Name = "txtDoktorSoyad";
            txtDoktorSoyad.Size = new Size(253, 31);
            txtDoktorSoyad.TabIndex = 1;
            // 
            // txtDoktorAd
            // 
            txtDoktorAd.Location = new Point(111, 36);
            txtDoktorAd.Name = "txtDoktorAd";
            txtDoktorAd.Size = new Size(253, 31);
            txtDoktorAd.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 162);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(66, 25);
            label4.TabIndex = 0;
            label4.Text = "Bölüm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 80);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 0;
            label2.Text = "Soyad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 121);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(73, 25);
            label3.TabIndex = 0;
            label3.Text = "Telefon";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 39);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(35, 25);
            label1.TabIndex = 0;
            label1.Text = "Ad";
            // 
            // btnDoktorEkle
            // 
            btnDoktorEkle.Location = new Point(81, 258);
            btnDoktorEkle.Name = "btnDoktorEkle";
            btnDoktorEkle.Size = new Size(101, 43);
            btnDoktorEkle.TabIndex = 1;
            btnDoktorEkle.Text = "Ekle";
            btnDoktorEkle.UseVisualStyleBackColor = true;
            btnDoktorEkle.Click += btnDoktorEkle_Click;
            // 
            // btnDoktorSil
            // 
            btnDoktorSil.Location = new Point(199, 258);
            btnDoktorSil.Name = "btnDoktorSil";
            btnDoktorSil.Size = new Size(101, 43);
            btnDoktorSil.TabIndex = 2;
            btnDoktorSil.Text = "Sil";
            btnDoktorSil.UseVisualStyleBackColor = true;
            btnDoktorSil.Click += btnDoktorSil_Click;
            // 
            // btnGec
            // 
            btnGec.Location = new Point(954, 626);
            btnGec.Name = "btnGec";
            btnGec.Size = new Size(101, 43);
            btnGec.TabIndex = 4;
            btnGec.Text = "Geç";
            btnGec.UseVisualStyleBackColor = true;
            btnGec.Click += btnGec_Click;
            // 
            // dgvDoktorlar
            // 
            dgvDoktorlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDoktorlar.Location = new Point(56, 325);
            dgvDoktorlar.Name = "dgvDoktorlar";
            dgvDoktorlar.RowHeadersWidth = 51;
            dgvDoktorlar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDoktorlar.Size = new Size(999, 291);
            dgvDoktorlar.TabIndex = 3;
            dgvDoktorlar.CellClick += dgvDoktorlar_CellClick;
            // 
            // btnDoktorGuncelle
            // 
            btnDoktorGuncelle.Location = new Point(319, 258);
            btnDoktorGuncelle.Name = "btnDoktorGuncelle";
            btnDoktorGuncelle.Size = new Size(101, 43);
            btnDoktorGuncelle.TabIndex = 3;
            btnDoktorGuncelle.Text = "Güncelle";
            btnDoktorGuncelle.UseVisualStyleBackColor = true;
            btnDoktorGuncelle.Click += btnDoktorGuncelle_Click;
            // 
            // FRMDoktorlar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 689);
            Controls.Add(dgvDoktorlar);
            Controls.Add(btnGec);
            Controls.Add(btnDoktorGuncelle);
            Controls.Add(btnDoktorSil);
            Controls.Add(btnDoktorEkle);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "FRMDoktorlar";
            Text = "FRMDoktorlar";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDoktorlar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtDoktorSoyad;
        private TextBox txtDoktorAd;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label label1;
        private ComboBox cbBolum;
        private Button btnDoktorEkle;
        private Button btnDoktorSil;
        private Button btnGec;
        private DataGridView dgvDoktorlar;
        private Button btnDoktorGuncelle;
        private MaskedTextBox mtxtDoktorTelefon;
    }
}