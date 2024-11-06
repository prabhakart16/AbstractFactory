using static AbstractFatory.Controllers.WeatherForecastController;

namespace AbstractFatory.Controllers
{
	// Concrete Factory for Schedule Investor
	public class ScheduleInvestorFactory : IInvestorFactory
	{
		public IInvestor CreateInvestor() => new ScheduleInvestor();
	}


}
