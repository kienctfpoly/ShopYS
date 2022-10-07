namespace ShopTheThao.Shared
{
    public class ImportOrder
    {
        public int ID { get; set; }
        public int EmpID { get; set; }
        public int ImportSuppID { get; set; }
        public DateTime ImportDate { get; set; }
        public float TotalMoney { get; set; }
        public bool Status { get; set; }
    }
}
