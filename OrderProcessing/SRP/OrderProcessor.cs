using OrderProcessing.ISP;
using OrderProcessing.OCP;

namespace OrderProcessing.SRP
{
	public class OrderProcessor
	{
		private readonly IOrderValidator _orderValidator;
		private readonly IOrderSaver _orderSaver;
		private readonly INotifier _notifier;

		public OrderProcessor(IOrderValidator orderValidator, IOrderSaver orderSaver, INotifier notifier)
		{
			_orderValidator = orderValidator;
			_orderSaver = orderSaver;
			_notifier = notifier;
		}

		public void ProcessOrder(Order order)
		{
			if (_orderValidator.Validate(order))
			{
				_orderSaver.Save(order);
				_notifier.Notify(order);
			}
		}
	}
}
