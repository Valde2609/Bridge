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
		if (vehicle.VehicleType() == "Car" && vehicle.BroBizz == false)
		{
			return vehicle.Price() + 230;
		}
		else if (vehicle.VehicleType() == "Car" && vehicle.BroBizz == true)
		{
			return vehicle.Price() - 29;
		}
		else if (vehicle.VehicleType() == "MC" && vehicle.BroBizz == false)   //Fejl fordi den hedder vehicle og ikke VehicleType i mc klassen
		{
			return vehicle.Price() + 115;
		}
		else if (vehicle.VehicleType() == "MC" && vehicle.BroBizz == true)    //Fejl fordi den hedder vehicle og ikke VehicleType i mc klassen
		{
				return vehicle.Price() - 16; 
			}
		else
		{
			throw new ArgumentException("vehicle type must be Car or MC.");
		}
	
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
