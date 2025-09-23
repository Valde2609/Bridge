using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridge;

namespace StoreBaeltTicketLibrary.Tests
{
	[TestClass()]
	public class StorebaeltTicketTests
	{
		[TestMethod()]
		public void WeekendPriceDiscountNoBrobizz()
		{
			//Arrange
			Car car = new Car("12345", false, new DateTime(2024, 6, 1));
			StorebaeltTicket storebaeltTicket = new StorebaeltTicket();
			
			//Act
			double result = storebaeltTicket.StorebaeltPrice(car);

			//Assert
			Assert.AreEqual(195.5, result);
		}

		[TestMethod()]
		public void WeekendPriceDiscountWithBrobizz()
		{
			//Arrange
			Car car = new Car("12345", true, new DateTime(2024, 6, 2));
			StorebaeltTicket storebaeltTicket = new StorebaeltTicket();

			//Act
			double result = storebaeltTicket.StorebaeltPrice(car);

			//Assert
			Assert.AreEqual(176, result);
		}
		[TestMethod()]
		public void WeekdayPriceDiscountNoBrobizz()
		{
			//Arrange
			Car car = new Car("12345", false, new DateTime(2024, 5, 30));
			StorebaeltTicket storebaeltTicket = new StorebaeltTicket();

			//Act
			double result = storebaeltTicket.StorebaeltPrice(car);

			//Assert
			Assert.AreEqual(230, result);
		}
		[TestMethod()]
		public void WeekdayPriceDiscountWithBrobizz()
		{
			//Arrange
			Car car = new Car("12345", true, new DateTime(2024, 5, 30));
			StorebaeltTicket storebaeltTicket = new StorebaeltTicket();

			//Act
			double result = storebaeltTicket.StorebaeltPrice(car);

			//Assert
			Assert.AreEqual(207, result);
		}
	}
}