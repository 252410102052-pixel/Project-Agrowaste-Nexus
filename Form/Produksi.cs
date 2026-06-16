using AgroWasteNexus.Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AgroWasteNexus.Forms
{
    public partial class Produksi : Form
    {
        private ProduksiRepository repository = new ProduksiRepository();

        public Produksi()
        {
            InitializeComponent();

            btnTambah.Click -= btnTambah_Click;
            btnTambah.Click += btnTambah_Click;

            btnUpdate.Click -= btnUpdate_Click;
            btnUpdate.Click += btnUpdate_Click;

            btnHapus.Click -= btnHapus_Click;
            btnHapus.Click += btnHapus_Click;

            btnKembali.Click -= btnKembali_Click;
            btnKembali.Click += btnKembali_Click;

            dgvDaftarProduksi.CellClick -= dgvDaftarProduksi_CellClick;
            dgvDaftarProduksi.CellClick += dgvDaftarProduksi_CellClick;
        }

        private void Produksi_Load(object sender, EventArgs e)
        {
            LoadStatus();
            LoadProdukDariGrid();
            LoadData();

            txtIdProduksi.ReadOnly = true;
        }

        private void LoadData()
        {
            try
            {
                dgvDaftarProduksi.AutoGenerateColumns = true;
                dgvDaftarProduksi.DataSource = null;
                dgvDaftarProduksi.DataSource = repository.GetGrid();

                if (dgvDaftarProduksi.Columns.Contains("gambar_produk"))
                {
                    dgvDaftarProduksi.Columns["gambar_produk"].Visible = false;
                }

                if (dgvDaftarProduksi.Columns.Contains("foto_produk"))
                {
                    dgvDaftarProduksi.Columns["foto_produk"].HeaderText = "Foto Produk";
                    dgvDaftarProduksi.RowTemplate.Height = 90;

                    DataGridViewImageColumn imgCol =
                        dgvDaftarProduksi.Columns["foto_produk"] as DataGridViewImageColumn;

                    if (imgCol != null)
                    {
                        imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    }
                }

                dgvDaftarProduksi.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat data produksi!\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void LoadStatus()
        {
            try
            {
                cmbStatus.DataSource = null;
                cmbStatus.DataSource = repository.GetStatusProduksi();
                cmbStatus.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat status!\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void LoadProdukDariGrid()
        {
            try
            {
                var gridData = repository.GetGrid();

                List<ProdukItem> produkList = new List<ProdukItem>();
                HashSet<int> idProdukYangSudahAda = new HashSet<int>();

                foreach (var item in gridData)
                {
                    if (!idProdukYangSudahAda.Contains(item.id_produk))
                    {
                        produkList.Add(new ProdukItem
                        {
                            IdProduk = item.id_produk,
                            NamaProduk = item.nama_produk
                        });

                        idProdukYangSudahAda.Add(item.id_produk);
                    }
                }

                cmbHasilProduksi.DataSource = null;
                cmbHasilProduksi.DataSource = produkList;
                cmbHasilProduksi.DisplayMember = "NamaProduk";
                cmbHasilProduksi.ValueMember = "IdProduk";
                cmbHasilProduksi.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat hasil produksi!\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void dgvDaftarProduksi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IsiFormDariGrid(e.RowIndex);
        }

        private void dgvDaftarProduksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IsiFormDariGrid(e.RowIndex);
        }

        private void IsiFormDariGrid(int rowIndex)
        {
            if (rowIndex < 0)
                return;

            DataGridViewRow row = dgvDaftarProduksi.Rows[rowIndex];

            txtIdProduksi.Text = row.Cells["id_produksi"].Value?.ToString();
            txtIdBatch.Text = row.Cells["id_batch_asal"].Value?.ToString();
            txtJumlahBahan.Text = row.Cells["bahan_baku_kg"].Value?.ToString();
            txtJumlahHasil.Text = row.Cells["target_hasil_kg"].Value?.ToString();
            txtBiayaProduksi.Text = row.Cells["biaya_produksi"].Value?.ToString();

            if (row.Cells["tanggal_produksi"].Value != null)
            {
                dtpTanggalProduksi.Value =
                    Convert.ToDateTime(row.Cells["tanggal_produksi"].Value);
            }

            cmbStatus.Text = row.Cells["status_produksi"].Value?.ToString();

            if (row.Cells["id_produk"].Value != null)
            {
                cmbHasilProduksi.SelectedValue =
                    Convert.ToInt32(row.Cells["id_produk"].Value);
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtIdBatch.Text, out int idBatch))
                {
                    MessageBox.Show("ID Batch harus berupa angka.");
                    return;
                }

                if (!decimal.TryParse(txtJumlahBahan.Text, out decimal jumlahBahan))
                {
                    MessageBox.Show("Jumlah bahan harus berupa angka.");
                    return;
                }

                if (!decimal.TryParse(txtJumlahHasil.Text, out decimal jumlahHasil))
                {
                    MessageBox.Show("Jumlah hasil harus berupa angka.");
                    return;
                }

                if (!decimal.TryParse(txtBiayaProduksi.Text, out decimal biayaProduksi))
                {
                    MessageBox.Show("Biaya produksi harus berupa angka.");
                    return;
                }

                if (cmbHasilProduksi.SelectedIndex < 0 || cmbHasilProduksi.SelectedValue == null)
                {
                    MessageBox.Show("Pilih hasil produksi terlebih dahulu.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(cmbStatus.Text))
                {
                    MessageBox.Show("Pilih status terlebih dahulu.");
                    return;
                }

                AgroWasteNexus.Models.Produksi data = new AgroWasteNexus.Models.Produksi();

                data.JumlahBahan = jumlahBahan;
                data.JumlahHasil = jumlahHasil;
                data.BiayaProduksi = biayaProduksi;
                data.TanggalProduksi = dtpTanggalProduksi.Value;
                data.Status = cmbStatus.Text;
                data.IdBatch = idBatch;
                data.IdProduk = Convert.ToInt32(cmbHasilProduksi.SelectedValue);
                data.IdPengguna = 1;

                repository.Insert(data);

                MessageBox.Show("Data berhasil ditambahkan");

                LoadProdukDariGrid();
                LoadData();
                ClearForm();
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
                if (!int.TryParse(txtIdProduksi.Text, out int idProduksi))
                {
                    MessageBox.Show("Pilih data produksi yang akan diupdate.");
                    return;
                }

                if (!int.TryParse(txtIdBatch.Text, out int idBatch))
                {
                    MessageBox.Show("ID Batch harus berupa angka.");
                    return;
                }

                if (!decimal.TryParse(txtJumlahBahan.Text, out decimal jumlahBahan))
                {
                    MessageBox.Show("Jumlah bahan harus berupa angka.");
                    return;
                }

                if (!decimal.TryParse(txtJumlahHasil.Text, out decimal jumlahHasil))
                {
                    MessageBox.Show("Jumlah hasil harus berupa angka.");
                    return;
                }

                if (!decimal.TryParse(txtBiayaProduksi.Text, out decimal biayaProduksi))
                {
                    MessageBox.Show("Biaya produksi harus berupa angka.");
                    return;
                }

                if (cmbHasilProduksi.SelectedIndex < 0 || cmbHasilProduksi.SelectedValue == null)
                {
                    MessageBox.Show("Pilih hasil produksi terlebih dahulu.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(cmbStatus.Text))
                {
                    MessageBox.Show("Pilih status terlebih dahulu.");
                    return;
                }

                AgroWasteNexus.Models.Produksi data = new AgroWasteNexus.Models.Produksi();

                data.IdProduksi = idProduksi;
                data.JumlahBahan = jumlahBahan;
                data.JumlahHasil = jumlahHasil;
                data.BiayaProduksi = biayaProduksi;
                data.TanggalProduksi = dtpTanggalProduksi.Value;
                data.Status = cmbStatus.Text;
                data.IdBatch = idBatch;
                data.IdProduk = Convert.ToInt32(cmbHasilProduksi.SelectedValue);
                data.IdPengguna = 1;

                repository.Update(data);

                MessageBox.Show("Data berhasil diupdate");

                LoadProdukDariGrid();
                LoadData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal update data!\n" + ex.Message,
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
                if (!int.TryParse(txtIdProduksi.Text, out int idProduksi))
                {
                    MessageBox.Show("Pilih data produksi yang akan dihapus.");
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

                repository.Delete(idProduksi);

                MessageBox.Show("Data berhasil dihapus");

                LoadProdukDariGrid();
                LoadData();
                ClearForm();
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
            txtIdProduksi.Clear();
            txtIdBatch.Clear();
            txtJumlahBahan.Clear();
            txtJumlahHasil.Clear();
            txtBiayaProduksi.Clear();

            cmbHasilProduksi.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
            dtpTanggalProduksi.Value = DateTime.Now;
        }

        private class ProdukItem
        {
            public int IdProduk { get; set; }
            public string NamaProduk { get; set; }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblJumlahHasil_Click(object sender, EventArgs e)
        {

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }
    }
}