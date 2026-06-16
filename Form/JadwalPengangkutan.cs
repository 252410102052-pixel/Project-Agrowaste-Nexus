using AgroWasteNexus.Repositories;
using System;
using System.Windows.Forms;
using ModelJadwalPengangkutan = AgroWasteNexus.Models.JadwalPengangkutan;

namespace AgroWasteNexus.Forms
{
    public partial class JadwalPengangkutan : Form
    {
        private JadwalPengangkutanRepository repository = new JadwalPengangkutanRepository();

        public JadwalPengangkutan()
        {
            InitializeComponent();

            dgvDaftarJadwalPengangkutan.CellClick -= dgvDaftarJadwalPengangkutan_CellClick;
            dgvDaftarJadwalPengangkutan.CellClick += dgvDaftarJadwalPengangkutan_CellClick;

            btnKembali.Click -= btnKembali_Click;
            btnKembali.Click += btnKembali_Click;
        }

        private void JadwalPengangkutan_Load(object sender, EventArgs e)
        {
            LoadStatus();
            LoadPetugas();
            LoadKendaraan();
            LoadData();

            txtIdjadwal.ReadOnly = true;
        }

        private void LoadData()
        {
            try
            {
                dgvDaftarJadwalPengangkutan.AutoGenerateColumns = true;
                dgvDaftarJadwalPengangkutan.DataSource = null;
                dgvDaftarJadwalPengangkutan.DataSource = repository.GetGrid();
                dgvDaftarJadwalPengangkutan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat data jadwal pengangkutan!\n" + ex.Message,
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
                cmbStatus.DataSource = repository.GetStatusJadwal();
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

        private void LoadPetugas()
        {
            try
            {
                cmbPetugas.DataSource = null;
                cmbPetugas.DataSource = repository.GetPetugas();
                cmbPetugas.DisplayMember = "NamaPetugas";
                cmbPetugas.ValueMember = "IdPetugas";
                cmbPetugas.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat petugas!\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void LoadKendaraan()
        {
            try
            {
                cmbKendaraan.DataSource = null;
                cmbKendaraan.DataSource = repository.GetKendaraan();
                cmbKendaraan.DisplayMember = "NamaKendaraan";
                cmbKendaraan.ValueMember = "IdKendaraan";
                cmbKendaraan.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat kendaraan!\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void dgvDaftarJadwalPengangkutan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IsiFormDariGrid(e.RowIndex);
        }

        private void dgvDaftarJadwalPengangkutan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IsiFormDariGrid(e.RowIndex);
        }

        private void IsiFormDariGrid(int rowIndex)
        {
            if (rowIndex < 0)
                return;

            DataGridViewRow row = dgvDaftarJadwalPengangkutan.Rows[rowIndex];

            txtIdjadwal.Text = row.Cells["id_jadwal"].Value?.ToString();

            if (row.Cells["tanggal_pengangkutan"].Value != null)
            {
                dtpTanggalPengangkutan.Value =
                    Convert.ToDateTime(row.Cells["tanggal_pengangkutan"].Value);
            }

            cmbStatus.Text = row.Cells["status_pengangkutan"].Value?.ToString();
            txtCatatan.Text = row.Cells["catatan"].Value?.ToString();

            if (row.Cells["petugas_id_petugas"].Value != null)
            {
                cmbPetugas.SelectedValue =
                    Convert.ToInt32(row.Cells["petugas_id_petugas"].Value);
            }

            if (row.Cells["kendaraan_id_kendaraan"].Value != null)
            {
                cmbKendaraan.SelectedValue =
                    Convert.ToInt32(row.Cells["kendaraan_id_kendaraan"].Value);
            }
        }

        private bool AmbilDataForm(out ModelJadwalPengangkutan data, bool pakaiIdJadwal)
        {
            data = new ModelJadwalPengangkutan();

            if (pakaiIdJadwal)
            {
                if (!int.TryParse(txtIdjadwal.Text, out int idJadwal))
                {
                    MessageBox.Show("Pilih data jadwal terlebih dahulu.");
                    return false;
                }

                data.IdJadwal = idJadwal;
            }

            if (string.IsNullOrWhiteSpace(cmbStatus.Text))
            {
                MessageBox.Show("Pilih status terlebih dahulu.");
                return false;
            }

            if (cmbPetugas.SelectedIndex < 0 || cmbPetugas.SelectedValue == null)
            {
                MessageBox.Show("Pilih petugas terlebih dahulu.");
                return false;
            }

            if (cmbKendaraan.SelectedIndex < 0 || cmbKendaraan.SelectedValue == null)
            {
                MessageBox.Show("Pilih kendaraan terlebih dahulu.");
                return false;
            }

            data.TanggalPengangkutan = dtpTanggalPengangkutan.Value;
            data.Status = cmbStatus.Text;
            data.Catatan = txtCatatan.Text;
            data.IdPetugas = Convert.ToInt32(cmbPetugas.SelectedValue);
            data.IdKendaraan = Convert.ToInt32(cmbKendaraan.SelectedValue);

            return true;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            try
            {
                if (!AmbilDataForm(out ModelJadwalPengangkutan data, false))
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtIdjadwal.Text, out int idJadwal))
                {
                    MessageBox.Show("Pilih data jadwal terlebih dahulu.");
                    return;
                }

                repository.UpdateStatusJadwal(idJadwal, cmbStatus.Text);

                MessageBox.Show("Status jadwal berhasil diupdate.");

                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtIdjadwal.Text, out int idJadwal))
                {
                    MessageBox.Show("Pilih data jadwal yang akan dihapus.");
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

                repository.Delete(idJadwal);

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

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearForm()
        {
            txtIdjadwal.Clear();
            txtCatatan.Clear();

            cmbStatus.SelectedIndex = -1;
            cmbPetugas.SelectedIndex = -1;
            cmbKendaraan.SelectedIndex = -1;
            dtpTanggalPengangkutan.Value = DateTime.Now;
        }

        private void txtIdjadwal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}