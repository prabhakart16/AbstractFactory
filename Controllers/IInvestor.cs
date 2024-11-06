namespace AbstractFatory.Controllers
{
	// Abstract Product
	public interface IInvestor
	{
		decimal GetServiceFee();
		decimal GetInterestRate();
		bool ValidateInvestment(decimal amount);
	}

}
