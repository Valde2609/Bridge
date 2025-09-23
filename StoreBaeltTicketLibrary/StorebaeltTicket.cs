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
	public double WeekendPrice(Vehicle vehicle)
	{
		bool isWeekend = vehicle.Date.DayOfWeek == DayOfWeek.Saturday || vehicle.Date.DayOfWeek == DayOfWeek.Sunday;


		if (vehicle.VehicleType() == "Car" && isWeekend == true)
		{
			return vehicle.Price() * 0.85;
		}
		else
		{
			return vehicle.Price();
		}
	}
}
