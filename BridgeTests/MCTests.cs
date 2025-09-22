using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Tests
{
	[TestClass()]
	public class MCTests
	{
		[TestMethod()]
		public void PriceTest()
		{
			//Arrange
			MC mc = new MC("13579");
			//Act
			double result = mc.Price();
			//Assert
			Assert.AreEqual(120, result);
		}
		[TestMethod()]
		public void VehicleTest()
		{
			//Arrange
			MC mc = new MC("24680");
			//Act
			string result = mc.Vehicle();
			//Assert
			Assert.AreEqual("MC", result);
		}
		public void LPRestrictionExceededMC()
		{
			// Act & Assert
			Assert.ThrowsException<ArgumentException>(() =>
			{
				MC mc = new MC("1234567890");
			});
		}
		[TestMethod()]
		public void LPRestrictionNotExceededCar()
		{
			//Arrange
			MC mc = new MC("ABC123");
			//Act
			string result = mc.LicensePlate;
			//Assert
			Assert.AreEqual("ABC123", result);
		}

	}
}