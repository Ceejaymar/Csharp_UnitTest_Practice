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
	public class FizzBuzzTests
	{
		[Test]
		public void GetOutput_IndputIsDivisibleby3and5_ReturnFizzBuzz()
		{
			var result = FizzBuzz.GetOutput(15);

			Assert.That(result, Is.EqualTo("FizzBuzz"));
		}

		[Test]
		public void GetOutput_InputIsDivisableby3_ReturnFizz()
		{
			var result = FizzBuzz.GetOutput(9);

			Assert.That(result, Is.EqualTo("Fizz"));
		}

		[Test]
		public void GetOutput_InputIsDivisableBy5_ReturnBuzz()
		{
			var result = FizzBuzz.GetOutput(10);

			Assert.That(result, Is.EqualTo("Buzz"));
		}

		[Test]
		public void GetOutput_NotdivisableBy3or5_ReturnInput()
		{
			var result = FizzBuzz.GetOutput(4);

			Assert.That(result, Is.EqualTo("4"));
		}
	}
}