using OrderProcessing.ISP;
using OrderProcessing.LSP;
using OrderProcessing.OCP;
using OrderProcessing.SRP;

namespace OrderProcessing.DIP
{
	public static class OrderExecutor
	{
		public static void ExecuteOrder()
		{
			IOrderValidator validator = new OrderValidator();
			IOrderSaver saver = new OrderSaver();
			INotifier notifier = new EmailNotifier();

			OrderProcessor orderProcessor = new OrderProcessor(validator, saver, notifier);

			Order order = new Order { Items = new List<OrderItem> { new OrderItem { Name = "Product A" } } };
			orderProcessor.ProcessOrder(order);
		}
	}
}
