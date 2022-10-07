namespace ShopTheThao.Shared
{
    public class Cart
    {
        public int ID { get; set; }
        public string? CusName { get; set; }
        public string? CusAddress { get; set; }
        public int CusPhone { get; set; }
        public float TotalMoney { get; set; }
        public string? Descriptions { get; set; }
        public bool Status { get; set; }
    }
}
