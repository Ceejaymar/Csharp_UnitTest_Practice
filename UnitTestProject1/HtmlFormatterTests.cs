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
	public class HtmlFormatterTests
	{
		[Test]
		public void FormatAsBold_WhenCalled_ShoulEncloseTheStringWithStrongElement()
		{
			var formatter = new HtmlFormatter();

			var result = formatter.FormatAsBold("abc");

			//Specfic assertion
			Assert.That(result, Is.EqualTo("<strong>abc</strong>").IgnoreCase); //assertions area case sensitive by default

			//More general aassertion
			Assert.That(result, Does.StartWith("<strong>"));
			Assert.That(result, Does.EndWith("</strong>"));
			Assert.That(result, Does.Contain("abc"));
		}
	}
}
