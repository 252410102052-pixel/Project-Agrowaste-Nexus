using AgroWasteNexus.Repositories;
using System;
using System.Windows.Forms;

namespace AgroWasteNexus.Forms
{
    public partial class BatchLimbah : Form
    {
        private BatchLimbahRepository repository = new BatchLimbahRepository();

        public BatchLimbah()
        {
            InitializeComponent();
        }

        private void BatchLimbah_Load(object sender, EventArgs e)
        {
            LoadStatus();
            LoadData();
        }

        private void LoadStatus()
        {
            try
            {
                cmbStatus.DataSource = null;
                cmbStatus.DataSource = repository.GetStatusBatch();

                MessageBox.Show(
                    "Jumlah Status : " + repository.GetStatusBatch().Count,
                    "Debug"
                );
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
            dgvBatch.DataSource = repository.GetGridData();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void dgvBatch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBatch.Rows[e.RowIndex];

                txtIdBatch.Text = row.Cells["IdBatch"].Value.ToString();
                txtJumlah.Text = row.Cells["Jumlah"].Value.ToString();
                txtIdPabrik.Text = row.Cells["IdPabrik"].Value.ToString();

                dtpTanggalMasuk.Value =
                    Convert.ToDateTime(row.Cells["TanggalMasuk"].Value);

                cmbStatus.Text =
                    row.Cells["Status"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtIdBatch.Text, out int idBatch)) { MessageBox.Show("ID Batch harus berupa angka."); return; }
                if (!decimal.TryParse(txtJumlah.Text, out decimal jumlah)) { MessageBox.Show("Jumlah harus berupa angka."); return; }
                if (!int.TryParse(txtIdPabrik.Text, out int idPabrik)) { MessageBox.Show("ID Pabrik harus berupa angka."); return; }

                int? idJadwal = null;
                if (!string.IsNullOrEmpty(txtIdJadwal.Text))
                {
                    if (int.TryParse(txtIdJadwal.Text, out int parsedJadwal)) idJadwal = parsedJadwal;
                    else { MessageBox.Show("ID Jadwal harus berupa angka."); return; }
                }

                AgroWasteNexus.Models.BatchLimbah data = new AgroWasteNexus.Models.BatchLimbah();
                data.IdBatch = idBatch;
                data.Jumlah = jumlah;
                data.TanggalMasuk = dtpTanggalMasuk.Value;
                data.Status = cmbStatus.Text;
                data.IdPabrik = idPabrik;
                data.IdJadwal = idJadwal;

                repository.Insert(data);
                MessageBox.Show("Data berhasil ditambahkan");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtIdBatch.Text, out int idBatch))
                {
                    MessageBox.Show("ID Batch harus berupa angka.");
                    return;
                }

                if (!decimal.TryParse(txtJumlah.Text, out decimal jumlah))
                {
                    MessageBox.Show("Jumlah harus berupa angka.");
                    return;
                }

                if (!int.TryParse(txtIdPabrik.Text, out int idPabrik))
                {
                    MessageBox.Show("ID Pabrik harus berupa angka.");
                    return;
                }

                AgroWasteNexus.Models.BatchLimbah data =
                    new AgroWasteNexus.Models.BatchLimbah();

                data.IdBatch = idBatch;
                data.Jumlah = jumlah;
                data.TanggalMasuk = dtpTanggalMasuk.Value;
                data.Status = cmbStatus.Text;
                data.IdPabrik = idPabrik;

                repository.Update(data);

                MessageBox.Show("Data berhasil diupdate");

                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtIdBatch.Text, out int idBatch))
                {
                    MessageBox.Show("ID Batch harus berupa angka.");
                    return;
                }

                repository.Delete(idBatch);

                MessageBox.Show("Data berhasil dihapus");

                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
    }
}