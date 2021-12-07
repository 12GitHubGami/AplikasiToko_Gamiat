using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AplikasiToko_Gamiat
{
    public partial class Form_Barang : Form
    {
        public Form_Barang()
        {
            InitializeComponent();
            TampilDataBarang();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBatal_Click(object sender, EventArgs e)
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

        //membuat method tampilData Barang
        private void TampilDataBarang()
        {
            string coonstring = "Data Source=OPREKIN-PC\\SQLEXPRESS ; Initial Catalog=DbAppToko; Integrated Security=True";
            SqlConnection conn = new SqlConnection(coonstring);
            SqlCommand cmd = new SqlCommand("SELECT * FROM barang");
            SqlDataAdapter sda = new SqlDataAdapter();
            cmd.Connection = conn;
            sda.SelectCommand = cmd;
            DataTable dtBarang = new DataTable();
            sda.Fill(dtBarang);
            dgBarang.DataSource = dtBarang;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string coonstring = "Data Source=OPREKIN-PC\\SQLEXPRESS ; Initial Catalog=DbAppToko; Integrated Security=True";
            SqlConnection conn = new SqlConnection(coonstring);
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO barang VALUES(@kode_brg,@nama_brg,@diskon,@harga_jual," +
                "@stok_gudang,@stok_rak,@rusak,@satuan)", conn);
            cmd.Parameters.AddWithValue("@kode_brg", txtKodeBarang.Text);
            cmd.Parameters.AddWithValue("@nama_brg", txtNamaBarang.Text);
            cmd.Parameters.AddWithValue("@diskon", txtDiskon.Text);
            cmd.Parameters.AddWithValue("@harga_jual", txtHargaJual.Text);
            cmd.Parameters.AddWithValue("@stok_gudang", txtGudang.Text);
            cmd.Parameters.AddWithValue("@stok_rak", txtRak.Text);
            cmd.Parameters.AddWithValue("@rusak", txtRusak.Text);
            cmd.Parameters.AddWithValue("@satuan", cmbSatuan.SelectedItem);
            cmd.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Data Berhasil Ditambahkan!!");
            bersih();
            TampilDataBarang();
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

        private void Form_Barang_Load(object sender, EventArgs e)
        {
            cmbSatuan.Items.Add("Lusin");
            cmbSatuan.Items.Add("Buah");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string coonstring = "Data Source=OPREKIN-PC\\SQLEXPRESS ; Initial Catalog=DbAppToko; Integrated Security=True";
            SqlConnection conn = new SqlConnection(coonstring);
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE barang SET nama_brg=@nama_brg,diskon=@diskon,harga_jual=@harga_jual," +
                "stok_gudang=@stok_gudang,stok_rak=@stok_rak,rusak=@rusak,satuan=@satuan WHERE kode_brg=@kode_brg", conn);
            cmd.Parameters.AddWithValue("@kode_brg", txtKodeBarang.Text);
            cmd.Parameters.AddWithValue("@nama_brg", txtNamaBarang.Text);
            cmd.Parameters.AddWithValue("@diskon", txtDiskon.Text);
            cmd.Parameters.AddWithValue("@harga_jual", txtHargaJual.Text);
            cmd.Parameters.AddWithValue("@stok_gudang", txtGudang.Text);
            cmd.Parameters.AddWithValue("@stok_rak", txtRak.Text);
            cmd.Parameters.AddWithValue("@rusak", txtRusak.Text);
            cmd.Parameters.AddWithValue("@satuan", cmbSatuan.SelectedItem);
            cmd.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Data Berhasil Diedit!!");
            bersih();
            TampilDataBarang();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (txtKodeBarang.Text == "" || txtKodeBarang.Text == " ")
            {
                MessageBox.Show("Masukkan Kode Barang yang Akan Dihapus !");
            }
            else
            {
                string coonstring = "Data Source=OPREKIN-PC\\SQLEXPRESS ; Initial Catalog=DbAppToko; Integrated Security=True";
                SqlConnection conn = new SqlConnection(coonstring);
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM barang WHERE kode_brg=@kode_brg", conn);
                cmd.Parameters.AddWithValue("@kode_brg", txtKodeBarang.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data berhasil Dihapus !");
                bersih();
                TampilDataBarang();
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            string coonstring = "Data Source=OPREKIN-PC\\SQLEXPRESS ; Initial Catalog=DbAppToko; Integrated Security=True";
            SqlConnection conn = new SqlConnection(coonstring);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM barang WHERE nama_brg LIKE '%" + txtCari.Text + "%'", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgBarang.DataSource = dt;  
        }
    }
}
