using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge;

public class MC : Vehicle
{
	/// <summary>
	/// Constructor that initialises the license plate of the MC
	/// </summary>
	/// <param name="licensePlate"></param>
	public MC(string licensePlate) : base(licensePlate)
	{
		LicensePlate = licensePlate;
		Date = DateTime.Now;
	}

	/// <summary>
	/// Method that fetches the price of the MC
	/// </summary>
	/// <returns></returns>
	public override double Price()
	{
		return 120;
	}

	/// <summary>
	/// Method that fetches the type of vehicle
	/// </summary>
	/// <returns></returns>
	public string Vehicle()
	{
		return "MC";
	}


}
