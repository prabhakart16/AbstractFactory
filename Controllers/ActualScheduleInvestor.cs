namespace AbstractFatory.Controllers
{
	// Concrete Product 3 - ActualSchedule Investor
	public class ActualScheduleInvestor : IInvestor
	{
		public decimal GetServiceFee() => 0.025m;
		public decimal GetInterestRate() => 0.045m;

		public bool ValidateInvestment(decimal amount) => amount >= 2000;
	}

}
