using OrderProcessing.ISP;

namespace OrderProcessing.OCP
{
	public interface IOrderValidator
	{
		bool Validate(Order order);
	}
}
