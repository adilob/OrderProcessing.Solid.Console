using OrderProcessing.ISP;
using OrderProcessing.OCP;

namespace OrderProcessing.SRP
{
	public class OrderValidator : IOrderValidator
	{
		public bool Validate(Order order)
		{
			// Validate order logic here
			return order != null && order.Items.Count > 0;
		}
	}

}
