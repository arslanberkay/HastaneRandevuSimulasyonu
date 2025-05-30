﻿using HastaneRandevuSimulasyonu.UI.Context;
using HastaneRandevuSimulasyonu.UI.Models;
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
    public partial class FRMBolumler : Form
    {
        //HastaneRandevuDb _db = new HastaneRandevuDb();

       private readonly HastaneRandevuDb _db; //readonly anahtar kelimesi sayesinde _db değiştirilemez, bu da immutability sağlar.

        public FRMBolumler()
        {
            InitializeComponent();
            _db = new HastaneRandevuDb();

            DataGridViewAyarla();

            BolumleriListele();
        }

        private void DataGridViewAyarla()
        {
            dgvBolumler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvBolumler.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtBolumAdi.Text))
            {
                MessageBox.Show("Bölüm adı boş olamaz!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtBolumAciklamasi.Text))
            {
                MessageBox.Show("Bölüm açıklaması boş olamaz!");
                return false;
            }
            return true;
        }

        private void btnBolumEkle_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(txtBolumAdi.Text) || string.IsNullOrWhiteSpace(txtBolumAciklamasi.Text))
            //{
            //    MessageBox.Show("Lütfen bölüm bilgilerini eksiksiz doldurun!");
            //    return;
            //}

            if (!ValidateInputs())
            {
                return;
            }

            Bolum bolum = new Bolum();
            bolum.Adi = txtBolumAdi.Text;
            bolum.Aciklamasi = txtBolumAciklamasi.Text;

            _db.Bolumler.Add(bolum);
            _db.SaveChanges();

            MessageBox.Show("Bölüm ekleme işlemi başarıyla sonuçlandı!");
            BolumleriListele();
            BolumBilgileriniTemizle();

        }

        private void BolumleriListele()
        {
            var bolumler = _db.Bolumler.ToList();
            //var bolumler = _db.Bolumler.Select(b => new { b.Adi, b.Aciklamasi }).ToList();
            dgvBolumler.DataSource = bolumler;
            
        }

        private void BolumBilgileriniTemizle()
        {
            txtBolumAdi.Text = txtBolumAciklamasi.Text = string.Empty;
        }

        Bolum secilenBolum;

        private void dgvBolumler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenBolum = dgvBolumler.SelectedRows[0].DataBoundItem as Bolum;

            txtBolumAdi.Text = secilenBolum.Adi;
            txtBolumAciklamasi.Text = secilenBolum.Aciklamasi;
        }

        private void btnBolumSil_Click(object sender, EventArgs e)
        {
            if (secilenBolum == null)
            {
                MessageBox.Show("Lütfen silmek istediğiniz bölümü seçiniz!");
                return;
            }

            _db.Bolumler.Remove(secilenBolum);
            _db.SaveChanges();

            secilenBolum = null;

            MessageBox.Show("Bölüm silme işlemi başarıyla gerçekleşti.");
            BolumleriListele();
            BolumBilgileriniTemizle();

        }

        private void btnBolumGuncelle_Click(object sender, EventArgs e)
        {
            if (secilenBolum == null)
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz bölümü seçiniz!");
                return;
            }

            secilenBolum.Adi = txtBolumAdi.Text;
            secilenBolum.Aciklamasi = txtBolumAciklamasi.Text;

            _db.SaveChanges();

            secilenBolum = null;

            MessageBox.Show("Bölüm güncelleme işlemi başarıyla gerçekleşti.");
            BolumleriListele();
            BolumBilgileriniTemizle();
        }

        private void btnGec_Click(object sender, EventArgs e)
        {
            FRMDoktorlar fRMDoktorlar = new FRMDoktorlar();
            fRMDoktorlar.ShowDialog();
            this.Hide();
        }
    }
}
