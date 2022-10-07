namespace ShopTheThao.Shared
{
    public class Order
    {
        public int ID { get; set; }
        public int PayID { get; set; }
        public int EmpID { get; set; }
        public int CusID { get; set; }
        public DateTime OrderDate { get; set; }
        public string? CusName { get; set; }
        public int CusPhone { get; set; }
        public string? CusAddress { get; set; }
        public float TotalMoney { get; set; }
        public string? Descriptions { get; set; }
        public bool Status { get; set; }
    }
}
