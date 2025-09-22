namespace Bridge;

public class Car
{
	/// <summary>
	/// License plate of the car And Date of the car
	/// </summary>
	public string LicensePlate { get; set; }
	public DateTime Date { get; set; }

	/// <summary>
	/// Method that fetches the price of the car
	/// </summary>
	/// <returns></returns>
	public double Price()
	{
		return 230;
	}
	/// <summary>
	/// Method that fetches the type of vehicle
	/// </summary>
	/// <returns></returns>
	public string VehicleType()
	{
		return "Car";
	}
}