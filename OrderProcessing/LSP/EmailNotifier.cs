using OrderProcessing.ISP;
using OrderProcessing.OCP;

namespace OrderProcessing.LSP
{
	public class EmailNotifier : INotifier
	{
		public void Notify(Order order)
		{
			// Send email notification
		}
	}
}
