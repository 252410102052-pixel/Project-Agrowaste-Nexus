namespace AgroWasteNexus.Forms
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.grpMenu = new System.Windows.Forms.GroupBox();
            this.btnGrafik = new System.Windows.Forms.Button();
            this.btnLaporan = new System.Windows.Forms.Button();
            this.lblMenuUtama = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnQualityControl = new System.Windows.Forms.Button();
            this.btnDistribusi = new System.Windows.Forms.Button();
            this.btnProduksi = new System.Windows.Forms.Button();
            this.btnJadwal = new System.Windows.Forms.Button();
            this.btnBatchLimbah = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTittle = new System.Windows.Forms.Label();
            this.lblSubtittle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.grpMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMenu
            // 
            this.grpMenu.BackColor = System.Drawing.Color.Transparent;
            this.grpMenu.Controls.Add(this.btnGrafik);
            this.grpMenu.Controls.Add(this.btnLaporan);
            this.grpMenu.Controls.Add(this.lblMenuUtama);
            this.grpMenu.Controls.Add(this.btnLogout);
            this.grpMenu.Controls.Add(this.btnQualityControl);
            this.grpMenu.Controls.Add(this.btnDistribusi);
            this.grpMenu.Controls.Add(this.btnProduksi);
            this.grpMenu.Controls.Add(this.btnJadwal);
            this.grpMenu.Controls.Add(this.btnBatchLimbah);
            this.grpMenu.Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMenu.ForeColor = System.Drawing.Color.DarkGreen;
            this.grpMenu.Location = new System.Drawing.Point(63, 235);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(1012, 353);
            this.grpMenu.TabIndex = 5;
            this.grpMenu.TabStop = false;
            this.grpMenu.Text = "Menu Utama";
            // 
            // btnGrafik
            // 
            this.btnGrafik.Location = new System.Drawing.Point(769, 170);
            this.btnGrafik.Name = "btnGrafik";
            this.btnGrafik.Size = new System.Drawing.Size(176, 61);
            this.btnGrafik.TabIndex = 10;
            this.btnGrafik.Text = "📈 GRAFIK";
            this.btnGrafik.UseVisualStyleBackColor = true;
            this.btnGrafik.Click += new System.EventHandler(this.btnGrafik_Click);
            // 
            // btnLaporan
            // 
            this.btnLaporan.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaporan.Location = new System.Drawing.Point(502, 169);
            this.btnLaporan.Name = "btnLaporan";
            this.btnLaporan.Size = new System.Drawing.Size(229, 61);
            this.btnLaporan.TabIndex = 9;
            this.btnLaporan.Text = "📊 LAPORAN";
            this.btnLaporan.UseVisualStyleBackColor = true;
            this.btnLaporan.Click += new System.EventHandler(this.btnLaporan_Click);
            // 
            // lblMenuUtama
            // 
            this.lblMenuUtama.BackColor = System.Drawing.Color.DarkGreen;
            this.lblMenuUtama.ForeColor = System.Drawing.Color.Ivory;
            this.lblMenuUtama.Location = new System.Drawing.Point(0, 0);
            this.lblMenuUtama.Name = "lblMenuUtama";
            this.lblMenuUtama.Size = new System.Drawing.Size(1012, 33);
            this.lblMenuUtama.TabIndex = 7;
            this.lblMenuUtama.Text = "MENU UTAMA";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(390, 264);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(179, 58);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "🚪 LOG OUT";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnQualityControl
            // 
            this.btnQualityControl.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQualityControl.Location = new System.Drawing.Point(661, 72);
            this.btnQualityControl.Name = "btnQualityControl";
            this.btnQualityControl.Size = new System.Drawing.Size(284, 61);
            this.btnQualityControl.TabIndex = 4;
            this.btnQualityControl.Text = "🔍 QUALITY CONTROL";
            this.btnQualityControl.UseVisualStyleBackColor = true;
            this.btnQualityControl.Click += new System.EventHandler(this.btnQualityControl_Click);
            // 
            // btnDistribusi
            // 
            this.btnDistribusi.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDistribusi.Location = new System.Drawing.Point(248, 169);
            this.btnDistribusi.Name = "btnDistribusi";
            this.btnDistribusi.Size = new System.Drawing.Size(229, 61);
            this.btnDistribusi.TabIndex = 3;
            this.btnDistribusi.Text = "📦 DISTRIBUSI";
            this.btnDistribusi.UseVisualStyleBackColor = true;
            this.btnDistribusi.Click += new System.EventHandler(this.btnDistribusi_Click);
            // 
            // btnProduksi
            // 
            this.btnProduksi.Location = new System.Drawing.Point(21, 169);
            this.btnProduksi.Name = "btnProduksi";
            this.btnProduksi.Size = new System.Drawing.Size(204, 61);
            this.btnProduksi.TabIndex = 2;
            this.btnProduksi.Text = "⚙ PRODUKSI";
            this.btnProduksi.UseVisualStyleBackColor = true;
            this.btnProduksi.Click += new System.EventHandler(this.btnProduksi_Click);
            // 
            // btnJadwal
            // 
            this.btnJadwal.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJadwal.Location = new System.Drawing.Point(321, 73);
            this.btnJadwal.Name = "btnJadwal";
            this.btnJadwal.Size = new System.Drawing.Size(303, 60);
            this.btnJadwal.TabIndex = 1;
            this.btnJadwal.Text = "🚚 PENGANGKUTAN";
            this.btnJadwal.UseVisualStyleBackColor = true;
            this.btnJadwal.Click += new System.EventHandler(this.btnJadwal_Click);
            // 
            // btnBatchLimbah
            // 
            this.btnBatchLimbah.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatchLimbah.Location = new System.Drawing.Point(21, 72);
            this.btnBatchLimbah.Name = "btnBatchLimbah";
            this.btnBatchLimbah.Size = new System.Drawing.Size(259, 60);
            this.btnBatchLimbah.TabIndex = 0;
            this.btnBatchLimbah.Text = "🗑 DATA LIMBAH";
            this.btnBatchLimbah.UseVisualStyleBackColor = true;
            this.btnBatchLimbah.Click += new System.EventHandler(this.btnBatchLimbah_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 650);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1163, 32);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(181, 25);
            this.lblStatus.Text = "Status sistem : Online";
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.BackColor = System.Drawing.Color.Transparent;
            this.lblTittle.Font = new System.Drawing.Font("Century", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTittle.Location = new System.Drawing.Point(241, 22);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(463, 47);
            this.lblTittle.TabIndex = 7;
            this.lblTittle.Text = "AGROWASTE NEXUS";
            // 
            // lblSubtittle
            // 
            this.lblSubtittle.AutoSize = true;
            this.lblSubtittle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtittle.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtittle.Location = new System.Drawing.Point(269, 85);
            this.lblSubtittle.Name = "lblSubtittle";
            this.lblSubtittle.Size = new System.Drawing.Size(388, 28);
            this.lblSubtittle.TabIndex = 8;
            this.lblSubtittle.Text = "Sistem Pengelolaan Limbah Tebu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "----------------------------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(476, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 33);
            this.label2.TabIndex = 10;
            this.label2.Text = "----------------------------";
            // 
            // lblWelcome
            // 
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(330, 134);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(306, 29);
            this.lblWelcome.TabIndex = 11;
            this.lblWelcome.Text = "SELAMAT DATANG";
            // 
            // lblRole
            // 
            this.lblRole.BackColor = System.Drawing.Color.Transparent;
            this.lblRole.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(224, 175);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(306, 29);
            this.lblRole.TabIndex = 12;
            this.lblRole.Text = "ROLE:";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1163, 682);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSubtittle);
            this.Controls.Add(this.lblTittle);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grpMenu);
            this.Name = "Dashboard";
            this.Text = "AGROWASTE NEXUS";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.grpMenu.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpMenu;
        private System.Windows.Forms.Button btnBatchLimbah;
        private System.Windows.Forms.Button btnQualityControl;
        private System.Windows.Forms.Button btnDistribusi;
        private System.Windows.Forms.Button btnProduksi;
        private System.Windows.Forms.Button btnJadwal;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Label lblMenuUtama;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Label lblSubtittle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Button btnLaporan;
        private System.Windows.Forms.Button btnGrafik;
    }
}