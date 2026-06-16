using AgroWasteNexus.Repositories;
using System;
using System.Windows.Forms;
using ModelBatchLimbah = AgroWasteNexus.Models.BatchLimbah;

namespace AgroWasteNexus.Forms
{
    public partial class BatchLimbah : Form
    {
        private BatchLimbahRepository repository = new BatchLimbahRepository();

        public BatchLimbah()
        {
            InitializeComponent();

            dgvBatch.CellClick -= dgvBatch_CellClick;
            dgvBatch.CellClick += dgvBatch_CellClick;
        }

        private void BatchLimbah_Load(object sender, EventArgs e)
        {
            LoadStatus();
            LoadData();

            txtIdBatch.ReadOnly = true;
            txtIdJadwal.ReadOnly = true;

            txtIdBatch.Clear();
            txtIdJadwal.Clear();
        }

        private void LoadStatus()
        {
            try
            {
                cmbStatus.DataSource = null;
                cmbStatus.DataSource = repository.GetStatusBatch();
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

        private void LoadData()
        {
            try
            {
                dgvBatch.AutoGenerateColumns = true;
                dgvBatch.DataSource = null;
                dgvBatch.DataSource = repository.GetGrid();
                dgvBatch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat data batch!\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void dgvBatch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IsiFormDariGrid(e.RowIndex);
        }

        private void IsiFormDariGrid(int rowIndex)
        {
            if (rowIndex < 0)
                return;

            DataGridViewRow row = dgvBatch.Rows[rowIndex];

            txtIdBatch.Text = row.Cells["id_batch"].Value?.ToString();
            txtJumlah.Text = row.Cells["volume_kg"].Value?.ToString();
            txtIdPabrik.Text = row.Cells["pabrik_id_pabrik"].Value?.ToString();

            if (row.Cells["jadwal_pengangkutan_id_jadwal"].Value == null ||
                row.Cells["jadwal_pengangkutan_id_jadwal"].Value == DBNull.Value)
            {
                txtIdJadwal.Clear();
            }
            else
            {
                txtIdJadwal.Text = row.Cells["jadwal_pengangkutan_id_jadwal"].Value?.ToString();
            }

            if (row.Cells["tanggal_masuk"].Value != null &&
                row.Cells["tanggal_masuk"].Value != DBNull.Value)
            {
                dtpTanggalMasuk.Value =
                    Convert.ToDateTime(row.Cells["tanggal_masuk"].Value);
            }

            cmbStatus.Text = row.Cells["status_batch"].Value?.ToString();
        }

        private bool AmbilDataForm(out ModelBatchLimbah data, bool pakaiIdBatch)
        {
            data = new ModelBatchLimbah();

            if (pakaiIdBatch)
            {
                if (!int.TryParse(txtIdBatch.Text, out int idBatch))
                {
                    MessageBox.Show("Pilih data batch terlebih dahulu.");
                    return false;
                }

                data.IdBatch = idBatch;
            }

            if (!decimal.TryParse(txtJumlah.Text, out decimal jumlah))
            {
                MessageBox.Show("Jumlah harus berupa angka.");
                return false;
            }

            if (!int.TryParse(txtIdPabrik.Text, out int idPabrik))
            {
                MessageBox.Show("ID Pabrik harus berupa angka.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(cmbStatus.Text))
            {
                MessageBox.Show("Pilih status terlebih dahulu.");
                return false;
            }

            data.Jumlah = jumlah;
            data.TanggalMasuk = dtpTanggalMasuk.Value;
            data.Status = cmbStatus.Text;
            data.IdPabrik = idPabrik;
            data.Keterangan = "";

            if (pakaiIdBatch)
            {
                if (string.IsNullOrWhiteSpace(txtIdJadwal.Text))
                {
                    data.IdJadwal = null;
                }
                else
                {
                    if (!int.TryParse(txtIdJadwal.Text, out int idJadwal))
                    {
                        MessageBox.Show("ID Jadwal tidak valid.");
                        return false;
                    }

                    data.IdJadwal = idJadwal;
                }
            }
            else
            {
                data.IdJadwal = null;
            }

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!AmbilDataForm(out ModelBatchLimbah data, false))
                    return;

                repository.Insert(data);

                MessageBox.Show("Data berhasil ditambahkan");

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

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!AmbilDataForm(out ModelBatchLimbah data, true))
                    return;

                repository.Update(data);

                MessageBox.Show("Data berhasil diupdate");

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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtIdBatch.Text, out int idBatch))
                {
                    MessageBox.Show("Pilih data batch yang akan dihapus.");
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

                repository.Delete(idBatch);

                MessageBox.Show("Data berhasil dihapus");

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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearForm()
        {
            txtIdBatch.Clear();
            txtJumlah.Clear();
            txtIdPabrik.Clear();
            txtIdJadwal.Clear();

            cmbStatus.SelectedIndex = -1;
            dtpTanggalMasuk.Value = DateTime.Now;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblJumlah_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtIdPabrik_TextChanged(object sender, EventArgs e)
        {

        }
    }
}