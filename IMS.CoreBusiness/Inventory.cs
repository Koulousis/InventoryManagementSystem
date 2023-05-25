namespace IMS.CoreBusiness
{
	public class Inventory
	{
        public int InventoryId { get; set; }
		public string InventoryName { get; set; } = string.Empty;
        public double Quantity { get; set; }
		public double Price { get; set; }
    }
}