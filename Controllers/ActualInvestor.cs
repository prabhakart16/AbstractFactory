namespace AbstractFatory.Controllers
{
	// Concrete Product 1 - Actual Investor
	public class ActualInvestor : IInvestor
	{
		public decimal GetServiceFee() => 0.02m;
		public decimal GetInterestRate() => 0.05m;

		public bool ValidateInvestment(decimal amount) => amount >= 1000;
	}


}
