using TestNinja.Fundamentals;
using NUnit.Framework;
//using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestNinjas.UnitTests
{
	[TestFixture]
	public class MathTests
	{
		private Math _math;

		[SetUp]
		public void Setup() //setup method to initialize the object we will be testing
		{
			_math = new Math();
		}

		[Test]
		public void Add_WhenCalled_SumOfArgs()
		{
			var result = _math.Add(1, 2);

			Assert.That(result, Is.EqualTo(3));
		}

		[Test] //Parameterized tests condense redundant code
		[TestCase(2, 1, 2)]
		[TestCase(1, 2, 2)]
		[TestCase(1, 1, 1)]
		public void Max_WhenCalled_ReturnGreaterArgument(int a, int b, int ExpectedResult)
		{
			var result = _math.Max(a, b);

			Assert.That(result, Is.EqualTo(ExpectedResult));
		}

		/*[Test]
		public void Max_FirstArgumentIsGreater_ReturnTheFirstArgument()
		{
			var result = _math.Max(2, 1);

			Assert.That(result, Is.EqualTo(2));
		}

		[Test]
		public void Max_SecondArgumentIsGreater_ReturnTheSecondArgument()
		{
			var result = _math.Max(1, 2);

			Assert.That(result, Is.EqualTo(2));
		}

		[Test]
		public void Max_ArgumentsAreEqual_ReturnsTheSameArgument()
		{
			var result = _math.Max(1, 1);

			Assert.That(result, Is.EqualTo(1));
		}*/
	}
}
