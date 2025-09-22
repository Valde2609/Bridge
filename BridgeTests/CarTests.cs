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
			Car car = new Car();
			//Act
			double result = car.Price();
			//Assert
			Assert.AreEqual(230, result);
		}

		[TestMethod()]
		public void VehicleTypeTest()
		{
			//Arrange
			Car car = new Car();
			//Act
			string result = car.VehicleType();
			//Assert
			Assert.AreEqual("Car", result);
		}
	}
}