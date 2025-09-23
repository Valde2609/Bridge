using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridge;

namespace StoreBaeltTicketLibrary;

class StorebæltsbroenRepo
{
	/// <summary>
	/// Static List that holds all the tickets bought for Storebæltsbroen
	/// </summary>
	private static List<StorebaeltTicket> _storebæltsbroenTicketList = new List<StorebaeltTicket>();

	/// <summary>
	/// Method that buys/adds a ticket to the list of tickets
	/// </summary>
	/// <param name="ticket"></param>
	public void BuyTicket(StorebaeltTicket ticket)
	{
		_storebæltsbroenTicketList.Add(ticket);
	}
	/// <summary>
	/// Method that fetches all the tickets bought for Storebæltsbroen
	/// </summary>
	/// <returns></returns>
	public List<StorebaeltTicket> GetAllTickets()
	{
		return _storebæltsbroenTicketList;
	}
	//TODO: Implement FindAllTicketsForVehicle
	public void FindAllTicketsForVehicle(Vehicle vehicle)
	{
		
		//var matchingVehicles = _storebæltsbroenTicketList
		//	.Where(v => v.LicensePlate == targetPlate)
		//	.ToList();

		//return matchingVehicles;



		//foreach (var v in _storebæltsbroenTicketList)
		//{
		//	Console.WriteLine($"{vehicle.VehicleType()} with plate {vehicle.LicensePlate}");
		//}
	}
}
