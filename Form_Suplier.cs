using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AplikasiToko_Gamiat
{
    public partial class Form_Suplier : Form
    {
        public Form_Suplier()
        {
            InitializeComponent();
            TampilDataSup();
        }
        //Membuat Deklarasi Variabel
        string path = "D:/Kuliah/Mata Kuliah smt 5/Kamis_Pemrograman Framework (.Net) -IF19F/Tugas/Database/AplikasiToko_Gamiat/Suplier.xml";
        public void TampilDataSup()
        {
            XDocument xmldoc = XDocument.Load(path);
            var tampil = xmldoc.Descendants("Suplier").Select(sup => new
            {
                kode_supp = sup.Element("kode_supp").Value,
                nama_instansi = sup.Element("nama_instansi").Value,
                nama_manager = sup.Element("nama_manager").Value,
                alamat = sup.Element("alamat").Value,
                no_telp = sup.Element("no_telp").Value,
                kontak_person = sup.Element("kontak_person"),
                no_fax = sup.Element("no_fax").Value,
                email = sup.Element("email").Value,
                website = sup.Element("email").Value
            }).OrderBy(sup => sup.kode_supp);
            DataSet ds = new DataSet();
            ds.ReadXml(path);
            dgSuplier.DataSource = ds.Tables["Suplier"];
        }

        private void Form_Suplier_Load(object sender, EventArgs e)
        {
            TampilDataSup();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            XDocument xdoc = XDocument.Load(path);
            XElement sup = new XElement("Suplier",
                new XElement("kode_supp", txtKodeSup.Text),
                new XElement("nama_instansi", txtNamaSup.Text),
                new XElement("nama_manager", txtManajer.Text),
                new XElement("alamat", txtAlamat.Text),
                new XElement("no_telp", txtNoTelpSup.Text),
                new XElement("no_fax", txtNoFaxSup.Text),
                new XElement("email", txtEmailSup.Text),
                new XElement("website", txtWebsite.Text)
                );
            xdoc.Root.Add(sup);
            xdoc.Save(path);
            MessageBox.Show("Data Berhasil Ditambahkan!");
            TampilDataSup();
                
        }
    }
}
