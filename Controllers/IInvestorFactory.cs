namespace AbstractFatory.Controllers
{
	public partial class WeatherForecastController
	{
		// Abstract Factory
		public interface IInvestorFactory
		{
			IInvestor CreateInvestor();
		}

	}

}
