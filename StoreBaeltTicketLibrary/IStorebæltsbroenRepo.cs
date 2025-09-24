using Bridge;

namespace StoreBaeltTicketLibrary;

/// <summary>
/// Interface for StorebæltsbroenRepo class
/// </summary>
public interface IStorebæltsbroenRepo
{
	/// <summary>
	/// Interface method that buys/adds a ticket to the list of tickets
	/// </summary>
	/// <param name="ticket"></param>
	void BuyTicket(Vehicle ticket);
	/// <summary>
	/// Interface method that finds all tickets bought for a specific vehicle based on license plate
	/// </summary>
	/// <param name="licensePlate"></param>
	/// <returns></returns>
	List<Vehicle> FindAllTicketsForVehicle(string licensePlate);
	/// <summary>
	/// Interface method that fetches all the tickets bought for Storebæltsbroen
	/// </summary>
	/// <returns></returns>
	List<Vehicle> GetAllTickets();
}