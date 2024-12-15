using OrderProcessing.ISP;

namespace OrderProcessing.OCP
{
	public interface INotifier
	{
		void Notify(Order order);
	}

}
