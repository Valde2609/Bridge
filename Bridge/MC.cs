using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge;

public class MC
{
	/// <summary>
	/// License plate of the MC And Date of the MC
	/// </summary>
	public string LicensePlate { get; set; }
	public DateTime Date { get; set; }

	/// <summary>
	/// Method that fetches the price of the MC
	/// </summary>
	/// <returns></returns>
	public double Price()
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
