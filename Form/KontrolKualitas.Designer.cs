namespace AgroWasteNexus.Forms
{
    partial class KontrolKualitas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KontrolKualitas));
            this.llbTitle = new System.Windows.Forms.Label();
            this.grpDataKontrolKualitas = new System.Windows.Forms.GroupBox();
            this.cmbStatusKualitas = new System.Windows.Forms.ComboBox();
            this.dtpTanggalPemeriksaan = new System.Windows.Forms.DateTimePicker();
            this.txtcatatan = new System.Windows.Forms.TextBox();
            this.lblCatatan = new System.Windows.Forms.Label();
            this.lblStatuskualitas = new System.Windows.Forms.Label();
            this.lblNilaiKualitas = new System.Windows.Forms.Label();
            this.txtNilaiKualitas = new System.Windows.Forms.TextBox();
            this.lblTanggalPemeriksaan = new System.Windows.Forms.Label();
            this.txtIdProduksi = new System.Windows.Forms.TextBox();
            this.lblIdProduksi = new System.Windows.Forms.Label();
            this.lblIdKontrol = new System.Windows.Forms.Label();
            this.txtIdKontrol = new System.Windows.Forms.TextBox();
            this.grpDaftarKontrol = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnKembali = new System.Windows.Forms.Button();
            this.grpDataKontrolKualitas.SuspendLayout();
            this.grpDaftarKontrol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // llbTitle
            // 
            this.llbTitle.AutoSize = true;
            this.llbTitle.BackColor = System.Drawing.Color.Transparent;
            this.llbTitle.Font = new System.Drawing.Font("Century", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbTitle.ForeColor = System.Drawing.Color.DarkGreen;
            this.llbTitle.Location = new System.Drawing.Point(177, 43);
            this.llbTitle.Name = "llbTitle";
            this.llbTitle.Size = new System.Drawing.Size(473, 47);
            this.llbTitle.TabIndex = 0;
            this.llbTitle.Text = "KONTROL KUALITAS";
            // 
            // grpDataKontrolKualitas
            // 
            this.grpDataKontrolKualitas.BackColor = System.Drawing.Color.Transparent;
            this.grpDataKontrolKualitas.Controls.Add(this.cmbStatusKualitas);
            this.grpDataKontrolKualitas.Controls.Add(this.dtpTanggalPemeriksaan);
            this.grpDataKontrolKualitas.Controls.Add(this.txtcatatan);
            this.grpDataKontrolKualitas.Controls.Add(this.lblCatatan);
            this.grpDataKontrolKualitas.Controls.Add(this.lblStatuskualitas);
            this.grpDataKontrolKualitas.Controls.Add(this.lblNilaiKualitas);
            this.grpDataKontrolKualitas.Controls.Add(this.txtNilaiKualitas);
            this.grpDataKontrolKualitas.Controls.Add(this.lblTanggalPemeriksaan);
            this.grpDataKontrolKualitas.Controls.Add(this.txtIdProduksi);
            this.grpDataKontrolKualitas.Controls.Add(this.lblIdProduksi);
            this.grpDataKontrolKualitas.Controls.Add(this.lblIdKontrol);
            this.grpDataKontrolKualitas.Controls.Add(this.txtIdKontrol);
            this.grpDataKontrolKualitas.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDataKontrolKualitas.ForeColor = System.Drawing.Color.DarkGreen;
            this.grpDataKontrolKualitas.Location = new System.Drawing.Point(18, 147);
            this.grpDataKontrolKualitas.Name = "grpDataKontrolKualitas";
            this.grpDataKontrolKualitas.Size = new System.Drawing.Size(823, 207);
            this.grpDataKontrolKualitas.TabIndex = 1;
            this.grpDataKontrolKualitas.TabStop = false;
            this.grpDataKontrolKualitas.Text = "📋 DATA KONTROL KUALITAS";
            // 
            // cmbStatusKualitas
            // 
            this.cmbStatusKualitas.FormattingEnabled = true;
            this.cmbStatusKualitas.Location = new System.Drawing.Point(593, 91);
            this.cmbStatusKualitas.Name = "cmbStatusKualitas";
            this.cmbStatusKualitas.Size = new System.Drawing.Size(204, 31);
            this.cmbStatusKualitas.TabIndex = 10;
            // 
            // dtpTanggalPemeriksaan
            // 
            this.dtpTanggalPemeriksaan.Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTanggalPemeriksaan.Location = new System.Drawing.Point(203, 145);
            this.dtpTanggalPemeriksaan.Name = "dtpTanggalPemeriksaan";
            this.dtpTanggalPemeriksaan.Size = new System.Drawing.Size(200, 27);
            this.dtpTanggalPemeriksaan.TabIndex = 9;
            // 
            // txtcatatan
            // 
            this.txtcatatan.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcatatan.Location = new System.Drawing.Point(593, 145);
            this.txtcatatan.Name = "txtcatatan";
            this.txtcatatan.Size = new System.Drawing.Size(204, 29);
            this.txtcatatan.TabIndex = 8;
            // 
            // lblCatatan
            // 
            this.lblCatatan.AutoSize = true;
            this.lblCatatan.Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatatan.ForeColor = System.Drawing.Color.Black;
            this.lblCatatan.Location = new System.Drawing.Point(443, 145);
            this.lblCatatan.Name = "lblCatatan";
            this.lblCatatan.Size = new System.Drawing.Size(77, 20);
            this.lblCatatan.TabIndex = 7;
            this.lblCatatan.Text = "Catatan";
            // 
            // lblStatuskualitas
            // 
            this.lblStatuskualitas.AutoSize = true;
            this.lblStatuskualitas.Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatuskualitas.ForeColor = System.Drawing.Color.Black;
            this.lblStatuskualitas.Location = new System.Drawing.Point(443, 98);
            this.lblStatuskualitas.Name = "lblStatuskualitas";
            this.lblStatuskualitas.Size = new System.Drawing.Size(139, 20);
            this.lblStatuskualitas.TabIndex = 5;
            this.lblStatuskualitas.Text = "Status Kualitas";
            this.lblStatuskualitas.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNilaiKualitas
            // 
            this.lblNilaiKualitas.AutoSize = true;
            this.lblNilaiKualitas.Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNilaiKualitas.ForeColor = System.Drawing.Color.Black;
            this.lblNilaiKualitas.Location = new System.Drawing.Point(443, 50);
            this.lblNilaiKualitas.Name = "lblNilaiKualitas";
            this.lblNilaiKualitas.Size = new System.Drawing.Size(127, 20);
            this.lblNilaiKualitas.TabIndex = 6;
            this.lblNilaiKualitas.Text = "Nilai Kualitas";
            // 
            // txtNilaiKualitas
            // 
            this.txtNilaiKualitas.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNilaiKualitas.Location = new System.Drawing.Point(593, 45);
            this.txtNilaiKualitas.Name = "txtNilaiKualitas";
            this.txtNilaiKualitas.Size = new System.Drawing.Size(204, 29);
            this.txtNilaiKualitas.TabIndex = 5;
            // 
            // lblTanggalPemeriksaan
            // 
            this.lblTanggalPemeriksaan.AutoSize = true;
            this.lblTanggalPemeriksaan.Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTanggalPemeriksaan.ForeColor = System.Drawing.Color.Black;
            this.lblTanggalPemeriksaan.Location = new System.Drawing.Point(6, 145);
            this.lblTanggalPemeriksaan.Name = "lblTanggalPemeriksaan";
            this.lblTanggalPemeriksaan.Size = new System.Drawing.Size(191, 20);
            this.lblTanggalPemeriksaan.TabIndex = 4;
            this.lblTanggalPemeriksaan.Text = "Tanggal Pemeriksaan";
            // 
            // txtIdProduksi
            // 
            this.txtIdProduksi.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProduksi.Location = new System.Drawing.Point(203, 93);
            this.txtIdProduksi.Name = "txtIdProduksi";
            this.txtIdProduksi.Size = new System.Drawing.Size(200, 29);
            this.txtIdProduksi.TabIndex = 3;
            // 
            // lblIdProduksi
            // 
            this.lblIdProduksi.AutoSize = true;
            this.lblIdProduksi.Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdProduksi.ForeColor = System.Drawing.Color.Black;
            this.lblIdProduksi.Location = new System.Drawing.Point(6, 98);
            this.lblIdProduksi.Name = "lblIdProduksi";
            this.lblIdProduksi.Size = new System.Drawing.Size(106, 20);
            this.lblIdProduksi.TabIndex = 2;
            this.lblIdProduksi.Text = "Id Produksi";
            // 
            // lblIdKontrol
            // 
            this.lblIdKontrol.AutoSize = true;
            this.lblIdKontrol.Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdKontrol.ForeColor = System.Drawing.Color.Black;
            this.lblIdKontrol.Location = new System.Drawing.Point(6, 45);
            this.lblIdKontrol.Name = "lblIdKontrol";
            this.lblIdKontrol.Size = new System.Drawing.Size(95, 20);
            this.lblIdKontrol.TabIndex = 1;
            this.lblIdKontrol.Text = "Id Kontrol";
            // 
            // txtIdKontrol
            // 
            this.txtIdKontrol.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdKontrol.Location = new System.Drawing.Point(203, 45);
            this.txtIdKontrol.Name = "txtIdKontrol";
            this.txtIdKontrol.Size = new System.Drawing.Size(200, 29);
            this.txtIdKontrol.TabIndex = 0;
            // 
            // grpDaftarKontrol
            // 
            this.grpDaftarKontrol.BackColor = System.Drawing.Color.Transparent;
            this.grpDaftarKontrol.Controls.Add(this.dataGridView1);
            this.grpDaftarKontrol.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDaftarKontrol.ForeColor = System.Drawing.Color.DarkGreen;
            this.grpDaftarKontrol.Location = new System.Drawing.Point(18, 370);
            this.grpDaftarKontrol.Name = "grpDaftarKontrol";
            this.grpDaftarKontrol.Size = new System.Drawing.Size(823, 279);
            this.grpDaftarKontrol.TabIndex = 2;
            this.grpDaftarKontrol.TabStop = false;
            this.grpDaftarKontrol.Text = "📋 DAFTAR KONTROL KUALITAS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(802, 227);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.Green;
            this.btnTambah.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.ForeColor = System.Drawing.Color.Ivory;
            this.btnTambah.Location = new System.Drawing.Point(28, 655);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(122, 36);
            this.btnTambah.TabIndex = 3;
            this.btnTambah.Text = "➕Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnUpdate.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Ivory;
            this.btnUpdate.Location = new System.Drawing.Point(156, 655);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(122, 36);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "✏️Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.DarkRed;
            this.btnHapus.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.ForeColor = System.Drawing.Color.Ivory;
            this.btnHapus.Location = new System.Drawing.Point(284, 655);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(122, 36);
            this.btnHapus.TabIndex = 5;
            this.btnHapus.Text = "🗑️Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            // 
            // btnKembali
            // 
            this.btnKembali.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKembali.Location = new System.Drawing.Point(693, 655);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(122, 36);
            this.btnKembali.TabIndex = 6;
            this.btnKembali.Text = " ⬅Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            // 
            // KontrolKualitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1178, 715);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.grpDaftarKontrol);
            this.Controls.Add(this.grpDataKontrolKualitas);
            this.Controls.Add(this.llbTitle);
            this.Name = "KontrolKualitas";
            this.Text = "KontrolKualitas";
            this.Load += new System.EventHandler(this.KontrolKualitas_Load);
            this.grpDataKontrolKualitas.ResumeLayout(false);
            this.grpDataKontrolKualitas.PerformLayout();
            this.grpDaftarKontrol.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label llbTitle;
        private System.Windows.Forms.GroupBox grpDataKontrolKualitas;
        private System.Windows.Forms.Label lblIdProduksi;
        private System.Windows.Forms.Label lblIdKontrol;
        private System.Windows.Forms.TextBox txtIdKontrol;
        private System.Windows.Forms.TextBox txtNilaiKualitas;
        private System.Windows.Forms.Label lblTanggalPemeriksaan;
        private System.Windows.Forms.TextBox txtIdProduksi;
        private System.Windows.Forms.Label lblNilaiKualitas;
        private System.Windows.Forms.Label lblStatuskualitas;
        private System.Windows.Forms.TextBox txtcatatan;
        private System.Windows.Forms.Label lblCatatan;
        private System.Windows.Forms.ComboBox cmbStatusKualitas;
        private System.Windows.Forms.DateTimePicker dtpTanggalPemeriksaan;
        private System.Windows.Forms.GroupBox grpDaftarKontrol;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnKembali;
    }
}