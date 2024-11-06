using static AbstractFatory.Controllers.WeatherForecastController;

namespace AbstractFatory.Controllers
{
	// Concrete Factory for Actual Investor
	public class ActualInvestorFactory : IInvestorFactory
	{
		public IInvestor CreateInvestor() => new ActualInvestor();
	}


}
