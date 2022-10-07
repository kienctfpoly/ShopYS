namespace ShopTheThao.Shared
{
    public class CartDetail
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public int CartID { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public float TotalMoney { get; set; }
        public bool Status { get; set; }
    }
}
