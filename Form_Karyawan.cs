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
    public partial class Form_Karyawan : Form
    {
        
        public Form_Karyawan()
        {
            InitializeComponent();
            tampilDataKaryawan();
        }
        KaryawanClassesDataContext dbkaryawan = new KaryawanClassesDataContext();

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void tampilDataKaryawan()
        {
            var kary = from b in dbkaryawan.karyawans select b;
            dgKaryawan.DataSource = kary;
        }

        private void btnSimpanKaryawan_Click(object sender, EventArgs e)
        {
            char jk;
            if (rdLakilaki.Checked)
            {
                jk = 'L';
            }
            else
            {
                jk = 'P' ;
            }

            string nik = txtNik.Text, nama_karyawan = txtNama.Text, alamat_karyawan = txtAlamat.Text,
                kota = txtKota.Text, tempat = txtTempat.Text, agama = cmbAgama.Text,
                status = cmbStatus.Text, pendidikan = cmbPendidikan.Text
                ;
            char jkelamin = Convert.ToChar(jk);
            int tanggungan = int.Parse(txtTanggungan.Text), no_telp = int.Parse(txtNoTelp.Text);
            DateTime tgl_lahir = dtTglLahir.Value;
            var kary = new karyawan
            {
                nik = nik,
                nama = nama_karyawan,
                alamat = alamat_karyawan,
                kota = kota,
                tempat_lahir = tempat,
                tgl_lahir = tgl_lahir,
                agama = agama,
                jk = jkelamin,
                status_menikah = status,
                tanggungan = tanggungan,
                pendidikan = pendidikan,
                no_telp = no_telp
            };
            dbkaryawan.karyawans.InsertOnSubmit(kary);
            dbkaryawan.SubmitChanges();
            MessageBox.Show("Data Karyawan Berhasil Di tambahkan Menggunakan LINQ !!");
            bersih();
            tampilDataKaryawan();
        }

        private void bersih()
        {
            txtNik.Clear();
            txtNama.Clear();
            txtAlamat.Clear();
            txtKota.Clear();
            txtTempat.Clear();
            dtTglLahir.ResetText();
            cmbAgama.SelectedIndex = -1;
            rdLakilaki.Checked = false;
            rdPerempuan.Checked = false;
            cmbStatus.SelectedIndex = -1;
            txtTanggungan.Clear();
            cmbPendidikan.SelectedIndex = -1;
            txtNoTelp.Clear();
        }

       
        private void Form_Karyawan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbAppTokoDataSet.karyawan' table. You can move, or remove it, as needed.
            /*this.karyawanTableAdapter.Fill(this.dbAppTokoDataSet.karyawan);*/
            cmbAgama.Items.Add("Islam");
            cmbAgama.Items.Add("Kristen");
            cmbAgama.Items.Add("Hindu");
            cmbAgama.Items.Add("Budha");
            cmbPendidikan.Items.Add("SD");
            cmbPendidikan.Items.Add("SMP");
            cmbPendidikan.Items.Add("SMA");
            cmbPendidikan.Items.Add("S1");
            cmbPendidikan.Items.Add("S2");
            cmbPendidikan.Items.Add("S3");
            cmbStatus.Items.Add("Sudah Menikah");
            cmbStatus.Items.Add("Belum Menikah");
        }

        private void btnEditKaryawan_Click(object sender, EventArgs e)
        {
            char jk;
            if (rdLakilaki.Checked)
            {
                jk = 'L';
            }
            else
            {
                jk = 'P';
            }

            string  nama_karyawan = txtNama.Text, alamat_karyawan = txtAlamat.Text,
                kota = txtKota.Text, tempat = txtTempat.Text, agama = cmbAgama.Text,
                status = cmbStatus.Text, pendidikan = cmbPendidikan.Text
                ;
            char jkelamin = Convert.ToChar(jk);
            int tanggungan = int.Parse(txtTanggungan.Text), no_telp = int.Parse(txtNoTelp.Text);
            DateTime tgl_lahir = dtTglLahir.Value;
            var kary = (from c in dbkaryawan.karyawans where c.nik == txtNik.Text select c).First();
            kary.nama = nama_karyawan;
            kary.alamat = alamat_karyawan;
            kary.kota = kota;
            kary.tempat_lahir = tempat;
            kary.agama = agama;
            kary.status_menikah = status;
            kary.jk = jkelamin;
            kary.tanggungan = tanggungan;
            kary.no_telp = no_telp;
            kary.tgl_lahir = tgl_lahir;

            dbkaryawan.SubmitChanges();
            MessageBox.Show("Data Karyawan Berhasil Di Edit !!");
            
            tampilDataKaryawan();
        }

        private void btnHapusKaryawan_Click(object sender, EventArgs e)
        {
            var kary = (from c in dbkaryawan.karyawans where c.nik == txtNik.Text select c).First();
            dbkaryawan.karyawans.DeleteOnSubmit(kary);
            dbkaryawan.SubmitChanges();
            MessageBox.Show("Data Berhasil Dihapus dengan LINQ!");
            tampilDataKaryawan();
        }

        private void btnKeluarKaryawan_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBatalKaryawan_Click(object sender, EventArgs e)
        {
            bersih();
        }
    }
}
