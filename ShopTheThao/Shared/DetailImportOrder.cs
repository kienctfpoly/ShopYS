namespace ShopTheThao.Shared
{
    public class DetailImportOrder
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public int ImportOrderID { get; set; }
        public int Quantity { get; set; }
        public float ImportPrice { get; set; }
        public bool Status { get; set; }
    }
}
