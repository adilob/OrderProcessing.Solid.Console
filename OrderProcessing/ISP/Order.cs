namespace OrderProcessing.ISP
{
	public class Order : IOrder
	{
		public List<OrderItem> Items { get; set; }
	}

}
