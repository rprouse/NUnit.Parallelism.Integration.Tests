﻿using NUnit.Framework;

namespace NUnitParallelismIntegrationTests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Children)]
    public class ParallelTestFixtureChildren
    {
        [Test]
        public void Test([Range(1, 10)] int x)
        {
            TestContext.WriteLine($"Test {x}");
        }

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            TestContext.WriteLine("OneTimeSetup");
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            TestContext.WriteLine("OneTimeTearDown");
        }
    }
}
