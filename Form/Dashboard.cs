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

            switch (currentUser.Role)
            {
                case "Admin":
                    break;

                case "Operator":
                    btnQualityControl.Enabled = false;
                    break;

                case "Quality Control":
                    btnBatchLimbah.Enabled = false;
                    btnJadwal.Enabled = false;
                    btnProduksi.Enabled = false;
                    btnDistribusi.Enabled = false;
                    btnLaporan.Enabled = false;
                    break;

                default:
                    MessageBox.Show("Role tidak dikenali.");
                    Application.Exit();
                    break;
            }
        }

        private void btnBatchLimbah_Click(object sender, EventArgs e)
        {
            if (currentUser.Role == "Quality Control")
            {
                MessageBox.Show("Anda tidak memiliki akses ke menu Batch Limbah!");
                return;
            }

            BatchLimbah frm = new BatchLimbah();
            frm.ShowDialog();
        }

        private void btnJadwal_Click(object sender, EventArgs e)
        {
            if (currentUser.Role == "Quality Control")
            {
                MessageBox.Show("Anda tidak memiliki akses ke menu Jadwal Pengangkutan!");
                return;
            }

            JadwalPengangkutan frm = new JadwalPengangkutan();
            frm.ShowDialog();
        }

        private void btnProduksi_Click(object sender, EventArgs e)
        {
            if (currentUser.Role == "Quality Control")
            {
                MessageBox.Show("Anda tidak memiliki akses ke menu Produksi!");
                return;
            }

            Produksi frm = new Produksi();
            frm.ShowDialog();
        }

        private void btnDistribusi_Click(object sender, EventArgs e)
        {
            if (currentUser.Role == "Quality Control")
            {
                MessageBox.Show("Anda tidak memiliki akses ke menu Distribusi!");
                return;
            }

            Distribusi frm = new Distribusi();
            frm.ShowDialog();
        }

        private void btnQualityControl_Click(object sender, EventArgs e)
        {
            if (currentUser != null && currentUser.Role == "Operator")
            {
                MessageBox.Show("Anda tidak memiliki akses ke menu Quality Control!");
                return;
            }

            KontrolKualitas frm = new KontrolKualitas();
            frm.ShowDialog();
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            FormLaporan frm = new FormLaporan();
            frm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Apakah Anda yakin ingin logout?",
                "Konfirmasi Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Close();
            }
        }
    }
}