namespace Bridge;

public class Car : Vehicle
{

	/// <summary>
	/// Method that fetches the price of the car
	/// </summary>
	/// <returns></returns>
	public override double Price()
	{
		return 230;
	}
	/// <summary>
	/// Method that fetches the type of vehicle
	/// </summary>
	/// <returns></returns>
	public override string VehicleType()
	{
		return "Car";
	}
}