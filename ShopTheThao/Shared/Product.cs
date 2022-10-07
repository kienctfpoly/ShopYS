namespace ShopTheThao.Shared
{
    public class Product
    {
        public int ID { get; set; }
        public string? ProductName { get; set; }
        public string? Image { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Status { get; set; }
    }
}
