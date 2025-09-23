using Microsoft.VisualStudio.TestTools.UnitTesting;
using OresundBron;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridge;
using System.Diagnostics;

namespace OresundBron.Tests
{
	[TestClass()]
	public class OresundBronTicketTests
	{
		[TestMethod()]
		public void CarPriceNoBrobizz()
		{
			//Arrange
			Car car = new Car("12345", false, new DateTime(2024, 5, 30));
			OresundBronTicket oresundBronTicket = new OresundBronTicket();

			//Act
			double result = oresundBronTicket.OresundPrice(car);

			//Assert
			Assert.AreEqual(460, result);
		}
		[TestMethod()]
		public void CarPriceWithBrobizz()
		{
			//Arrange
			Car car = new Car("12345", true, new DateTime(2024, 5, 30));
			OresundBronTicket oresundBronTicket = new OresundBronTicket();

			//Act
			double result = oresundBronTicket.OresundPrice(car);

			//Assert
			Assert.AreEqual(178, result);
		}
		[TestMethod()]
		public void MCPriceNoBrobizz()
		{
			//Arrange
			MC mc = new MC("12345", false, new DateTime(2024, 5, 30));
			OresundBronTicket oresundBronTicket = new OresundBronTicket();

			//Act
			double result = oresundBronTicket.OresundPrice(mc);

			//Assert
			Assert.AreEqual(235, result);
		}
		[TestMethod()]
		public void MCPriceWithBrobizz()
		{
			//Arrange
			MC mc = new MC("12345", true, new DateTime(2024, 5, 30));
			OresundBronTicket oresundBronTicket = new OresundBronTicket();

			//Act
			double result = oresundBronTicket.OresundPrice(mc);

			//Assert
			Assert.AreEqual(92, result);
		}
		[TestMethod()]
		public void VehicleTypeCar()
		{
			//Arrange
			Car car = new Car("12345", false, new DateTime(2024, 5, 30));
			OresundBronTicket oresundBronTicket = new OresundBronTicket();
			//Act
			string result = oresundBronTicket.VehicleType(car);
			//Assert
			Assert.AreEqual("Oresund Car", result);
		}
		[TestMethod()]
		public void VehicleTypeMC()
		{
			//Arrange
			MC mc = new MC ("12345", false, new DateTime(2024, 5, 30));
			OresundBronTicket oresundBronTicket = new OresundBronTicket();
			//Act
			string result = oresundBronTicket.VehicleType(mc);
			//Assert
			Assert.AreEqual("Oresund MC", result);
		}
		
	}
}