namespace AgroWasteNexus.Forms
{
    partial class JadwalPengangkutan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JadwalPengangkutan));
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtCatatan = new System.Windows.Forms.RichTextBox();
            this.cmbPetugas = new System.Windows.Forms.ComboBox();
            this.cmbKendaraan = new System.Windows.Forms.ComboBox();
            this.grpDatajadwalpengangkutan = new System.Windows.Forms.GroupBox();
            this.lblCatatan = new System.Windows.Forms.Label();
            this.dtpTanggalPengangkutan = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lblKendaraan = new System.Windows.Forms.Label();
            this.lblPetugas = new System.Windows.Forms.Label();
            this.lblTanggalProduksi = new System.Windows.Forms.Label();
            this.lblIdjadwal = new System.Windows.Forms.Label();
            this.txtIdjadwal = new System.Windows.Forms.TextBox();
            this.grpDaftarJadwalPengangkutan = new System.Windows.Forms.GroupBox();
            this.dgvDaftarJadwalPengangkutan = new System.Windows.Forms.DataGridView();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.lblJADWALPENGANGKUTAN = new System.Windows.Forms.Label();
            this.btnKembali = new System.Windows.Forms.Button();
            this.grpDatajadwalpengangkutan.SuspendLayout();
            this.grpDaftarJadwalPengangkutan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaftarJadwalPengangkutan)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(195, 143);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(204, 31);
            this.cmbStatus.TabIndex = 5;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(-33, -67);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // txtCatatan
            // 
            this.txtCatatan.Location = new System.Drawing.Point(195, 193);
            this.txtCatatan.Name = "txtCatatan";
            this.txtCatatan.Size = new System.Drawing.Size(208, 74);
            this.txtCatatan.TabIndex = 9;
            this.txtCatatan.Text = "";
            // 
            // cmbPetugas
            // 
            this.cmbPetugas.FormattingEnabled = true;
            this.cmbPetugas.Location = new System.Drawing.Point(593, 50);
            this.cmbPetugas.Name = "cmbPetugas";
            this.cmbPetugas.Size = new System.Drawing.Size(204, 31);
            this.cmbPetugas.TabIndex = 11;
            // 
            // cmbKendaraan
            // 
            this.cmbKendaraan.FormattingEnabled = true;
            this.cmbKendaraan.Location = new System.Drawing.Point(593, 98);
            this.cmbKendaraan.Name = "cmbKendaraan";
            this.cmbKendaraan.Size = new System.Drawing.Size(204, 31);
            this.cmbKendaraan.TabIndex = 12;
            // 
            // grpDatajadwalpengangkutan
            // 
            this.grpDatajadwalpengangkutan.BackColor = System.Drawing.Color.Transparent;
            this.grpDatajadwalpengangkutan.Controls.Add(this.lblCatatan);
            this.grpDatajadwalpengangkutan.Controls.Add(this.dtpTanggalPengangkutan);
            this.grpDatajadwalpengangkutan.Controls.Add(this.cmbKendaraan);
            this.grpDatajadwalpengangkutan.Controls.Add(this.cmbPetugas);
            this.grpDatajadwalpengangkutan.Controls.Add(this.txtCatatan);
            this.grpDatajadwalpengangkutan.Controls.Add(this.label4);
            this.grpDatajadwalpengangkutan.Controls.Add(this.lblKendaraan);
            this.grpDatajadwalpengangkutan.Controls.Add(this.lblPetugas);
            this.grpDatajadwalpengangkutan.Controls.Add(this.lblTanggalProduksi);
            this.grpDatajadwalpengangkutan.Controls.Add(this.cmbStatus);
            this.grpDatajadwalpengangkutan.Controls.Add(this.lblIdjadwal);
            this.grpDatajadwalpengangkutan.Controls.Add(this.txtIdjadwal);
            this.grpDatajadwalpengangkutan.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatajadwalpengangkutan.ForeColor = System.Drawing.Color.DarkGreen;
            this.grpDatajadwalpengangkutan.Location = new System.Drawing.Point(16, 129);
            this.grpDatajadwalpengangkutan.Name = "grpDatajadwalpengangkutan";
            this.grpDatajadwalpengangkutan.Size = new System.Drawing.Size(823, 283);
            this.grpDatajadwalpengangkutan.TabIndex = 19;
            this.grpDatajadwalpengangkutan.TabStop = false;
            this.grpDatajadwalpengangkutan.Text = "📋 DATA JADWAL PENGANGKUTAN";
            // 
            // lblCatatan
            // 
            this.lblCatatan.AutoSize = true;
            this.lblCatatan.Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatatan.ForeColor = System.Drawing.Color.Black;
            this.lblCatatan.Location = new System.Drawing.Point(6, 199);
            this.lblCatatan.Name = "lblCatatan";
            this.lblCatatan.Size = new System.Drawing.Size(77, 20);
            this.lblCatatan.TabIndex = 11;
            this.lblCatatan.Text = "Catatan";
            // 
            // dtpTanggalPengangkutan
            // 
            this.dtpTanggalPengangkutan.Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTanggalPengangkutan.Location = new System.Drawing.Point(199, 96);
            this.dtpTanggalPengangkutan.Name = "dtpTanggalPengangkutan";
            this.dtpTanggalPengangkutan.Size = new System.Drawing.Size(200, 27);
            this.dtpTanggalPengangkutan.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Status";
            // 
            // lblKendaraan
            // 
            this.lblKendaraan.AutoSize = true;
            this.lblKendaraan.Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKendaraan.ForeColor = System.Drawing.Color.Black;
            this.lblKendaraan.Location = new System.Drawing.Point(418, 101);
            this.lblKendaraan.Name = "lblKendaraan";
            this.lblKendaraan.Size = new System.Drawing.Size(101, 20);
            this.lblKendaraan.TabIndex = 5;
            this.lblKendaraan.Text = "Kendaraan";
            // 
            // lblPetugas
            // 
            this.lblPetugas.AutoSize = true;
            this.lblPetugas.Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPetugas.ForeColor = System.Drawing.Color.Black;
            this.lblPetugas.Location = new System.Drawing.Point(418, 50);
            this.lblPetugas.Name = "lblPetugas";
            this.lblPetugas.Size = new System.Drawing.Size(76, 20);
            this.lblPetugas.TabIndex = 6;
            this.lblPetugas.Text = "Petugas";
            // 
            // lblTanggalProduksi
            // 
            this.lblTanggalProduksi.AutoSize = true;
            this.lblTanggalProduksi.Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTanggalProduksi.ForeColor = System.Drawing.Color.Black;
            this.lblTanggalProduksi.Location = new System.Drawing.Point(6, 98);
            this.lblTanggalProduksi.Name = "lblTanggalProduksi";
            this.lblTanggalProduksi.Size = new System.Drawing.Size(205, 20);
            this.lblTanggalProduksi.TabIndex = 4;
            this.lblTanggalProduksi.Text = "Tanggal Pengangkutan";
            // 
            // lblIdjadwal
            // 
            this.lblIdjadwal.AutoSize = true;
            this.lblIdjadwal.Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdjadwal.ForeColor = System.Drawing.Color.Black;
            this.lblIdjadwal.Location = new System.Drawing.Point(6, 45);
            this.lblIdjadwal.Name = "lblIdjadwal";
            this.lblIdjadwal.Size = new System.Drawing.Size(93, 20);
            this.lblIdjadwal.TabIndex = 2;
            this.lblIdjadwal.Text = "ID Jadwal";
            // 
            // txtIdjadwal
            // 
            this.txtIdjadwal.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdjadwal.Location = new System.Drawing.Point(203, 45);
            this.txtIdjadwal.Name = "txtIdjadwal";
            this.txtIdjadwal.Size = new System.Drawing.Size(200, 29);
            this.txtIdjadwal.TabIndex = 0;
            this.txtIdjadwal.TextChanged += new System.EventHandler(this.txtIdjadwal_TextChanged);
            // 
            // grpDaftarJadwalPengangkutan
            // 
            this.grpDaftarJadwalPengangkutan.BackColor = System.Drawing.Color.Transparent;
            this.grpDaftarJadwalPengangkutan.Controls.Add(this.dgvDaftarJadwalPengangkutan);
            this.grpDaftarJadwalPengangkutan.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDaftarJadwalPengangkutan.ForeColor = System.Drawing.Color.DarkGreen;
            this.grpDaftarJadwalPengangkutan.Location = new System.Drawing.Point(16, 431);
            this.grpDaftarJadwalPengangkutan.Name = "grpDaftarJadwalPengangkutan";
            this.grpDaftarJadwalPengangkutan.Size = new System.Drawing.Size(823, 267);
            this.grpDaftarJadwalPengangkutan.TabIndex = 13;
            this.grpDaftarJadwalPengangkutan.TabStop = false;
            this.grpDaftarJadwalPengangkutan.Text = "📋 DAFTAR JADWAL PENGANGKUTAN";
            // 
            // dgvDaftarJadwalPengangkutan
            // 
            this.dgvDaftarJadwalPengangkutan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDaftarJadwalPengangkutan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDaftarJadwalPengangkutan.Location = new System.Drawing.Point(6, 31);
            this.dgvDaftarJadwalPengangkutan.Name = "dgvDaftarJadwalPengangkutan";
            this.dgvDaftarJadwalPengangkutan.RowHeadersWidth = 62;
            this.dgvDaftarJadwalPengangkutan.RowTemplate.Height = 28;
            this.dgvDaftarJadwalPengangkutan.Size = new System.Drawing.Size(802, 227);
            this.dgvDaftarJadwalPengangkutan.TabIndex = 0;
            this.dgvDaftarJadwalPengangkutan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDaftarJadwalPengangkutan_CellContentClick);
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.Green;
            this.btnTambah.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.ForeColor = System.Drawing.Color.Ivory;
            this.btnTambah.Location = new System.Drawing.Point(22, 695);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(122, 36);
            this.btnTambah.TabIndex = 5;
            this.btnTambah.Text = "➕Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnUpdate.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Ivory;
            this.btnUpdate.Location = new System.Drawing.Point(150, 695);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(122, 36);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "✏️Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.DarkRed;
            this.btnHapus.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.ForeColor = System.Drawing.Color.Ivory;
            this.btnHapus.Location = new System.Drawing.Point(278, 696);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(122, 36);
            this.btnHapus.TabIndex = 7;
            this.btnHapus.Text = "🗑️Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblJADWALPENGANGKUTAN
            // 
            this.lblJADWALPENGANGKUTAN.BackColor = System.Drawing.Color.Transparent;
            this.lblJADWALPENGANGKUTAN.Font = new System.Drawing.Font("Century", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJADWALPENGANGKUTAN.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblJADWALPENGANGKUTAN.Location = new System.Drawing.Point(166, 39);
            this.lblJADWALPENGANGKUTAN.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblJADWALPENGANGKUTAN.Name = "lblJADWALPENGANGKUTAN";
            this.lblJADWALPENGANGKUTAN.Size = new System.Drawing.Size(598, 47);
            this.lblJADWALPENGANGKUTAN.TabIndex = 22;
            this.lblJADWALPENGANGKUTAN.Text = "JADWAL PENGANGKUTAN";
            // 
            // btnKembali
            // 
            this.btnKembali.Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKembali.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnKembali.Location = new System.Drawing.Point(726, 704);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(113, 30);
            this.btnKembali.TabIndex = 23;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            // 
            // JadwalPengangkutan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(978, 744);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.lblJADWALPENGANGKUTAN);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.grpDaftarJadwalPengangkutan);
            this.Controls.Add(this.grpDatajadwalpengangkutan);
            this.Controls.Add(this.richTextBox1);
            this.Name = "JadwalPengangkutan";
            this.Load += new System.EventHandler(this.JadwalPengangkutan_Load);
            this.grpDatajadwalpengangkutan.ResumeLayout(false);
            this.grpDatajadwalpengangkutan.PerformLayout();
            this.grpDaftarJadwalPengangkutan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaftarJadwalPengangkutan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox txtCatatan;
        private System.Windows.Forms.ComboBox cmbPetugas;
        private System.Windows.Forms.ComboBox cmbKendaraan;
        private System.Windows.Forms.GroupBox grpDatajadwalpengangkutan;
        private System.Windows.Forms.Label lblCatatan;
        private System.Windows.Forms.DateTimePicker dtpTanggalPengangkutan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblKendaraan;
        private System.Windows.Forms.Label lblPetugas;
        private System.Windows.Forms.Label lblTanggalProduksi;
        private System.Windows.Forms.Label lblIdjadwal;
        private System.Windows.Forms.TextBox txtIdjadwal;
        private System.Windows.Forms.GroupBox grpDaftarJadwalPengangkutan;
        private System.Windows.Forms.DataGridView dgvDaftarJadwalPengangkutan;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Label lblJADWALPENGANGKUTAN;
        private System.Windows.Forms.Button btnKembali;
    }
}