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
        }
    }
}
