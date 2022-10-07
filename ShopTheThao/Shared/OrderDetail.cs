namespace ShopTheThao.Shared
{
    public class OrderDetail
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public int OrderID { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public float TotalMoney { get; set; }
        public bool Status { get; set; }
    }
}
