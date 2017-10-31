using NUnit.Framework;

namespace NUnitParallelismIntegrationTests
{
    [TestFixture]
    [RequiresThread(System.Threading.ApartmentState.STA)]
    public class ParallelTestMethodsSTA
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
