namespace AbstractFatory.Controllers
{
	public class InvestmentService
	{
		private readonly IInvestor _investor;

		public InvestmentService(IInvestor investor)
		{
			_investor = investor;
		}

		public void ProcessInvestment(decimal amount)
		{
			if (_investor.ValidateInvestment(amount))
			{
				decimal serviceFee = _investor.GetServiceFee();
				decimal interestRate = _investor.GetInterestRate();
				Console.WriteLine($"Investment is valid with Service Fee: {serviceFee} and Interest Rate: {interestRate}");
			}
			else
			{
				Console.WriteLine("Investment is not valid.");
			}
		}
	}


}
