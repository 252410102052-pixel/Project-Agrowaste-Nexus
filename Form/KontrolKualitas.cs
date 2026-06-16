using AgroWasteNexus.Repositories;
using System;
using System.Windows.Forms;
using ModelKontrolKualitas = AgroWasteNexus.Models.KontrolKualitas;

namespace AgroWasteNexus.Forms
{
    public partial class KontrolKualitas : Form
    {
        private KontrolKualitasRepository repository =
            new KontrolKualitasRepository();

        public KontrolKualitas()
        {
            InitializeComponent();

            this.Load -= KontrolKualitas_Load;
            this.Load += KontrolKualitas_Load;

            btnTambah.Click -= btnTambah_Click;
            btnTambah.Click += btnTambah_Click;

            btnUpdate.Click -= btnUpdate_Click;
            btnUpdate.Click += btnUpdate_Click;

            btnHapus.Click -= btnHapus_Click;
            btnHapus.Click += btnHapus_Click;

            btnKembali.Click -= btnKembali_Click;
            btnKembali.Click += btnKembali_Click;

            dataGridView1.CellClick -= dataGridView1_CellClick;
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void KontrolKualitas_Load(object sender, EventArgs e)
        {
            txtIdKontrol.ReadOnly = true;
            txtIdProduksi.ReadOnly = true;

            LoadData();
            IsiIdProduksiOtomatis();

            btnKembali.Text = "← Kembali";
            btnKembali.ForeColor = System.Drawing.Color.DarkGreen;
            btnKembali.BackColor = System.Drawing.Color.White;
            btnKembali.Font = new System.Drawing.Font(
                "Century",
                9F,
                System.Drawing.FontStyle.Bold
            );
            btnKembali.UseVisualStyleBackColor = false;
        }

        private void LoadData()
        {
            try
            {
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = repository.GetGrid();
                dataGridView1.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat data kontrol kualitas!\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void IsiIdProduksiOtomatis()
        {
            try
            {
                int? idProduksi = repository.GetProduksiBelumQc();

                if (idProduksi.HasValue)
                {
                    txtIdProduksi.Text = idProduksi.Value.ToString();
                }
                else
                {
                    txtIdProduksi.Clear();
                    MessageBox.Show(
                        "Tidak ada data produksi yang belum memiliki kontrol kualitas."
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal mengambil ID produksi otomatis!\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IsiFormDariGrid(e.RowIndex);
        }

        private void IsiFormDariGrid(int rowIndex)
        {
            if (rowIndex < 0)
                return;

            DataGridViewRow row = dataGridView1.Rows[rowIndex];

            txtIdKontrol.Text =
                row.Cells["id_kontrol"].Value?.ToString();

            txtIdProduksi.Text =
                row.Cells["produksi_id_produksi"].Value?.ToString();

            txtNilaiKualitas.Text =
                row.Cells["nilai_kualitas"].Value?.ToString();

            txtJumlahLolos.Text =
                row.Cells["jumlah_lolos"].Value?.ToString();

            txtJumlahGagal.Text =
                row.Cells["jumlah_gagal"].Value?.ToString();

            txtCatatan.Text =
                row.Cells["catatan"].Value?.ToString();

            if (row.Cells["tanggal_pemeriksaan"].Value != null)
            {
                dtpTanggalPemeriksaan.Value =
                    Convert.ToDateTime(row.Cells["tanggal_pemeriksaan"].Value);
            }
        }

        private bool AmbilDataForm(
            out ModelKontrolKualitas data,
            bool pakaiIdKontrol)
        {
            data = new ModelKontrolKualitas();

            if (pakaiIdKontrol)
            {
                if (!int.TryParse(txtIdKontrol.Text, out int idKontrol))
                {
                    MessageBox.Show("Pilih data kontrol kualitas terlebih dahulu.");
                    return false;
                }

                data.IdKontrol = idKontrol;
            }

            if (!int.TryParse(txtIdProduksi.Text, out int idProduksi))
            {
                MessageBox.Show(
                    "ID Produksi belum tersedia. Pastikan ada data produksi yang belum memiliki QC."
                );
                return false;
            }

            if (!decimal.TryParse(txtJumlahLolos.Text, out decimal jumlahLolos))
            {
                MessageBox.Show("Jumlah lolos harus berupa angka.");
                return false;
            }

            if (!decimal.TryParse(txtJumlahGagal.Text, out decimal jumlahGagal))
            {
                MessageBox.Show("Jumlah gagal harus berupa angka.");
                return false;
            }

            if (!int.TryParse(txtNilaiKualitas.Text, out int nilaiKualitas))
            {
                MessageBox.Show("Nilai kualitas harus berupa angka bulat, misalnya 85 atau 90.");
                return false;
            }

            if (nilaiKualitas < 0 || nilaiKualitas > 100)
            {
                MessageBox.Show("Nilai kualitas harus berada antara 0 sampai 100.");
                return false;
            }

            data.IdProduksi = idProduksi;
            data.JumlahLolos = jumlahLolos;
            data.JumlahGagal = jumlahGagal;
            data.NilaiKualitas = nilaiKualitas;
            data.Catatan = txtCatatan.Text;
            data.TanggalPemeriksaan = dtpTanggalPemeriksaan.Value;
            data.IdPengguna = 1;

            return true;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            try
            {
                if (!AmbilDataForm(out ModelKontrolKualitas data, false))
                    return;

                if (repository.ProduksiSudahPunyaQc(data.IdProduksi))
                {
                    MessageBox.Show(
                        "Produksi ini sudah memiliki data kontrol kualitas."
                    );
                    return;
                }

                repository.Insert(data);

                MessageBox.Show("Data kontrol kualitas berhasil ditambahkan.");

                LoadData();
                ClearForm();
                IsiIdProduksiOtomatis();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal menambah data!\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!AmbilDataForm(out ModelKontrolKualitas data, true))
                    return;

                repository.FinalisasiQcTotal(
                    data.IdKontrol,
                    data.IdProduksi,
                    data.JumlahLolos,
                    data.JumlahGagal,
                    data.NilaiKualitas,
                    data.TanggalPemeriksaan,
                    data.Catatan
                );

                MessageBox.Show(
                    "Data kontrol kualitas berhasil diupdate dan difinalisasi."
                );

                LoadData();
                ClearForm();
                IsiIdProduksiOtomatis();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal update kontrol kualitas!\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtIdKontrol.Text, out int idKontrol))
                {
                    MessageBox.Show("Pilih data kontrol kualitas yang akan dihapus.");
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Yakin ingin menghapus data ini?",
                    "Konfirmasi",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.No)
                    return;

                repository.Delete(idKontrol);

                MessageBox.Show("Data berhasil dihapus.");

                LoadData();
                ClearForm();
                IsiIdProduksiOtomatis();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal menghapus data!\n" + ex.Message,
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

        private void ClearForm()
        {
            txtIdKontrol.Clear();
            txtIdProduksi.Clear();
            txtNilaiKualitas.Clear();
            txtJumlahLolos.Clear();
            txtJumlahGagal.Clear();
            txtCatatan.Clear();

            dtpTanggalPemeriksaan.Value = DateTime.Now;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}