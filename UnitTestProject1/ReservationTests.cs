﻿using System;
// using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;
using NUnit.Framework;

namespace TestNinja.UnitTests
{
	[TestFixture]
	public class ReservationTests
	{
		[Test]
		public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
		{
			//Arrange
			var reservation = new Reservation();

			//Act
			var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

			//Assert
			//Assert.IsTrue(result);
			Assert.That(result, Is.True);
		}

		[Test]
		public void CanBeCanceledBy_SameUserCancellingTheReservation_ReturnTrue()
		{
			var user = new User();
			var reservation = new Reservation { MadeBy = user };

			var result = reservation.CanBeCancelledBy(user);

			Assert.That(result, Is.True);
		}

		[Test]
		public void CanBeCancelledBy_AnotherUserCancellingReservation_ReturnFalse()
		{
			var reservation = new Reservation { MadeBy = new User() };

			var result = reservation.CanBeCancelledBy(new User());

			Assert.IsFalse(result);
		}
	}
}