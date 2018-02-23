using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
	[TestFixture]
	public class DemeritPointsCalculatorTests
	{
		[Test]
		public void CalculateDemeritPoints_SpeedIsLessThanOrEqualToSpeedLimit_Return0()
		{
			var calculator = new DemeritPointsCalculator();

			var result = calculator.CalculateDemeritPoints(64);

			Assert.That(result, Is.EqualTo(0));
		}

		[Test]
		public void CalculatorDemeritPoints_SpeedisGreaterThanSpeedLimit_returnDemeritPoints()
		{
			var calculator = new DemeritPointsCalculator();

			var result = calculator.CalculateDemeritPoints(80);

			Assert.That(result, Is.EqualTo(3));
		}

		[Test]
		public void CalculatorDemeritPoints_SpeedisLessThanZero_returnArgumentException()
		{
			var calculator = new DemeritPointsCalculator();

			//var result = calculator.CalculateDemeritPoints(-1);

			Assert.That(() => calculator.CalculateDemeritPoints(305), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
		}
	}
}
