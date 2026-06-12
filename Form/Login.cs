using AgroWasteNexus.Models;
using AgroWasteNexus.Repositories;
using System;
using System.Windows.Forms;

namespace AgroWasteNexus.Forms
{
    public partial class Login : Form
    {
        private PenggunaRepository penggunaRepository = new PenggunaRepository();

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Username dan Password wajib diisi!");
                return;
            }

            Pengguna user = penggunaRepository.Login(username, password);

            if (user != null)
            {
                MessageBox.Show("Login berhasil sebagai " + user.Role);

                Dashboard dashboard = new Dashboard(user);
                dashboard.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau Password salah!");
            }
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}