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
