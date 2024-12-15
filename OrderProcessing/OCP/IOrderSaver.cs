using OrderProcessing.ISP;

namespace OrderProcessing.OCP
{
	public interface IOrderSaver
	{
		void Save(Order order);
	}

}
