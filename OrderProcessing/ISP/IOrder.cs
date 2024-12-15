namespace OrderProcessing.ISP
{
	public interface IOrder
	{
		List<OrderItem> Items { get; }
	}
}
