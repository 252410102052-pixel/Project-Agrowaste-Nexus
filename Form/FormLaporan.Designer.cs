namespace AgroWasteNexus.Forms
{
    partial class FormLaporan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLaporan));
            this.label1 = new System.Windows.Forms.Label();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.btnTampilkan = new System.Windows.Forms.Button();
            this.dtpAkhir = new System.Windows.Forms.DateTimePicker();
            this.dtpAwal = new System.Windows.Forms.DateTimePicker();
            this.lblTanggalAkhir = new System.Windows.Forms.Label();
            this.lblTanggalAwal = new System.Windows.Forms.Label();
            this.dgvLaporan = new System.Windows.Forms.DataGridView();
            this.btnKembali = new System.Windows.Forms.Button();
            this.grpDataLaporan = new System.Windows.Forms.GroupBox();
            this.grpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaporan)).BeginInit();
            this.grpDataLaporan.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(176, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(566, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "LAPORAN PRODUKSI";
            this.label1.UseMnemonic = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // grpFilter
            // 
            this.grpFilter.BackColor = System.Drawing.Color.Transparent;
            this.grpFilter.Controls.Add(this.btnTampilkan);
            this.grpFilter.Controls.Add(this.dtpAkhir);
            this.grpFilter.Controls.Add(this.dtpAwal);
            this.grpFilter.Controls.Add(this.lblTanggalAkhir);
            this.grpFilter.Controls.Add(this.lblTanggalAwal);
            this.grpFilter.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFilter.ForeColor = System.Drawing.Color.DarkGreen;
            this.grpFilter.Location = new System.Drawing.Point(19, 172);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(750, 184);
            this.grpFilter.TabIndex = 1;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "FILTER PERIODE";
            // 
            // btnTampilkan
            // 
            this.btnTampilkan.BackColor = System.Drawing.SystemColors.Info;
            this.btnTampilkan.ForeColor = System.Drawing.Color.Black;
            this.btnTampilkan.Location = new System.Drawing.Point(617, 131);
            this.btnTampilkan.Name = "btnTampilkan";
            this.btnTampilkan.Size = new System.Drawing.Size(115, 38);
            this.btnTampilkan.TabIndex = 4;
            this.btnTampilkan.Text = "Tampilkan";
            this.btnTampilkan.UseVisualStyleBackColor = false;
            // 
            // dtpAkhir
            // 
            this.dtpAkhir.Location = new System.Drawing.Point(392, 77);
            this.dtpAkhir.Name = "dtpAkhir";
            this.dtpAkhir.Size = new System.Drawing.Size(296, 30);
            this.dtpAkhir.TabIndex = 3;
            // 
            // dtpAwal
            // 
            this.dtpAwal.Location = new System.Drawing.Point(10, 77);
            this.dtpAwal.Name = "dtpAwal";
            this.dtpAwal.Size = new System.Drawing.Size(308, 30);
            this.dtpAwal.TabIndex = 2;
            // 
            // lblTanggalAkhir
            // 
            this.lblTanggalAkhir.AutoSize = true;
            this.lblTanggalAkhir.ForeColor = System.Drawing.Color.Black;
            this.lblTanggalAkhir.Location = new System.Drawing.Point(388, 35);
            this.lblTanggalAkhir.Name = "lblTanggalAkhir";
            this.lblTanggalAkhir.Size = new System.Drawing.Size(128, 23);
            this.lblTanggalAkhir.TabIndex = 1;
            this.lblTanggalAkhir.Text = "Tanggal Akhir";
            // 
            // lblTanggalAwal
            // 
            this.lblTanggalAwal.AutoSize = true;
            this.lblTanggalAwal.ForeColor = System.Drawing.Color.Black;
            this.lblTanggalAwal.Location = new System.Drawing.Point(6, 35);
            this.lblTanggalAwal.Name = "lblTanggalAwal";
            this.lblTanggalAwal.Size = new System.Drawing.Size(122, 23);
            this.lblTanggalAwal.TabIndex = 0;
            this.lblTanggalAwal.Text = "Tanggal Awal";
            // 
            // dgvLaporan
            // 
            this.dgvLaporan.BackgroundColor = System.Drawing.Color.White;
            this.dgvLaporan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLaporan.Location = new System.Drawing.Point(10, 36);
            this.dgvLaporan.Name = "dgvLaporan";
            this.dgvLaporan.RowHeadersWidth = 62;
            this.dgvLaporan.RowTemplate.Height = 28;
            this.dgvLaporan.Size = new System.Drawing.Size(722, 222);
            this.dgvLaporan.TabIndex = 3;
            // 
            // btnKembali
            // 
            this.btnKembali.BackColor = System.Drawing.SystemColors.Info;
            this.btnKembali.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKembali.Location = new System.Drawing.Point(636, 661);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(133, 37);
            this.btnKembali.TabIndex = 4;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = false;
            // 
            // grpDataLaporan
            // 
            this.grpDataLaporan.BackColor = System.Drawing.Color.Transparent;
            this.grpDataLaporan.Controls.Add(this.dgvLaporan);
            this.grpDataLaporan.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDataLaporan.ForeColor = System.Drawing.Color.DarkGreen;
            this.grpDataLaporan.Location = new System.Drawing.Point(19, 381);
            this.grpDataLaporan.Name = "grpDataLaporan";
            this.grpDataLaporan.Size = new System.Drawing.Size(750, 274);
            this.grpDataLaporan.TabIndex = 6;
            this.grpDataLaporan.TabStop = false;
            this.grpDataLaporan.Text = "DATA LAPORAN";
            // 
            // FormLaporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1180, 779);
            this.Controls.Add(this.grpDataLaporan);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.grpFilter);
            this.Controls.Add(this.label1);
            this.Name = "FormLaporan";
            this.Text = "FormLaporan";
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaporan)).EndInit();
            this.grpDataLaporan.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.Label lblTanggalAkhir;
        private System.Windows.Forms.Label lblTanggalAwal;
        private System.Windows.Forms.Button btnTampilkan;
        private System.Windows.Forms.DateTimePicker dtpAkhir;
        private System.Windows.Forms.DateTimePicker dtpAwal;
        private System.Windows.Forms.DataGridView dgvLaporan;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.GroupBox grpDataLaporan;
    }
}