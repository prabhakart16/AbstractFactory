using static AbstractFatory.Controllers.WeatherForecastController;

namespace AbstractFatory.Controllers
{
	// Concrete Factory for ActualSchedule Investor
	public class ActualScheduleInvestorFactory : IInvestorFactory
	{
		public IInvestor CreateInvestor() => new ActualScheduleInvestor();
	}


}
