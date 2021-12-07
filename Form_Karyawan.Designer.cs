
namespace AplikasiToko_Gamiat
{
    partial class Form_Karyawan
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdPerempuan = new System.Windows.Forms.RadioButton();
            this.rdLakilaki = new System.Windows.Forms.RadioButton();
            this.cmbPendidikan = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbAgama = new System.Windows.Forms.ComboBox();
            this.dtTglLahir = new System.Windows.Forms.DateTimePicker();
            this.txtKota = new System.Windows.Forms.TextBox();
            this.txtTanggungan = new System.Windows.Forms.TextBox();
            this.txtNoTelp = new System.Windows.Forms.TextBox();
            this.txtTempat = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtNik = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labe = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSimpanKaryawan = new System.Windows.Forms.Button();
            this.btnEditKaryawan = new System.Windows.Forms.Button();
            this.btnHapusKaryawan = new System.Windows.Forms.Button();
            this.btnBatalKaryawan = new System.Windows.Forms.Button();
            this.btnKeluarKaryawan = new System.Windows.Forms.Button();
            this.dgKaryawan = new System.Windows.Forms.DataGridView();
            this.dbAppTokoDataSet = new AplikasiToko_Gamiat.DbAppTokoDataSet();
            this.karyawanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.karyawanTableAdapter = new AplikasiToko_Gamiat.DbAppTokoDataSetTableAdapters.karyawanTableAdapter();
            this.nikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempatlahirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgllahirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusmenikahDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggunganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pendidikanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notelpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgKaryawan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbAppTokoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.karyawanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdPerempuan);
            this.groupBox1.Controls.Add(this.rdLakilaki);
            this.groupBox1.Controls.Add(this.cmbPendidikan);
            this.groupBox1.Controls.Add(this.cmbStatus);
            this.groupBox1.Controls.Add(this.cmbAgama);
            this.groupBox1.Controls.Add(this.dtTglLahir);
            this.groupBox1.Controls.Add(this.txtKota);
            this.groupBox1.Controls.Add(this.txtTanggungan);
            this.groupBox1.Controls.Add(this.txtNoTelp);
            this.groupBox1.Controls.Add(this.txtTempat);
            this.groupBox1.Controls.Add(this.txtAlamat);
            this.groupBox1.Controls.Add(this.txtNama);
            this.groupBox1.Controls.Add(this.txtNik);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.labe);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(23, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(538, 375);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Karyawan";
            // 
            // rdPerempuan
            // 
            this.rdPerempuan.AutoSize = true;
            this.rdPerempuan.Location = new System.Drawing.Point(214, 234);
            this.rdPerempuan.Name = "rdPerempuan";
            this.rdPerempuan.Size = new System.Drawing.Size(38, 21);
            this.rdPerempuan.TabIndex = 4;
            this.rdPerempuan.TabStop = true;
            this.rdPerempuan.Text = "P";
            this.rdPerempuan.UseVisualStyleBackColor = true;
            // 
            // rdLakilaki
            // 
            this.rdLakilaki.AutoSize = true;
            this.rdLakilaki.Location = new System.Drawing.Point(147, 234);
            this.rdLakilaki.Name = "rdLakilaki";
            this.rdLakilaki.Size = new System.Drawing.Size(37, 21);
            this.rdLakilaki.TabIndex = 4;
            this.rdLakilaki.TabStop = true;
            this.rdLakilaki.Text = "L";
            this.rdLakilaki.UseVisualStyleBackColor = true;
            // 
            // cmbPendidikan
            // 
            this.cmbPendidikan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.karyawanBindingSource, "pendidikan", true));
            this.cmbPendidikan.FormattingEnabled = true;
            this.cmbPendidikan.Location = new System.Drawing.Point(147, 290);
            this.cmbPendidikan.Name = "cmbPendidikan";
            this.cmbPendidikan.Size = new System.Drawing.Size(146, 24);
            this.cmbPendidikan.TabIndex = 20;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.karyawanBindingSource, "status_menikah", true));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(147, 260);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(146, 24);
            this.cmbStatus.TabIndex = 16;
            // 
            // cmbAgama
            // 
            this.cmbAgama.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.karyawanBindingSource, "agama", true));
            this.cmbAgama.FormattingEnabled = true;
            this.cmbAgama.Location = new System.Drawing.Point(147, 192);
            this.cmbAgama.Name = "cmbAgama";
            this.cmbAgama.Size = new System.Drawing.Size(146, 24);
            this.cmbAgama.TabIndex = 13;
            // 
            // dtTglLahir
            // 
            this.dtTglLahir.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.karyawanBindingSource, "tgl_lahir", true));
            this.dtTglLahir.Location = new System.Drawing.Point(147, 154);
            this.dtTglLahir.Name = "dtTglLahir";
            this.dtTglLahir.Size = new System.Drawing.Size(273, 22);
            this.dtTglLahir.TabIndex = 11;
            // 
            // txtKota
            // 
            this.txtKota.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.karyawanBindingSource, "kota", true));
            this.txtKota.Location = new System.Drawing.Point(420, 94);
            this.txtKota.Multiline = true;
            this.txtKota.Name = "txtKota";
            this.txtKota.Size = new System.Drawing.Size(105, 22);
            this.txtKota.TabIndex = 7;
            // 
            // txtTanggungan
            // 
            this.txtTanggungan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.karyawanBindingSource, "tanggungan", true));
            this.txtTanggungan.Location = new System.Drawing.Point(420, 262);
            this.txtTanggungan.Multiline = true;
            this.txtTanggungan.Name = "txtTanggungan";
            this.txtTanggungan.Size = new System.Drawing.Size(96, 22);
            this.txtTanggungan.TabIndex = 18;
            // 
            // txtNoTelp
            // 
            this.txtNoTelp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.karyawanBindingSource, "no_telp", true));
            this.txtNoTelp.Location = new System.Drawing.Point(147, 320);
            this.txtNoTelp.Multiline = true;
            this.txtNoTelp.Name = "txtNoTelp";
            this.txtNoTelp.Size = new System.Drawing.Size(146, 22);
            this.txtNoTelp.TabIndex = 22;
            // 
            // txtTempat
            // 
            this.txtTempat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.karyawanBindingSource, "tempat_lahir", true));
            this.txtTempat.Location = new System.Drawing.Point(147, 122);
            this.txtTempat.Multiline = true;
            this.txtTempat.Name = "txtTempat";
            this.txtTempat.Size = new System.Drawing.Size(146, 22);
            this.txtTempat.TabIndex = 9;
            // 
            // txtAlamat
            // 
            this.txtAlamat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.karyawanBindingSource, "alamat", true));
            this.txtAlamat.Location = new System.Drawing.Point(147, 94);
            this.txtAlamat.Multiline = true;
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(211, 22);
            this.txtAlamat.TabIndex = 5;
            // 
            // txtNama
            // 
            this.txtNama.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.karyawanBindingSource, "nama", true));
            this.txtNama.Location = new System.Drawing.Point(147, 66);
            this.txtNama.Multiline = true;
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(378, 22);
            this.txtNama.TabIndex = 3;
            // 
            // txtNik
            // 
            this.txtNik.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.karyawanBindingSource, "nik", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtNik.Location = new System.Drawing.Point(147, 38);
            this.txtNik.Multiline = true;
            this.txtNik.Name = "txtNik";
            this.txtNik.Size = new System.Drawing.Size(100, 22);
            this.txtNik.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kota";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 325);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 17);
            this.label12.TabIndex = 21;
            this.label12.Text = "No. Telepon";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 297);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "Pendidikan";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Jenis Kelamin";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(299, 263);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 17);
            this.label13.TabIndex = 17;
            this.label13.Text = "Tanggungan";
            // 
            // labe
            // 
            this.labe.AutoSize = true;
            this.labe.Location = new System.Drawing.Point(16, 267);
            this.labe.Name = "labe";
            this.labe.Size = new System.Drawing.Size(48, 17);
            this.labe.TabIndex = 15;
            this.labe.Text = "Status";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Agama";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tanggal Lahir";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tempat Lahir";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Alamat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "NIK";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(334, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = ".:: DATA KARYAWAN::.";
            // 
            // btnSimpanKaryawan
            // 
            this.btnSimpanKaryawan.Location = new System.Drawing.Point(188, 502);
            this.btnSimpanKaryawan.Name = "btnSimpanKaryawan";
            this.btnSimpanKaryawan.Size = new System.Drawing.Size(75, 33);
            this.btnSimpanKaryawan.TabIndex = 2;
            this.btnSimpanKaryawan.Text = "Simpan";
            this.btnSimpanKaryawan.UseVisualStyleBackColor = true;
            this.btnSimpanKaryawan.Click += new System.EventHandler(this.btnSimpanKaryawan_Click);
            // 
            // btnEditKaryawan
            // 
            this.btnEditKaryawan.Location = new System.Drawing.Point(296, 502);
            this.btnEditKaryawan.Name = "btnEditKaryawan";
            this.btnEditKaryawan.Size = new System.Drawing.Size(75, 33);
            this.btnEditKaryawan.TabIndex = 2;
            this.btnEditKaryawan.Text = "Edit";
            this.btnEditKaryawan.UseVisualStyleBackColor = true;
            this.btnEditKaryawan.Click += new System.EventHandler(this.btnEditKaryawan_Click);
            // 
            // btnHapusKaryawan
            // 
            this.btnHapusKaryawan.Location = new System.Drawing.Point(188, 543);
            this.btnHapusKaryawan.Name = "btnHapusKaryawan";
            this.btnHapusKaryawan.Size = new System.Drawing.Size(75, 33);
            this.btnHapusKaryawan.TabIndex = 2;
            this.btnHapusKaryawan.Text = "Hapus";
            this.btnHapusKaryawan.UseVisualStyleBackColor = true;
            this.btnHapusKaryawan.Click += new System.EventHandler(this.btnHapusKaryawan_Click);
            // 
            // btnBatalKaryawan
            // 
            this.btnBatalKaryawan.Location = new System.Drawing.Point(296, 543);
            this.btnBatalKaryawan.Name = "btnBatalKaryawan";
            this.btnBatalKaryawan.Size = new System.Drawing.Size(75, 33);
            this.btnBatalKaryawan.TabIndex = 2;
            this.btnBatalKaryawan.Text = "Batal";
            this.btnBatalKaryawan.UseVisualStyleBackColor = true;
            this.btnBatalKaryawan.Click += new System.EventHandler(this.btnBatalKaryawan_Click);
            // 
            // btnKeluarKaryawan
            // 
            this.btnKeluarKaryawan.Location = new System.Drawing.Point(188, 588);
            this.btnKeluarKaryawan.Name = "btnKeluarKaryawan";
            this.btnKeluarKaryawan.Size = new System.Drawing.Size(183, 33);
            this.btnKeluarKaryawan.TabIndex = 3;
            this.btnKeluarKaryawan.Text = "Keluar";
            this.btnKeluarKaryawan.UseVisualStyleBackColor = true;
            this.btnKeluarKaryawan.Click += new System.EventHandler(this.btnKeluarKaryawan_Click);
            // 
            // dgKaryawan
            // 
            this.dgKaryawan.AutoGenerateColumns = false;
            this.dgKaryawan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKaryawan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nikDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn,
            this.kotaDataGridViewTextBoxColumn,
            this.tempatlahirDataGridViewTextBoxColumn,
            this.tgllahirDataGridViewTextBoxColumn,
            this.agamaDataGridViewTextBoxColumn,
            this.jkDataGridViewTextBoxColumn,
            this.statusmenikahDataGridViewTextBoxColumn,
            this.tanggunganDataGridViewTextBoxColumn,
            this.pendidikanDataGridViewTextBoxColumn,
            this.notelpDataGridViewTextBoxColumn});
            this.dgKaryawan.DataSource = this.karyawanBindingSource;
            this.dgKaryawan.Location = new System.Drawing.Point(578, 108);
            this.dgKaryawan.Name = "dgKaryawan";
            this.dgKaryawan.RowHeadersWidth = 51;
            this.dgKaryawan.RowTemplate.Height = 24;
            this.dgKaryawan.Size = new System.Drawing.Size(482, 513);
            this.dgKaryawan.TabIndex = 3;
            // 
            // dbAppTokoDataSet
            // 
            this.dbAppTokoDataSet.DataSetName = "DbAppTokoDataSet";
            this.dbAppTokoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // karyawanBindingSource
            // 
            this.karyawanBindingSource.DataMember = "karyawan";
            this.karyawanBindingSource.DataSource = this.dbAppTokoDataSet;
            // 
            // karyawanTableAdapter
            // 
            this.karyawanTableAdapter.ClearBeforeFill = true;
            // 
            // nikDataGridViewTextBoxColumn
            // 
            this.nikDataGridViewTextBoxColumn.DataPropertyName = "nik";
            this.nikDataGridViewTextBoxColumn.HeaderText = "nik";
            this.nikDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nikDataGridViewTextBoxColumn.Name = "nikDataGridViewTextBoxColumn";
            this.nikDataGridViewTextBoxColumn.Width = 125;
            // 
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "nama";
            this.namaDataGridViewTextBoxColumn.HeaderText = "nama";
            this.namaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            this.namaDataGridViewTextBoxColumn.Width = 125;
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "alamat";
            this.alamatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            this.alamatDataGridViewTextBoxColumn.Width = 125;
            // 
            // kotaDataGridViewTextBoxColumn
            // 
            this.kotaDataGridViewTextBoxColumn.DataPropertyName = "kota";
            this.kotaDataGridViewTextBoxColumn.HeaderText = "kota";
            this.kotaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kotaDataGridViewTextBoxColumn.Name = "kotaDataGridViewTextBoxColumn";
            this.kotaDataGridViewTextBoxColumn.Width = 125;
            // 
            // tempatlahirDataGridViewTextBoxColumn
            // 
            this.tempatlahirDataGridViewTextBoxColumn.DataPropertyName = "tempat_lahir";
            this.tempatlahirDataGridViewTextBoxColumn.HeaderText = "tempat_lahir";
            this.tempatlahirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tempatlahirDataGridViewTextBoxColumn.Name = "tempatlahirDataGridViewTextBoxColumn";
            this.tempatlahirDataGridViewTextBoxColumn.Width = 125;
            // 
            // tgllahirDataGridViewTextBoxColumn
            // 
            this.tgllahirDataGridViewTextBoxColumn.DataPropertyName = "tgl_lahir";
            this.tgllahirDataGridViewTextBoxColumn.HeaderText = "tgl_lahir";
            this.tgllahirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tgllahirDataGridViewTextBoxColumn.Name = "tgllahirDataGridViewTextBoxColumn";
            this.tgllahirDataGridViewTextBoxColumn.Width = 125;
            // 
            // agamaDataGridViewTextBoxColumn
            // 
            this.agamaDataGridViewTextBoxColumn.DataPropertyName = "agama";
            this.agamaDataGridViewTextBoxColumn.HeaderText = "agama";
            this.agamaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.agamaDataGridViewTextBoxColumn.Name = "agamaDataGridViewTextBoxColumn";
            this.agamaDataGridViewTextBoxColumn.Width = 125;
            // 
            // jkDataGridViewTextBoxColumn
            // 
            this.jkDataGridViewTextBoxColumn.DataPropertyName = "jk";
            this.jkDataGridViewTextBoxColumn.HeaderText = "jk";
            this.jkDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jkDataGridViewTextBoxColumn.Name = "jkDataGridViewTextBoxColumn";
            this.jkDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusmenikahDataGridViewTextBoxColumn
            // 
            this.statusmenikahDataGridViewTextBoxColumn.DataPropertyName = "status_menikah";
            this.statusmenikahDataGridViewTextBoxColumn.HeaderText = "status_menikah";
            this.statusmenikahDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusmenikahDataGridViewTextBoxColumn.Name = "statusmenikahDataGridViewTextBoxColumn";
            this.statusmenikahDataGridViewTextBoxColumn.Width = 125;
            // 
            // tanggunganDataGridViewTextBoxColumn
            // 
            this.tanggunganDataGridViewTextBoxColumn.DataPropertyName = "tanggungan";
            this.tanggunganDataGridViewTextBoxColumn.HeaderText = "tanggungan";
            this.tanggunganDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tanggunganDataGridViewTextBoxColumn.Name = "tanggunganDataGridViewTextBoxColumn";
            this.tanggunganDataGridViewTextBoxColumn.Width = 125;
            // 
            // pendidikanDataGridViewTextBoxColumn
            // 
            this.pendidikanDataGridViewTextBoxColumn.DataPropertyName = "pendidikan";
            this.pendidikanDataGridViewTextBoxColumn.HeaderText = "pendidikan";
            this.pendidikanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pendidikanDataGridViewTextBoxColumn.Name = "pendidikanDataGridViewTextBoxColumn";
            this.pendidikanDataGridViewTextBoxColumn.Width = 125;
            // 
            // notelpDataGridViewTextBoxColumn
            // 
            this.notelpDataGridViewTextBoxColumn.DataPropertyName = "no_telp";
            this.notelpDataGridViewTextBoxColumn.HeaderText = "no_telp";
            this.notelpDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.notelpDataGridViewTextBoxColumn.Name = "notelpDataGridViewTextBoxColumn";
            this.notelpDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form_Karyawan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1072, 653);
            this.Controls.Add(this.dgKaryawan);
            this.Controls.Add(this.btnBatalKaryawan);
            this.Controls.Add(this.btnHapusKaryawan);
            this.Controls.Add(this.btnEditKaryawan);
            this.Controls.Add(this.btnKeluarKaryawan);
            this.Controls.Add(this.btnSimpanKaryawan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Karyawan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Karyawan";
            this.Load += new System.EventHandler(this.Form_Karyawan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgKaryawan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbAppTokoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.karyawanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdPerempuan;
        private System.Windows.Forms.RadioButton rdLakilaki;
        private System.Windows.Forms.ComboBox cmbAgama;
        private System.Windows.Forms.DateTimePicker dtTglLahir;
        private System.Windows.Forms.TextBox txtKota;
        private System.Windows.Forms.TextBox txtTempat;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtNik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPendidikan;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labe;
        private System.Windows.Forms.TextBox txtTanggungan;
        private System.Windows.Forms.TextBox txtNoTelp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSimpanKaryawan;
        private System.Windows.Forms.Button btnEditKaryawan;
        private System.Windows.Forms.Button btnHapusKaryawan;
        private System.Windows.Forms.Button btnBatalKaryawan;
        private System.Windows.Forms.Button btnKeluarKaryawan;
        private System.Windows.Forms.DataGridView dgKaryawan;
        private DbAppTokoDataSet dbAppTokoDataSet;
        private System.Windows.Forms.BindingSource karyawanBindingSource;
        private DbAppTokoDataSetTableAdapters.karyawanTableAdapter karyawanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempatlahirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgllahirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusmenikahDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggunganDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pendidikanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notelpDataGridViewTextBoxColumn;
    }
}