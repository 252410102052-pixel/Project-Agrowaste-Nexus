namespace AgroWasteNexus.Forms
{
    partial class BatchLimbah
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BatchLimbah));
            this.txtIdBatch = new System.Windows.Forms.TextBox();
            this.txtJumlah = new System.Windows.Forms.TextBox();
            this.dtpTanggalMasuk = new System.Windows.Forms.DateTimePicker();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtIdPabrik = new System.Windows.Forms.TextBox();
            this.dgvBatch = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnKembali = new System.Windows.Forms.Button();
            this.grpBatchLimbah = new System.Windows.Forms.GroupBox();
            this.grpDataBatch = new System.Windows.Forms.GroupBox();
            this.lblIdJadwal = new System.Windows.Forms.Label();
            this.txtIdJadwal = new System.Windows.Forms.TextBox();
            this.lblIdPabrik = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTanggalMasuk = new System.Windows.Forms.Label();
            this.lblJumlah = new System.Windows.Forms.Label();
            this.lblIdBatch = new System.Windows.Forms.Label();
            this.grpDaftarBatch = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatch)).BeginInit();
            this.grpDataBatch.SuspendLayout();
            this.grpDaftarBatch.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIdBatch
            // 
            this.txtIdBatch.Location = new System.Drawing.Point(6, 58);
            this.txtIdBatch.Name = "txtIdBatch";
            this.txtIdBatch.Size = new System.Drawing.Size(197, 32);
            this.txtIdBatch.TabIndex = 0;
            // 
            // txtJumlah
            // 
            this.txtJumlah.Location = new System.Drawing.Point(254, 54);
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.Size = new System.Drawing.Size(196, 32);
            this.txtJumlah.TabIndex = 1;
            // 
            // dtpTanggalMasuk
            // 
            this.dtpTanggalMasuk.Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTanggalMasuk.Location = new System.Drawing.Point(509, 54);
            this.dtpTanggalMasuk.Name = "dtpTanggalMasuk";
            this.dtpTanggalMasuk.Size = new System.Drawing.Size(240, 27);
            this.dtpTanggalMasuk.TabIndex = 2;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(6, 132);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(197, 31);
            this.cmbStatus.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtIdPabrik
            // 
            this.txtIdPabrik.Location = new System.Drawing.Point(254, 131);
            this.txtIdPabrik.Name = "txtIdPabrik";
            this.txtIdPabrik.Size = new System.Drawing.Size(196, 32);
            this.txtIdPabrik.TabIndex = 5;
            this.txtIdPabrik.TextChanged += new System.EventHandler(this.txtIdPabrik_TextChanged);
            // 
            // dgvBatch
            // 
            this.dgvBatch.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvBatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBatch.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvBatch.Location = new System.Drawing.Point(1, 31);
            this.dgvBatch.Name = "dgvBatch";
            this.dgvBatch.RowHeadersWidth = 62;
            this.dgvBatch.RowTemplate.Height = 28;
            this.dgvBatch.Size = new System.Drawing.Size(780, 225);
            this.dgvBatch.TabIndex = 6;
            // 
            // btnRefresh
            // 
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(375, 280);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(110, 33);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnKembali
            // 
            this.btnKembali.ForeColor = System.Drawing.Color.Black;
            this.btnKembali.Location = new System.Drawing.Point(673, 280);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(114, 35);
            this.btnKembali.TabIndex = 11;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // grpBatchLimbah
            // 
            this.grpBatchLimbah.BackColor = System.Drawing.Color.Transparent;
            this.grpBatchLimbah.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBatchLimbah.ForeColor = System.Drawing.Color.DarkGreen;
            this.grpBatchLimbah.Location = new System.Drawing.Point(170, 45);
            this.grpBatchLimbah.Name = "grpBatchLimbah";
            this.grpBatchLimbah.Size = new System.Drawing.Size(797, 40);
            this.grpBatchLimbah.TabIndex = 12;
            this.grpBatchLimbah.TabStop = false;
            this.grpBatchLimbah.Text = "Batch Limbah";
            this.grpBatchLimbah.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // grpDataBatch
            // 
            this.grpDataBatch.BackColor = System.Drawing.Color.Transparent;
            this.grpDataBatch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grpDataBatch.Controls.Add(this.lblIdJadwal);
            this.grpDataBatch.Controls.Add(this.txtIdJadwal);
            this.grpDataBatch.Controls.Add(this.lblIdPabrik);
            this.grpDataBatch.Controls.Add(this.lblStatus);
            this.grpDataBatch.Controls.Add(this.lblTanggalMasuk);
            this.grpDataBatch.Controls.Add(this.lblJumlah);
            this.grpDataBatch.Controls.Add(this.lblIdBatch);
            this.grpDataBatch.Controls.Add(this.txtIdPabrik);
            this.grpDataBatch.Controls.Add(this.txtIdBatch);
            this.grpDataBatch.Controls.Add(this.dtpTanggalMasuk);
            this.grpDataBatch.Controls.Add(this.cmbStatus);
            this.grpDataBatch.Controls.Add(this.txtJumlah);
            this.grpDataBatch.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDataBatch.ForeColor = System.Drawing.Color.DarkGreen;
            this.grpDataBatch.Location = new System.Drawing.Point(21, 135);
            this.grpDataBatch.Name = "grpDataBatch";
            this.grpDataBatch.Size = new System.Drawing.Size(786, 184);
            this.grpDataBatch.TabIndex = 13;
            this.grpDataBatch.TabStop = false;
            this.grpDataBatch.Text = "Data Batch";
            // 
            // lblIdJadwal
            // 
            this.lblIdJadwal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIdJadwal.Location = new System.Drawing.Point(523, 99);
            this.lblIdJadwal.Name = "lblIdJadwal";
            this.lblIdJadwal.Size = new System.Drawing.Size(132, 34);
            this.lblIdJadwal.TabIndex = 12;
            this.lblIdJadwal.Text = "Id Jadwal";
            // 
            // txtIdJadwal
            // 
            this.txtIdJadwal.Location = new System.Drawing.Point(509, 136);
            this.txtIdJadwal.Name = "txtIdJadwal";
            this.txtIdJadwal.Size = new System.Drawing.Size(240, 32);
            this.txtIdJadwal.TabIndex = 11;
            // 
            // lblIdPabrik
            // 
            this.lblIdPabrik.AutoSize = true;
            this.lblIdPabrik.Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPabrik.ForeColor = System.Drawing.Color.Black;
            this.lblIdPabrik.Location = new System.Drawing.Point(271, 99);
            this.lblIdPabrik.Name = "lblIdPabrik";
            this.lblIdPabrik.Size = new System.Drawing.Size(88, 20);
            this.lblIdPabrik.TabIndex = 10;
            this.lblIdPabrik.Text = "Id Pabrik";
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.SystemColors.Menu;
            this.lblStatus.Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(18, 99);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(80, 20);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Status";
            this.lblStatus.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblTanggalMasuk
            // 
            this.lblTanggalMasuk.Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTanggalMasuk.ForeColor = System.Drawing.Color.Black;
            this.lblTanggalMasuk.Location = new System.Drawing.Point(523, 28);
            this.lblTanggalMasuk.Name = "lblTanggalMasuk";
            this.lblTanggalMasuk.Size = new System.Drawing.Size(159, 26);
            this.lblTanggalMasuk.TabIndex = 8;
            this.lblTanggalMasuk.Text = "Tanggal Masuk";
            // 
            // lblJumlah
            // 
            this.lblJumlah.Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJumlah.ForeColor = System.Drawing.Color.Black;
            this.lblJumlah.Location = new System.Drawing.Point(271, 28);
            this.lblJumlah.Name = "lblJumlah";
            this.lblJumlah.Size = new System.Drawing.Size(98, 33);
            this.lblJumlah.TabIndex = 7;
            this.lblJumlah.Text = "Jumlah";
            this.lblJumlah.Click += new System.EventHandler(this.lblJumlah_Click);
            // 
            // lblIdBatch
            // 
            this.lblIdBatch.Enabled = false;
            this.lblIdBatch.Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdBatch.ForeColor = System.Drawing.Color.Black;
            this.lblIdBatch.Location = new System.Drawing.Point(18, 29);
            this.lblIdBatch.Name = "lblIdBatch";
            this.lblIdBatch.Size = new System.Drawing.Size(102, 26);
            this.lblIdBatch.TabIndex = 6;
            this.lblIdBatch.Text = "Id Batch";
            this.lblIdBatch.Click += new System.EventHandler(this.label1_Click);
            // 
            // grpDaftarBatch
            // 
            this.grpDaftarBatch.BackColor = System.Drawing.Color.Transparent;
            this.grpDaftarBatch.Controls.Add(this.button2);
            this.grpDaftarBatch.Controls.Add(this.btnUpdate);
            this.grpDaftarBatch.Controls.Add(this.button1);
            this.grpDaftarBatch.Controls.Add(this.btnKembali);
            this.grpDaftarBatch.Controls.Add(this.dgvBatch);
            this.grpDaftarBatch.Controls.Add(this.btnRefresh);
            this.grpDaftarBatch.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDaftarBatch.ForeColor = System.Drawing.Color.DarkGreen;
            this.grpDaftarBatch.Location = new System.Drawing.Point(21, 325);
            this.grpDaftarBatch.Name = "grpDaftarBatch";
            this.grpDaftarBatch.Size = new System.Drawing.Size(786, 335);
            this.grpDaftarBatch.TabIndex = 14;
            this.grpDaftarBatch.TabStop = false;
            this.grpDaftarBatch.Text = "Daftar Batch";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Ivory;
            this.button2.Location = new System.Drawing.Point(247, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 36);
            this.button2.TabIndex = 15;
            this.button2.Text = "🗑️Hapus";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnUpdate.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Ivory;
            this.btnUpdate.Location = new System.Drawing.Point(119, 281);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(122, 35);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "✏️Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Ivory;
            this.button1.Location = new System.Drawing.Point(-9, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 36);
            this.button1.TabIndex = 15;
            this.button1.Text = "➕Tambah";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BatchLimbah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1047, 733);
            this.Controls.Add(this.grpDaftarBatch);
            this.Controls.Add(this.grpDataBatch);
            this.Controls.Add(this.grpBatchLimbah);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "BatchLimbah";
            this.Text = "BatchLimbah";
            this.Load += new System.EventHandler(this.BatchLimbah_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatch)).EndInit();
            this.grpDataBatch.ResumeLayout(false);
            this.grpDataBatch.PerformLayout();
            this.grpDaftarBatch.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdBatch;
        private System.Windows.Forms.TextBox txtJumlah;
        private System.Windows.Forms.DateTimePicker dtpTanggalMasuk;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtIdPabrik;
        private System.Windows.Forms.DataGridView dgvBatch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.GroupBox grpBatchLimbah;
        private System.Windows.Forms.GroupBox grpDataBatch;
        private System.Windows.Forms.Label lblIdBatch;
        private System.Windows.Forms.Label lblJumlah;
        private System.Windows.Forms.Label lblIdPabrik;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTanggalMasuk;
        private System.Windows.Forms.GroupBox grpDaftarBatch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblIdJadwal;
        private System.Windows.Forms.TextBox txtIdJadwal;
    }
}