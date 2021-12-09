using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiToko_Gamiat
{
    public partial class Form_BarangQ : Form
    {
        public Form_BarangQ()
        {
            InitializeComponent();
        }
        ProdukClassesDataContext db = new ProdukClassesDataContext();

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string kode_barang = txtKodeBarang.Text, nama_barang = txtNamaBarang.Text,
                satuan = cmbSatuan.Text;
            int diskon = int.Parse(txtDiskon.Text), harga_jual = int.Parse(txtHargaJual.Text),
                stok_gudang = int.Parse(txtGudang.Text), stok_rak = int.Parse(txtRak.Text),
                rusak = int.Parse(txtRusak.Text);

            var brg = new barang
            {
                kode_brg = kode_barang,
                nama_brg = nama_barang,
                diskon = diskon,
                harga_jual = harga_jual,
                stok_gudang = stok_gudang,
                stok_rak = stok_rak,
                rusak = rusak,
                satuan = satuan
            };
            db.barangs.InsertOnSubmit(brg);
            db.SubmitChanges();
            MessageBox.Show("Data Berhasil Ditambahkan Melalui LINQ !");
            tampilData();
        }

        private void tampilData()
        {
            var brg = from b in db.barangs select b;
            dgBarang.DataSource = brg;
        }

        private void Form_BarangQ_Load(object sender, EventArgs e)
        {
            tampilData();
            cmbSatuan.Items.Add("Lusin");
            cmbSatuan.Items.Add("Buah");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string nama_barang = txtNamaBarang.Text,
                satuan = cmbSatuan.Text;
            int diskon = int.Parse(txtDiskon.Text), harga_jual = int.Parse(txtHargaJual.Text),
                stok_gudang = int.Parse(txtGudang.Text), stok_rak = int.Parse(txtRak.Text),
                rusak = int.Parse(txtRusak.Text);

            var brg = (from b in db.barangs where b.kode_brg == txtKodeBarang.Text select b).First();
            brg.nama_brg = nama_barang;
            brg.diskon = diskon;
            brg.harga_jual = harga_jual;
            brg.stok_gudang = stok_gudang;
            brg.stok_rak = stok_rak;
            brg.rusak = rusak;
            brg.satuan = satuan;
            db.SubmitChanges();
            MessageBox.Show("Data Berhasil Diubah dengan LINQ !");
            tampilData();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            var brg = (from b in db.barangs where b.kode_brg == txtKodeBarang.Text select b).First();
            db.barangs.DeleteOnSubmit(brg);
            db.SubmitChanges();
            MessageBox.Show("Data Berhasil Dihapus");
            tampilData();
        }
        private void bersih()
        {
            txtKodeBarang.Clear();
            txtNamaBarang.Clear();
            txtDiskon.Clear();
            txtHargaJual.Clear();
            txtGudang.Clear();
            txtRak.Clear();
            txtRusak.Clear();
            cmbSatuan.SelectedIndex = -1;
        }
    }
}
