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
		public void CarWeekendPriceDiscountNoBrobizz()
		{
			//Arrange
			Car car = new Car("12345", false, new DateTime(2024, 6, 1));
			StorebaeltTicket storebaeltTicket = new StorebaeltTicket();
			
			//Act
			double result = storebaeltTicket.WeekendPrice(car);

			//Assert
			Assert.AreEqual(195.5, result);
		}

		[TestMethod()]
		public void CarWeekendPriceDiscountWithBrobizz()
		{
			//Arrange
			Car car = new Car("12345", true, new DateTime(2024, 6, 2));
			StorebaeltTicket storebaeltTicket = new StorebaeltTicket();

			//Act
			double result = storebaeltTicket.WeekendPrice(car);

			//Assert
			Assert.AreEqual(175.95, result);
		}
		[TestMethod()]
		public void CarWeekdayPriceDiscountNoBrobizz()
		{
			//Arrange
			Car car = new Car("12345", false, new DateTime(2024, 5, 30));
			StorebaeltTicket storebaeltTicket = new StorebaeltTicket();

			//Act
			double result = storebaeltTicket.WeekendPrice(car);

			//Assert
			Assert.AreEqual(230, result);
		}
		[TestMethod()]
		public void CarWeekdayPriceDiscountWithBrobizz()
		{
			//Arrange
			Car car = new Car("12345", true, new DateTime(2024, 5, 30));
			StorebaeltTicket storebaeltTicket = new StorebaeltTicket();

			//Act
			double result = storebaeltTicket.WeekendPrice(car);

			//Assert
			Assert.AreEqual(207, result);
		}

		[TestMethod()]
		public void MCWeekendPriceDiscountNoBrobizz()
		{
			//Arrange
			MC mc = new MC("12345", false, new DateTime(2024, 6, 1));
			StorebaeltTicket storebaeltTicket = new StorebaeltTicket();

			//Act
			double result = storebaeltTicket.WeekendPrice(mc);

			//Assert
			Assert.AreEqual(120, result);
		}
		[TestMethod()]
		public void MCWeekendPriceDiscountWithBrobizz()
		{
			//Arrange
			MC mc = new MC("12345", true, new DateTime(2024, 6, 1));
			StorebaeltTicket storebaeltTicket = new StorebaeltTicket();

			//Act
			double result = storebaeltTicket.WeekendPrice(mc);

			//Assert
			Assert.AreEqual(108, result);
		}
		[TestMethod()]
		public void MCWeekdayPriceDiscountNoBrobizz()
		{
			//Arrange
			MC mc = new MC("12345", false, new DateTime(2024, 5, 30));
			StorebaeltTicket storebaeltTicket = new StorebaeltTicket();

			//Act
			double result = storebaeltTicket.WeekendPrice(mc);

			//Assert
			Assert.AreEqual(120, result);
		}
		[TestMethod()]
		public void MCWeekdayPriceDiscountWithBrobizz()
		{
			//Arrange
			MC mc = new MC("12345", true, new DateTime(2024, 5, 30));
			StorebaeltTicket storebaeltTicket = new StorebaeltTicket();

			//Act
			double result = storebaeltTicket.WeekendPrice(mc);

			//Assert
			Assert.AreEqual(108, result);
		}
	}
}