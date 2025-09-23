namespace StoreBaeltTicketLibrary;
using Bridge;
public class StorebaeltTicket
{
	/// <summary>
	/// Method that fetches the price of the storebaelt ticket based on the day of the week and if the vehicle has a brobizz
	/// Furthermore, the brobizz discount is applied after the weekend discount if applicable
	/// </summary>
	/// <param name="car"></param>
	/// <returns></returns>
	public double StorebaeltPrice(Car car)
	{
		if (car.Date.DayOfWeek == DayOfWeek.Saturday || car.Date.DayOfWeek == DayOfWeek.Sunday)
		{
			if (car.BroBizz == true)
				return 176;
			else
				return 195.5;
		}
		else
		{
			if (car.BroBizz == true)
				return 207;
			else
				return 230;
		}
	}
}
