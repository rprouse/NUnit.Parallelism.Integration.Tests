using NUnit.Framework;

namespace NUnitParallelismIntegrationTests
{
    [TestFixture]
    public class NunitParallelizationTest
    {
        [Parallelizable(ParallelScope.All)]
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

    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class NunitParallelizationTest2
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

    [TestFixture]
    [Parallelizable(ParallelScope.Children)]
    public class NunitParallelizationTest3
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

    [TestFixture]
    [RequiresThread(System.Threading.ApartmentState.STA)]
    public class NunitParallelizationTestSTA
    {
        [Test]
        [Parallelizable(ParallelScope.All)]
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
