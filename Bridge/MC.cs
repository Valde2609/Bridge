using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge;

public class MC : Vehicle
{
	/// <summary>
	/// Constructor that initialises the license plate, date and brobizz of the MC
	/// </summary>
	/// <param name="licensePlate"></param>
	public MC(string licensePlate, bool broBizz) : base(licensePlate, broBizz)
	{
		LicensePlate = licensePlate;
		Date = DateTime.Now;
		BroBizz = broBizz;
	}

	/// <summary>
	/// Method that fetches the price of the MC
	/// </summary>
	/// <returns></returns>
	public override double Price()
	{
		if (BroBizz == true)
			return 108;
		else
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
