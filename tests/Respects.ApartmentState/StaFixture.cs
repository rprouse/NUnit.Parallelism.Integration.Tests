﻿using System.Threading;
using NUnit.Framework;

[assembly: Parallelizable(ParallelScope.Children)]

namespace RespectsApartmentState
{
    [Apartment(ApartmentState.STA)]
    public class StaFixture
    {
        [TestCase(1)]
        [TestCase(2)]
        public void Test_cases_should_inherit_apartment_from_fixture(int n)
        {
            Assert.That(Thread.CurrentThread.GetApartmentState(), Is.EqualTo(ApartmentState.STA));
        }
    }
}
