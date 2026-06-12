namespace AgroWasteNexus.Forms
{
    partial class Produksi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produksi));
            this.lblDataProduksi = new System.Windows.Forms.Label();
            this.grpDataKontrolKualitas = new System.Windows.Forms.GroupBox();
            this.lblBiayaProduksi = new System.Windows.Forms.Label();
            this.txtBiayaProduksi = new System.Windows.Forms.TextBox();
            this.cmbHasilProduksi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.dtpTanggalProduksi = new System.Windows.Forms.DateTimePicker();
            this.txtJumlahHasil = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblJumlahHasil = new System.Windows.Forms.Label();
            this.lblJumlahBahan = new System.Windows.Forms.Label();
            this.txtJumlahBahan = new System.Windows.Forms.TextBox();
            this.lblTanggalProduksi = new System.Windows.Forms.Label();
            this.txtIdBatch = new System.Windows.Forms.TextBox();
            this.lblIdProduksi = new System.Windows.Forms.Label();
            this.lblIdBatch = new System.Windows.Forms.Label();
            this.txtIdProduksi = new System.Windows.Forms.TextBox();
            this.grpDaftarKontrol = new System.Windows.Forms.GroupBox();
            this.dgvDaftarProduksi = new System.Windows.Forms.DataGridView();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnKembali = new System.Windows.Forms.Button();
            this.grpDataKontrolKualitas.SuspendLayout();
            this.grpDaftarKontrol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaftarProduksi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDataProduksi
            // 
            this.lblDataProduksi.AutoSize = true;
            this.lblDataProduksi.BackColor = System.Drawing.Color.Transparent;
            this.lblDataProduksi.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDataProduksi.Location = new System.Drawing.Point(188, 42);
            this.lblDataProduksi.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblDataProduksi.Name = "lblDataProduksi";
            this.lblDataProduksi.Size = new System.Drawing.Size(383, 47);
            this.lblDataProduksi.TabIndex = 0;
            this.lblDataProduksi.Text = "DATA PRODUKSI";
            this.lblDataProduksi.Click += new System.EventHandler(this.label1_Click);
            // 
            // grpDataKontrolKualitas
            // 
            this.grpDataKontrolKualitas.BackColor = System.Drawing.Color.Transparent;
            this.grpDataKontrolKualitas.Controls.Add(this.lblBiayaProduksi);
            this.grpDataKontrolKualitas.Controls.Add(this.txtBiayaProduksi);
            this.grpDataKontrolKualitas.Controls.Add(this.cmbHasilProduksi);
            this.grpDataKontrolKualitas.Controls.Add(this.label1);
            this.grpDataKontrolKualitas.Controls.Add(this.cmbStatus);
            this.grpDataKontrolKualitas.Controls.Add(this.dtpTanggalProduksi);
            this.grpDataKontrolKualitas.Controls.Add(this.txtJumlahHasil);
            this.grpDataKontrolKualitas.Controls.Add(this.lblStatus);
            this.grpDataKontrolKualitas.Controls.Add(this.lblJumlahHasil);
            this.grpDataKontrolKualitas.Controls.Add(this.lblJumlahBahan);
            this.grpDataKontrolKualitas.Controls.Add(this.txtJumlahBahan);
            this.grpDataKontrolKualitas.Controls.Add(this.lblTanggalProduksi);
            this.grpDataKontrolKualitas.Controls.Add(this.txtIdBatch);
            this.grpDataKontrolKualitas.Controls.Add(this.lblIdProduksi);
            this.grpDataKontrolKualitas.Controls.Add(this.lblIdBatch);
            this.grpDataKontrolKualitas.Controls.Add(this.txtIdProduksi);
            this.grpDataKontrolKualitas.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDataKontrolKualitas.ForeColor = System.Drawing.Color.DarkGreen;
            this.grpDataKontrolKualitas.Location = new System.Drawing.Point(12, 157);
            this.grpDataKontrolKualitas.Name = "grpDataKontrolKualitas";
            this.grpDataKontrolKualitas.Size = new System.Drawing.Size(823, 245);
            this.grpDataKontrolKualitas.TabIndex = 2;
            this.grpDataKontrolKualitas.TabStop = false;
            this.grpDataKontrolKualitas.Text = "📋 DATA PRODUKSI";
            // 
            // lblBiayaProduksi
            // 
            this.lblBiayaProduksi.AutoSize = true;
            this.lblBiayaProduksi.Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBiayaProduksi.ForeColor = System.Drawing.Color.Black;
            this.lblBiayaProduksi.Location = new System.Drawing.Point(418, 145);
            this.lblBiayaProduksi.Name = "lblBiayaProduksi";
            this.lblBiayaProduksi.Size = new System.Drawing.Size(177, 20);
            this.lblBiayaProduksi.TabIndex = 14;
            this.lblBiayaProduksi.Text = "Biaya Produksi (Rp)";
            // 
            // txtBiayaProduksi
            // 
            this.txtBiayaProduksi.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBiayaProduksi.Location = new System.Drawing.Point(593, 140);
            this.txtBiayaProduksi.Name = "txtBiayaProduksi";
            this.txtBiayaProduksi.Size = new System.Drawing.Size(204, 29);
            this.txtBiayaProduksi.TabIndex = 13;
            // 
            // cmbHasilProduksi
            // 
            this.cmbHasilProduksi.FormattingEnabled = true;
            this.cmbHasilProduksi.Location = new System.Drawing.Point(199, 193);
            this.cmbHasilProduksi.Name = "cmbHasilProduksi";
            this.cmbHasilProduksi.Size = new System.Drawing.Size(204, 31);
            this.cmbHasilProduksi.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Hasil Produksi";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(593, 188);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(204, 31);
            this.cmbStatus.TabIndex = 10;
            // 
            // dtpTanggalProduksi
            // 
            this.dtpTanggalProduksi.Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTanggalProduksi.Location = new System.Drawing.Point(203, 145);
            this.dtpTanggalProduksi.Name = "dtpTanggalProduksi";
            this.dtpTanggalProduksi.Size = new System.Drawing.Size(200, 27);
            this.dtpTanggalProduksi.TabIndex = 9;
            // 
            // txtJumlahHasil
            // 
            this.txtJumlahHasil.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJumlahHasil.Location = new System.Drawing.Point(593, 98);
            this.txtJumlahHasil.Name = "txtJumlahHasil";
            this.txtJumlahHasil.Size = new System.Drawing.Size(204, 29);
            this.txtJumlahHasil.TabIndex = 8;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(418, 188);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(63, 20);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Status";
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // lblJumlahHasil
            // 
            this.lblJumlahHasil.AutoSize = true;
            this.lblJumlahHasil.Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJumlahHasil.ForeColor = System.Drawing.Color.Black;
            this.lblJumlahHasil.Location = new System.Drawing.Point(418, 103);
            this.lblJumlahHasil.Name = "lblJumlahHasil";
            this.lblJumlahHasil.Size = new System.Drawing.Size(158, 20);
            this.lblJumlahHasil.TabIndex = 5;
            this.lblJumlahHasil.Text = "Jumlah Hasil (kg)";
            this.lblJumlahHasil.Click += new System.EventHandler(this.lblJumlahHasil_Click);
            // 
            // lblJumlahBahan
            // 
            this.lblJumlahBahan.AutoSize = true;
            this.lblJumlahBahan.Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJumlahBahan.ForeColor = System.Drawing.Color.Black;
            this.lblJumlahBahan.Location = new System.Drawing.Point(418, 50);
            this.lblJumlahBahan.Name = "lblJumlahBahan";
            this.lblJumlahBahan.Size = new System.Drawing.Size(169, 20);
            this.lblJumlahBahan.TabIndex = 6;
            this.lblJumlahBahan.Text = "Jumlah Bahan (kg)";
            // 
            // txtJumlahBahan
            // 
            this.txtJumlahBahan.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJumlahBahan.Location = new System.Drawing.Point(593, 45);
            this.txtJumlahBahan.Name = "txtJumlahBahan";
            this.txtJumlahBahan.Size = new System.Drawing.Size(204, 29);
            this.txtJumlahBahan.TabIndex = 5;
            // 
            // lblTanggalProduksi
            // 
            this.lblTanggalProduksi.AutoSize = true;
            this.lblTanggalProduksi.Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTanggalProduksi.ForeColor = System.Drawing.Color.Black;
            this.lblTanggalProduksi.Location = new System.Drawing.Point(6, 145);
            this.lblTanggalProduksi.Name = "lblTanggalProduksi";
            this.lblTanggalProduksi.Size = new System.Drawing.Size(157, 20);
            this.lblTanggalProduksi.TabIndex = 4;
            this.lblTanggalProduksi.Text = "Tanggal Produksi";
            // 
            // txtIdBatch
            // 
            this.txtIdBatch.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdBatch.Location = new System.Drawing.Point(203, 93);
            this.txtIdBatch.Name = "txtIdBatch";
            this.txtIdBatch.Size = new System.Drawing.Size(200, 29);
            this.txtIdBatch.TabIndex = 3;
            // 
            // lblIdProduksi
            // 
            this.lblIdProduksi.AutoSize = true;
            this.lblIdProduksi.Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdProduksi.ForeColor = System.Drawing.Color.Black;
            this.lblIdProduksi.Location = new System.Drawing.Point(6, 45);
            this.lblIdProduksi.Name = "lblIdProduksi";
            this.lblIdProduksi.Size = new System.Drawing.Size(109, 20);
            this.lblIdProduksi.TabIndex = 2;
            this.lblIdProduksi.Text = "ID Produksi";
            // 
            // lblIdBatch
            // 
            this.lblIdBatch.AutoSize = true;
            this.lblIdBatch.Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdBatch.ForeColor = System.Drawing.Color.Black;
            this.lblIdBatch.Location = new System.Drawing.Point(6, 91);
            this.lblIdBatch.Name = "lblIdBatch";
            this.lblIdBatch.Size = new System.Drawing.Size(81, 20);
            this.lblIdBatch.TabIndex = 1;
            this.lblIdBatch.Text = "Id Batch";
            // 
            // txtIdProduksi
            // 
            this.txtIdProduksi.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProduksi.Location = new System.Drawing.Point(203, 45);
            this.txtIdProduksi.Name = "txtIdProduksi";
            this.txtIdProduksi.Size = new System.Drawing.Size(200, 29);
            this.txtIdProduksi.TabIndex = 0;
            // 
            // grpDaftarKontrol
            // 
            this.grpDaftarKontrol.BackColor = System.Drawing.Color.Transparent;
            this.grpDaftarKontrol.Controls.Add(this.dgvDaftarProduksi);
            this.grpDaftarKontrol.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDaftarKontrol.ForeColor = System.Drawing.Color.DarkGreen;
            this.grpDaftarKontrol.Location = new System.Drawing.Point(12, 408);
            this.grpDaftarKontrol.Name = "grpDaftarKontrol";
            this.grpDaftarKontrol.Size = new System.Drawing.Size(823, 267);
            this.grpDaftarKontrol.TabIndex = 3;
            this.grpDaftarKontrol.TabStop = false;
            this.grpDaftarKontrol.Text = "📋 DAFTAR PRODUKSI";
            // 
            // dgvDaftarProduksi
            // 
            this.dgvDaftarProduksi.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDaftarProduksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDaftarProduksi.Location = new System.Drawing.Point(6, 31);
            this.dgvDaftarProduksi.Name = "dgvDaftarProduksi";
            this.dgvDaftarProduksi.RowHeadersWidth = 62;
            this.dgvDaftarProduksi.RowTemplate.Height = 28;
            this.dgvDaftarProduksi.Size = new System.Drawing.Size(802, 227);
            this.dgvDaftarProduksi.TabIndex = 0;
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.Green;
            this.btnTambah.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.ForeColor = System.Drawing.Color.Ivory;
            this.btnTambah.Location = new System.Drawing.Point(12, 681);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(122, 36);
            this.btnTambah.TabIndex = 4;
            this.btnTambah.Text = "➕Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnUpdate.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Ivory;
            this.btnUpdate.Location = new System.Drawing.Point(140, 681);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(122, 36);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "✏️Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.DarkRed;
            this.btnHapus.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.ForeColor = System.Drawing.Color.Ivory;
            this.btnHapus.Location = new System.Drawing.Point(268, 681);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(122, 36);
            this.btnHapus.TabIndex = 6;
            this.btnHapus.Text = "🗑️Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnKembali
            // 
            this.btnKembali.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKembali.Location = new System.Drawing.Point(698, 681);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(122, 36);
            this.btnKembali.TabIndex = 7;
            this.btnKembali.Text = " ⬅Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            // 
            // Produksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(26F, 47F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1193, 729);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.grpDaftarKontrol);
            this.Controls.Add(this.grpDataKontrolKualitas);
            this.Controls.Add(this.lblDataProduksi);
            this.Font = new System.Drawing.Font("Century", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkGreen;
            this.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.Name = "Produksi";
            this.Text = "DATA PRODUKSI";
            this.grpDataKontrolKualitas.ResumeLayout(false);
            this.grpDataKontrolKualitas.PerformLayout();
            this.grpDaftarKontrol.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaftarProduksi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDataProduksi;
        private System.Windows.Forms.GroupBox grpDataKontrolKualitas;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.DateTimePicker dtpTanggalProduksi;
        private System.Windows.Forms.TextBox txtJumlahHasil;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblJumlahHasil;
        private System.Windows.Forms.Label lblJumlahBahan;
        private System.Windows.Forms.TextBox txtJumlahBahan;
        private System.Windows.Forms.Label lblTanggalProduksi;
        private System.Windows.Forms.TextBox txtIdBatch;
        private System.Windows.Forms.Label lblIdProduksi;
        private System.Windows.Forms.Label lblIdBatch;
        private System.Windows.Forms.TextBox txtIdProduksi;
        private System.Windows.Forms.TextBox txtBiayaProduksi;
        private System.Windows.Forms.ComboBox cmbHasilProduksi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBiayaProduksi;
        private System.Windows.Forms.GroupBox grpDaftarKontrol;
        private System.Windows.Forms.DataGridView dgvDaftarProduksi;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnKembali;
    }
}