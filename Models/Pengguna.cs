namespace AgroWasteNexus.Models
{
    public class Pengguna : BaseEntity
    {
        private int idPengguna;
        private string username;
        private string password;
        private string role;

        public int IdPengguna
        {
            get { return idPengguna; }
            set { idPengguna = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Role
        {
            get { return role; }
            set { role = value; }
        }

        public override int GetId()
        {
            return IdPengguna;
        }
    }
}