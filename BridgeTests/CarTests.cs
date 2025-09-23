using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace Bridge.Tests
{
	[TestClass()]
	public class CarTests
	{
		[TestMethod()]
		public void PriceTest()
		{
			//Arrange
			Car car = new Car("12345", false, new DateTime(2025, 1, 1));
			//Act
			double result = car.Price();
			//Assert
			Assert.AreEqual(230, result);
		}

		[TestMethod()]
		public void VehicleTypeTest()
		{
			//Arrange
			Car car = new Car("67890", true, new DateTime(2025, 1, 1));
			//Act
			string result = car.VehicleType();
			//Assert
			Assert.AreEqual("Car", result);
		}

		[TestMethod]
		public void LPRestrictionExceededCar()
		{
			// Act & Assert
			Assert.ThrowsException<ArgumentException>(() =>
			{
				//Arrange
				Car car = new Car("1234567890", true, new DateTime(2025, 1, 1));
			});
		}
		[TestMethod()]
		public void LPRestrictionNotExceededCar()
		{
			//Arrange
			Car car = new Car("ABC123", true, new DateTime(2025, 1, 1));
			//Act
			string result = car.LicensePlate;
			//Assert
			Assert.AreEqual("ABC123", result);
		}
		[TestMethod()]
		public void BroBizzDiscount()
		{
			//Arrange
			Car car = new Car("ABC123", true, new DateTime(2025, 1, 1));
			//Act
			double result = car.Price();
			//Assert
			Assert.AreEqual(207, result);
		}
	}
}