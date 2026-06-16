using AgroWasteNexus.Repositories;
using System;
using System.Windows.Forms;

namespace AgroWasteNexus.Forms
{
    public partial class FormLaporan : Form
    {
        private FormLaporanRepository repository = new FormLaporanRepository();

        public FormLaporan()
        {
            InitializeComponent();

            this.Load -= FormLaporan_Load;
            this.Load += FormLaporan_Load;

            btnTampilkan.Click -= btnTampilkan_Click;
            btnTampilkan.Click += btnTampilkan_Click;

            btnKembali.Click -= btnKembali_Click;
            btnKembali.Click += btnKembali_Click;
        }

        private void FormLaporan_Load(object sender, EventArgs e)
        {
            dtpAwal.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpAkhir.Value = DateTime.Now;

            dgvLaporan.AutoGenerateColumns = true;
            dgvLaporan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            btnKembali.Text = "Kembali";
            btnKembali.ForeColor = System.Drawing.Color.DarkGreen;
            btnKembali.BackColor = System.Drawing.Color.White;
            btnKembali.UseVisualStyleBackColor = false;
        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime tanggalAwal = dtpAwal.Value.Date;
                DateTime tanggalAkhir = dtpAkhir.Value.Date;

                if (tanggalAwal > tanggalAkhir)
                {
                    MessageBox.Show(
                        "Tanggal awal tidak boleh lebih besar dari tanggal akhir.",
                        "Peringatan",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                dgvLaporan.DataSource = null;
                dgvLaporan.DataSource = repository.GetLaporanPeriode(tanggalAwal, tanggalAkhir);
                dgvLaporan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal menampilkan laporan!\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}