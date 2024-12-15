using OrderProcessing.ISP;
using OrderProcessing.OCP;

namespace OrderProcessing.LSP
{
	public class SmsNotifier : INotifier
	{
		public void Notify(Order order)
		{
			// Send SMS notification
		}
	}
}
