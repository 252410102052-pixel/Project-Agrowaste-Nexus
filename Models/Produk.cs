namespace AgrowasteNexus.Models
{
    public class Produk
    {
        public int Id { get; set; }
        public string RecipientName { get; set; } = "";
        public string RecipientType { get; set; } = "";
        public string Address { get; set; } = "";
        public string Phone { get; set; } = "";
    }
}