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
    public partial class FRMRandevular : Form
    {
        private readonly HastaneRandevuDb _db;

        public FRMRandevular()
        {
            InitializeComponent();
            _db = new HastaneRandevuDb();

            DataGridViewAyarla();

            DoktorListele();
            RandevuListele();
        }
        private void DataGridViewAyarla()
        {
            dgvRandevular.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvRandevular.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHastaAd.Text) || string.IsNullOrWhiteSpace(txtHastaSoyad.Text) || string.IsNullOrWhiteSpace(txtHastaSikayet.Text) || cbDoktorlar.SelectedItem == null)
            {

                MessageBox.Show("Lütfen randevu bilgilerini eksiksiz doldurunuz!");
                return;
            }
            if (dtpRandevuTarih.Value < DateTime.Now)
            {
                MessageBox.Show("Eski tarihlere randevu alınamaz!");
                return;
            }

            Hasta hasta = new Hasta();
            hasta.Ad = txtHastaAd.Text;
            hasta.Soyad = txtHastaSoyad.Text;
            hasta.Sikayet = txtHastaSikayet.Text;

            _db.Hastalar.Add(hasta);
            _db.SaveChanges();

            Randevu randevu = new Randevu();
            randevu.Tarih = dtpRandevuTarih.Value;
            randevu.Hasta = hasta;
            randevu.Doktor = cbDoktorlar.SelectedItem as Doktor;


            _db.Randevular.Add(randevu);
            _db.SaveChanges();


            MessageBox.Show("Randevu başarıyla alındı!");
            RandevuListele();
            RandevuBilgileriTemizle();

        }

        private void RandevuListele()
        {
            //var randevular = _db.Randevular.Include(r => r.Doktor).Include(r => r.Hasta).ToList();
            var randevular = _db.Randevular
                .Include(r => r.Hasta)
                .Include(r => r.Doktor)
                .ThenInclude(d => d.Bolum)
                .Select(r => new { HastaAdSoyad = r.Hasta.Ad + " " + r.Hasta.Soyad, r.Tarih, DoktorAd = r.Doktor.Ad, DoktorSoyad = r.Doktor.Soyad, BolumAdi = r.Doktor.Bolum.Adi }).ToList();
            dgvRandevular.DataSource = randevular;

            DataGridViewBasliklariDuzenle();
        }

        private void DataGridViewBasliklariDuzenle()
        {
            dgvRandevular.Columns["HastaAdSoyad"].HeaderText = "Hasta Adı Soyadı";
            dgvRandevular.Columns["DoktorAd"].HeaderText = "Doktor Ad";
            dgvRandevular.Columns["BolumAdi"].HeaderText = "Bölüm Ad";
        }

        private void RandevuBilgileriTemizle()
        {
            txtHastaAd.Text = txtHastaSoyad.Text = txtHastaSikayet.Text = string.Empty;
            dtpRandevuTarih.Value = DateTime.Now;
            cbDoktorlar.SelectedItem = null;
        }

        private void DoktorListele()
        {
            var doktorlar = _db.Doktorlar.ToList();

            foreach (var doktor in doktorlar)
            {
                cbDoktorlar.Items.Add(doktor);
            }
        }
    }
}
