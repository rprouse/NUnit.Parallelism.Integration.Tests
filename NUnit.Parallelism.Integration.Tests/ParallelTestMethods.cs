using NUnit.Framework;

namespace NUnitParallelismIntegrationTests
{
    [TestFixture]
    public class ParallelTestMethods
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
}
