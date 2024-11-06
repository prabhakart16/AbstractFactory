namespace AbstractFatory.Controllers
{
	// Concrete Product 2 - Schedule Investor
	public class ScheduleInvestor : IInvestor
	{
		public decimal GetServiceFee() => 0.015m;
		public decimal GetInterestRate() => 0.04m;

		public bool ValidateInvestment(decimal amount) => amount >= 500;
	}

}
