namespace OresundBron;
using Bridge;

public class OresundBronTicket
{
	/// <summary>
	/// Method that fetches the price of the oresund ticket based on the type of vehicle and if the vehicle has a brobizz
	/// Vehicle must be specified as either Car or MC, otherwise an exception is thrown
	/// </summary>
	/// <param name="vehicle"></param>
	/// <returns></returns>
	/// <exception cref="ArgumentException"></exception>
	public double OresundPrice(Vehicle vehicle)
	{
		double price = 0;
		if (vehicle is Car)
		{
			price = 460;
			if (vehicle.BroBizz)
			{
				price = 178;
			}
		}
		else if (vehicle is MC)
		{
			price = 235;
			if (vehicle.BroBizz)
			{
				price = 92; 
			}
		}
		else
		{
			throw new ArgumentException("vehicle type must be Car or MC.");
		}
		return price;
	}
	/// <summary>
	/// Method that fetches the type of vehicle as either "Oresund Car" or "Oresund MC"
	/// </summary>
	/// <param name="vehicle"></param>
	/// <returns></returns>
	/// <exception cref="ArgumentException"></exception>
	public string VehicleType(Vehicle vehicle)
	{
		if (vehicle is Car)
		{
			return "Oresund Car";
		}
		else if (vehicle is MC)
		{
			return "Oresund MC";
		}
		else
		{
			throw new ArgumentException("vehicle type must be Car or MC.");
		}
	}
}
