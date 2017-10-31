using System.Threading;
using NUnit.Framework;

[assembly: Parallelizable(ParallelScope.Fixtures)]

namespace NUnit.Parallelism.Integration.Tests
{

    [SetUpFixture]
    public class TestsSetUpFixture
    {

    }

    [TestFixture]
    //[Parallelizable(ParallelScope.Self)]
    public class Issue2454TestFixture1
    {
        [Test]
        public void TestFixture1_Test()
        {
            TestContext.Progress.WriteLine($"Starting {nameof(TestFixture1_Test)}");
            Thread.Sleep(1000);
            TestContext.Progress.WriteLine($"Finishing {nameof(TestFixture1_Test)}");
        }
    }

    [TestFixture]
    [NonParallelizable]
    public class Issue2454TestFixture2
    {
        [Test]
        public void TestFixture2_Test()
        {
            TestContext.Progress.WriteLine($"Starting {nameof(TestFixture2_Test)}");
            Thread.Sleep(1000);
            TestContext.Progress.WriteLine($"Finishing {nameof(TestFixture2_Test)}");
        }
    }

    [TestFixture]
    //[Parallelizable(ParallelScope.Self)]
    public class Issue2454TestFixture3
    {
        [Test]
        public void TestFixture3_Test()
        {
            TestContext.Progress.WriteLine($"Starting {nameof(TestFixture3_Test)}");
            Thread.Sleep(1000);
            TestContext.Progress.WriteLine($"Finishing {nameof(TestFixture3_Test)}");
        }
    }
}
