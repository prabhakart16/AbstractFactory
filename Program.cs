
using AbstractFatory.Controllers;
using static AbstractFatory.Controllers.WeatherForecastController;

namespace AbstractFatory
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);
			var investorType = builder.Configuration["InvestorType"];
			switch (investorType)
			{
				case "Actual":
					builder.Services.AddSingleton<IInvestorFactory, ActualInvestorFactory>();
					break;
				case "Schedule":
					builder.Services.AddSingleton<IInvestorFactory, ScheduleInvestorFactory>();
					break;
				case "ActualSchedule":
					builder.Services.AddSingleton<IInvestorFactory, ActualScheduleInvestorFactory>();
					break;
				default:
					throw new InvalidOperationException("Invalid Investor Type in configuration");
			}

			builder.Services.AddTransient(provider =>
			{
				var factory = provider.GetRequiredService<IInvestorFactory>();
				return factory.CreateInvestor();
			});
			// Add services to the container.

			builder.Services.AddControllers();
			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();

			var app = builder.Build();
			app.MapGet("/", async (IInvestor investor) =>
			{
				var serviceFee = investor.GetServiceFee();
				var interestRate = investor.GetInterestRate();
				var isValid = investor.ValidateInvestment(1500); // Example investment validation

				await Task.FromResult($"Service Fee: {serviceFee}, Interest Rate: {interestRate}, Valid Investment: {isValid}");
			});
			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			app.UseHttpsRedirection();

			app.UseAuthorization();


			app.MapControllers();

			app.Run();
		}
	}
}
