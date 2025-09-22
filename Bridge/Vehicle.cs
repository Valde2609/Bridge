using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge;

public abstract class Vehicle
{

	/// <summary>
	/// License plate of the vehicle And Date of the vehicle
	/// </summary>
	public string LicensePlate { get; set; }
	public DateTime Date { get; set; }

	/// <summary>
	/// Conmstructor that takes in the license plate of the vehicle and restricts it to 7 characters
	/// </summary>
	/// <param name="licensePlate"></param>
	/// <exception cref="ArgumentException"></exception>
	public Vehicle(string licensePlate)
	{
		if (licensePlate.Length > 7)
			throw new ArgumentException("License plate cannot exceed 7 characters.");

		LicensePlate = licensePlate;
	}

	/// <summary>
	/// Method that fetches the price of the vehicle
	/// </summary>
	/// <returns></returns>
	public abstract double Price();

	/// <summary>
	/// Method that fetches the type of vehicle
	/// </summary>
	/// <returns></returns>
	public virtual string VehicleType()
	{
		return "Vehicle";
	}

}
