using AgroWasteNexus.Models;
using System;
using System.Windows.Forms;

namespace AgroWasteNexus.Forms
{
    public partial class Dashboard : Form
    {
        private Pengguna currentUser;

        public Dashboard()
        {
            InitializeComponent();
        }

        public Dashboard(Pengguna user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            if (currentUser == null)
                return;

            lblWelcome.Text = "Selamat Datang : " + currentUser.Username;
            lblRole.Text = "ROLE : " + currentUser.Role;

            AturAksesMenu();
        }

        private void AturAksesMenu()
        {
            string role = currentUser.Role.Trim().ToLower();

            if (role == "admin")
            {
                btnBatchLimbah.Enabled = true;
                btnJadwal.Enabled = true;
                btnProduksi.Enabled = true;
                btnDistribusi.Enabled = true;
                btnQualityControl.Enabled = true;
                btnLaporan.Enabled = true;
            }
            else if (role == "operator")
            {
                btnBatchLimbah.Enabled = true;
                btnJadwal.Enabled = true;
                btnProduksi.Enabled = true;
                btnDistribusi.Enabled = true;
                btnQualityControl.Enabled = false;
                btnLaporan.Enabled = true;
            }
            else if (role == "quality control" || role == "qc")
            {
                btnBatchLimbah.Enabled = false;
                btnJadwal.Enabled = false;
                btnProduksi.Enabled = true;
                btnDistribusi.Enabled = false;
                btnQualityControl.Enabled = true;
                btnLaporan.Enabled = true;
            }
            else
            {
                MessageBox.Show("Role tidak dikenali.");
                Application.Exit();
            }
        }

        private bool BisaAkses(string menu)
        {
            if (currentUser == null)
                return false;

            string role = currentUser.Role.Trim().ToLower();

            if (role == "admin")
                return true;

            if (role == "operator")
            {
                return menu != "quality_control";
            }

            if (role == "quality control" || role == "qc")
            {
                return menu == "quality_control" ||
                       menu == "produksi" ||
                       menu == "laporan";
            }

            return false;
        }

        private void TampilkanPesanTidakAdaAkses(string namaMenu)
        {
            MessageBox.Show(
                "Anda tidak memiliki akses ke menu " + namaMenu + "!",
                "Akses Ditolak",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
        }

        private void btnBatchLimbah_Click(object sender, EventArgs e)
        {
            if (!BisaAkses("batch_limbah"))
            {
                TampilkanPesanTidakAdaAkses("Batch Limbah");
                return;
            }

            BatchLimbah frm = new BatchLimbah();
            frm.ShowDialog();
        }

        private void btnJadwal_Click(object sender, EventArgs e)
        {
            if (!BisaAkses("jadwal"))
            {
                TampilkanPesanTidakAdaAkses("Jadwal Pengangkutan");
                return;
            }

            JadwalPengangkutan frm = new JadwalPengangkutan();
            frm.ShowDialog();
        }

        private void btnProduksi_Click(object sender, EventArgs e)
        {
            if (!BisaAkses("produksi"))
            {
                TampilkanPesanTidakAdaAkses("Produksi");
                return;
            }

            Produksi frm = new Produksi();
            frm.ShowDialog();
        }

        private void btnDistribusi_Click(object sender, EventArgs e)
        {
            if (!BisaAkses("distribusi"))
            {
                TampilkanPesanTidakAdaAkses("Distribusi");
                return;
            }

            Distribusi frm = new Distribusi();
            frm.ShowDialog();
        }

        private void btnQualityControl_Click(object sender, EventArgs e)
        {
            if (!BisaAkses("quality_control"))
            {
                TampilkanPesanTidakAdaAkses("Quality Control");
                return;
            }

            KontrolKualitas frm = new KontrolKualitas();
            frm.ShowDialog();
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            if (!BisaAkses("laporan"))
            {
                TampilkanPesanTidakAdaAkses("Laporan");
                return;
            }

            FormLaporan frm = new FormLaporan();
            frm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Apakah Anda yakin ingin logout?",
                "Konfirmasi Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Close();
            }
        }

        private void btnGrafik_Click(object sender, EventArgs e)
        {
            if (!BisaAkses("laporan"))
            {
                TampilkanPesanTidakAdaAkses("Grafik Dashboard");
                return;
            }

            GrafikDashboard frm = new GrafikDashboard();
            frm.ShowDialog();
        }
    }
}