using AgroWasteNexus.Repositories;
using System;
using System.Windows.Forms;

namespace AgroWasteNexus.Forms
{
    public partial class JadwalPengangkutan : Form
    {
        private JadwalPengangkutanRepository repository =
            new JadwalPengangkutanRepository();

        public JadwalPengangkutan()
        {
            InitializeComponent();
        }

        private void JadwalPengangkutan_Load(object sender, EventArgs e)
        {
            try
            {
                LoadStatus();
                LoadPetugas();
                LoadKendaraan();
                LoadDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error saat membuka form:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void LoadPetugas()
        {
            cmbPetugas.DataSource = repository.GetPetugas();
            cmbPetugas.DisplayMember = "nama_petugas";
            cmbPetugas.ValueMember = "id_petugas";
        }

        private void LoadKendaraan()
        {
            cmbKendaraan.DataSource = repository.GetKendaraan();
            cmbKendaraan.DisplayMember = "nama_kendaraan";
            cmbKendaraan.ValueMember = "id_kendaraan";
        }

        private void LoadStatus()
        {
            cmbStatus.DataSource = null;
            cmbStatus.DataSource = repository.GetStatusJadwal();
        }
        private void LoadDataGrid()
        {
            dgvDaftarJadwalPengangkutan.AutoGenerateColumns = true;
            dgvDaftarJadwalPengangkutan.DataSource = null;
            dgvDaftarJadwalPengangkutan.DataSource = repository.GetAll();
        }

        private void txtIdBatch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdjadwal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKembali_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {

        }

        private void dgvDaftarJadwalPengangkutan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}