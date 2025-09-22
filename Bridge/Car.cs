namespace Bridge;

public class Car : Vehicle
{

	/// <summary>
	/// Constructor that initialises the license plate, date and brobizz of the car
	/// </summary>
	/// <param name="licensePlate"></param>
	public Car(string licensePlate, bool broBizz) : base(licensePlate, broBizz)
	{
		LicensePlate = licensePlate;
		Date = DateTime.Now;
		BroBizz = broBizz;
	}

	/// <summary>
	/// Method that fetches the price of the car
	/// </summary>
	/// <returns></returns>
	public override double Price()
	{
		if (BroBizz == true)
			return 207;
		else
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