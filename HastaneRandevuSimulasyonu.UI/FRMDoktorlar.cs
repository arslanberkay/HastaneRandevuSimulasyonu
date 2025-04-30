using HastaneRandevuSimulasyonu.UI.Context;
using HastaneRandevuSimulasyonu.UI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneRandevuSimulasyonu.UI
{
    public partial class FRMDoktorlar : Form
    {
        HastaneRandevuDb _db = new HastaneRandevuDb();

        public FRMDoktorlar()
        {
            InitializeComponent();

            DataGridViewAyarla();

            DoktorListele();
            BolumListele();
        }

        private void btnDoktorEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDoktorAd.Text) || string.IsNullOrWhiteSpace(txtDoktorSoyad.Text) || string.IsNullOrWhiteSpace(mtxtDoktorTelefon.Text) || cbBolum.SelectedItem == null)
            {
                MessageBox.Show("Lütfen doktor bilgilerini eksiksiz olarak giriniz!");
                return;
            }

            Doktor doktor = new Doktor();
            doktor.Ad = txtDoktorAd.Text;
            doktor.Soyad = txtDoktorSoyad.Text;
            doktor.Telefon = mtxtDoktorTelefon.Text;
            doktor.BolumId = (cbBolum.SelectedItem as Bolum).Id;
            //doktor.BolumId = (int)cbBolum.SelectedValue;

            _db.Doktorlar.Add(doktor);
            _db.SaveChanges();

            MessageBox.Show("Doktor ekleme işlemi başarıyla gerçekleşti!");
            DoktorListele();
            DoktorBilgileriTemizle();

        }

        private void DoktorListele()
        {
            var doktorlar = _db.Doktorlar.Include(d => d.Bolum).Select(d => new { d.Id, d.Ad, d.Soyad, d.Telefon, BolumAdi = d.Bolum.Adi }).ToList();
            //var doktorlar = _db.Doktorlar.ToList() ;
            dgvDoktorlar.DataSource = doktorlar;
        }

        private void BolumListele()
        {

            var bolumler = _db.Bolumler.Select(b => new { b.Id, b.Adi }).ToList();
            foreach (var bolum in bolumler)
            {
                cbBolum.Items.Add(bolum);
            }

            //var bolumler = _db.Bolumler.ToList();
            cbBolum.DisplayMember = "Adi"; //Combobox'ta kullanıcının göreceği metin için "Adi" alanını kullan
            cbBolum.ValueMember = "Id"; //Combobox'ın arka planda tutacağı seçili değeri belirler.

            //cbBolum.DataSource = bolumler;
        }

        private void DoktorBilgileriTemizle()
        {
            txtDoktorAd.Text = txtDoktorSoyad.Text = mtxtDoktorTelefon.Text = string.Empty;
            cbBolum.SelectedItem = null;
        }

        Doktor secilenDoktor;

        private void dgvDoktorlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenDoktorId = (int)dgvDoktorlar.SelectedRows[0].Cells["Id"].Value;
            secilenDoktor = _db.Doktorlar.FirstOrDefault(d => d.Id == secilenDoktorId);

            txtDoktorAd.Text = secilenDoktor.Ad;
            txtDoktorSoyad.Text = secilenDoktor.Soyad;
            mtxtDoktorTelefon.Text = secilenDoktor.Telefon;
            cbBolum.SelectedItem = secilenDoktor.Bolum;
        }

        private void btnDoktorSil_Click(object sender, EventArgs e)
        {
            if (secilenDoktor == null)
            {
                MessageBox.Show("Lütfen silmek istediğiniz doktoru seçiniz!");
                return;
            }

            //var seciliDoktorId = (int)(dgvDoktorlar.SelectedRows[0].Cells["Id"].Value);
            //var seciliDoktor = _db.Doktorlar.FirstOrDefault(d => d.Id == seciliDoktorId);

            _db.Doktorlar.Remove(secilenDoktor);
            _db.SaveChanges();

            secilenDoktor = null;

            MessageBox.Show("Doktor silme işlemi başarıyla gerçekleşti");
            DoktorListele();
            DoktorBilgileriTemizle();
        }

        private void btnDoktorGuncelle_Click(object sender, EventArgs e)
        {
            if (secilenDoktor == null)
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz doktoru seçiniz!");
                return;
            }

            secilenDoktor.Ad = txtDoktorAd.Text;
            secilenDoktor.Soyad = txtDoktorSoyad.Text;
            secilenDoktor.Telefon = mtxtDoktorTelefon.Text;
            secilenDoktor.BolumId = (cbBolum.SelectedItem as Bolum).Id;

            _db.SaveChanges();

            MessageBox.Show("Doktor güncelleme işlemi başarıyla gerçekleşti");
            DoktorListele();
            DoktorBilgileriTemizle();
        }

        private void DataGridViewAyarla()
        {
            dgvDoktorlar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDoktorlar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void btnGec_Click(object sender, EventArgs e)
        {
            FRMRandevular fRMRandevular = new FRMRandevular();
            fRMRandevular.Show();
            this.Hide();
        }
    }
}
