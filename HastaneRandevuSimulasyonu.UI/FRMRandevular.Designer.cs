namespace HastaneRandevuSimulasyonu.UI
{
    partial class FRMRandevular
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
            groupBox1 = new GroupBox();
            cbDoktorlar = new ComboBox();
            dtpRandevuTarih = new DateTimePicker();
            txtHastaSikayet = new TextBox();
            txtHastaSoyad = new TextBox();
            txtHastaAd = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnRandevuAl = new Button();
            dgvRandevular = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRandevular).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 44);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 0;
            label1.Text = "Hasta Ad";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbDoktorlar);
            groupBox1.Controls.Add(dtpRandevuTarih);
            groupBox1.Controls.Add(txtHastaSikayet);
            groupBox1.Controls.Add(txtHastaSoyad);
            groupBox1.Controls.Add(txtHastaAd);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(62, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(468, 252);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Randevu Bilgileri";
            // 
            // cbDoktorlar
            // 
            cbDoktorlar.FormattingEnabled = true;
            cbDoktorlar.Location = new Point(155, 126);
            cbDoktorlar.Name = "cbDoktorlar";
            cbDoktorlar.Size = new Size(295, 33);
            cbDoktorlar.TabIndex = 2;
            // 
            // dtpRandevuTarih
            // 
            dtpRandevuTarih.Location = new Point(155, 212);
            dtpRandevuTarih.Name = "dtpRandevuTarih";
            dtpRandevuTarih.Size = new Size(295, 31);
            dtpRandevuTarih.TabIndex = 4;
            // 
            // txtHastaSikayet
            // 
            txtHastaSikayet.Location = new Point(155, 170);
            txtHastaSikayet.Name = "txtHastaSikayet";
            txtHastaSikayet.Size = new Size(295, 31);
            txtHastaSikayet.TabIndex = 3;
            // 
            // txtHastaSoyad
            // 
            txtHastaSoyad.Location = new Point(155, 84);
            txtHastaSoyad.Name = "txtHastaSoyad";
            txtHastaSoyad.Size = new Size(295, 31);
            txtHastaSoyad.TabIndex = 1;
            // 
            // txtHastaAd
            // 
            txtHastaAd.Location = new Point(155, 42);
            txtHastaAd.Name = "txtHastaAd";
            txtHastaAd.Size = new Size(295, 31);
            txtHastaAd.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 87);
            label5.Name = "label5";
            label5.Size = new Size(113, 25);
            label5.TabIndex = 0;
            label5.Text = "Hasta Soyad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 216);
            label4.Name = "label4";
            label4.Size = new Size(128, 25);
            label4.TabIndex = 0;
            label4.Text = "Randevu Tarih";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 130);
            label2.Name = "label2";
            label2.Size = new Size(70, 25);
            label2.TabIndex = 0;
            label2.Text = "Doktor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 173);
            label3.Name = "label3";
            label3.Size = new Size(71, 25);
            label3.TabIndex = 0;
            label3.Text = "Şikayet";
            // 
            // btnRandevuAl
            // 
            btnRandevuAl.Location = new Point(217, 286);
            btnRandevuAl.Name = "btnRandevuAl";
            btnRandevuAl.Size = new Size(295, 54);
            btnRandevuAl.TabIndex = 2;
            btnRandevuAl.Text = "Randevu Al";
            btnRandevuAl.UseVisualStyleBackColor = true;
            btnRandevuAl.Click += btnRandevuAl_Click;
            // 
            // dgvRandevular
            // 
            dgvRandevular.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRandevular.Location = new Point(62, 355);
            dgvRandevular.Name = "dgvRandevular";
            dgvRandevular.RowHeadersWidth = 51;
            dgvRandevular.Size = new Size(1203, 238);
            dgvRandevular.TabIndex = 3;
            // 
            // FRMRandevular
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1317, 632);
            Controls.Add(dgvRandevular);
            Controls.Add(btnRandevuAl);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "FRMRandevular";
            Text = "FRMRandevular";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRandevular).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtHastaSikayet;
        private TextBox txtHastaSoyad;
        private TextBox txtHastaAd;
        private Label label4;
        private Label label2;
        private Label label3;
        private Button btnRandevuAl;
        private DataGridView dgvRandevular;
        private ComboBox cbDoktorlar;
        private DateTimePicker dtpRandevuTarih;
        private Label label5;
    }
}