using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridge;

namespace StoreBaeltTicketLibrary;

class StorebæltsbroenRepo : IStorebæltsbroenRepo
{
	/// <summary>
	/// Static List that holds all the tickets bought for Storebæltsbroen
	/// </summary>
	private static List<Vehicle> _storebæltsbroenTicketList = new List<Vehicle>();

	/// <summary>
	/// Method that buys/adds a ticket to the list of tickets
	/// </summary>
	/// <param name="ticket"></param>
	public void BuyTicket(Vehicle ticket)
	{
		_storebæltsbroenTicketList.Add(ticket);
	}
	/// <summary>
	/// Method that fetches all the tickets bought for Storebæltsbroen
	/// </summary>
	/// <returns></returns>
	public List<Vehicle> GetAllTickets()
	{
		return _storebæltsbroenTicketList;
	}
	/// <summary>
	/// Method that finds all tickets bought for a specific vehicle based on license plate
	/// </summary>
	/// <param name="licensePlate"></param>
	/// <returns></returns>
	public List<Vehicle> FindAllTicketsForVehicle(string licensePlate)
	{
		return _storebæltsbroenTicketList.FindAll(ticket => ticket.LicensePlate == licensePlate);
	}

}
