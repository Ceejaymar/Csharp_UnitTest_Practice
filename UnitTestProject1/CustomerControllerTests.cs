﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
	[TestFixture]
	public class CustomerControllerTests
	{
		[Test]
		public void GetCustomer_IdIsZero_ReturnNotFound()
		{
			var controller = new CustomerController();

			var result = controller.GetCustomer(0);

			// Two ways to do the assert
			Assert.That(result, Is.TypeOf<NotFound>()); // Not Found object
			Assert.That(result, Is.InstanceOf<NotFound>()); // Not Found or one of it's derivatives
		}

		[Test]
		public void GetCustomer_IdIsNotZero_ReturnOK()
		{
			var controller = new CustomerController();

			var result = controller.GetCustomer(1);

			Assert.That(result, Is.TypeOf<Ok>());
			Assert.That(result, Is.InstanceOf<Ok>());
		}
	}
}
