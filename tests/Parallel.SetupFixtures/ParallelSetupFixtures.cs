using System;
using System.Threading;
using NUnit.Framework;

// Tests Issue #1239

[assembly: Timeout(60000)]
[assembly: Parallelizable(ParallelScope.Children)]

namespace Parallel.SetupFixtures
{
    [SetUpFixture]
    public class FooSetUp
    {
        //[Parallelizable(ParallelScope.Self)]
        [OneTimeSetUp]
        public void FooSetUpMethod()
        {
            TestContext.Progress.WriteLine("FooSetUp - S");
            Thread.Sleep(5000);
            TestContext.Progress.WriteLine("FooSetUp - E");
        }
    }

    // [Parallelizable(ParallelScope.None)]  // if this line is uncommented, then NUnit will not hang
    [SetUpFixture]
    public class BarSetUp
    {
        [OneTimeSetUp]
        public void BarSetUpMethod()
        {
            TestContext.Progress.WriteLine("BarSetUp - S");
            Thread.Sleep(5000); // if this line is commented out, then NUnit will not hang
            TestContext.Progress.WriteLine("BarSetUp - E");
        }
    }

    [TestFixture]
    public class MyTests
    {
        [Test]
        public void MyTest()
        {
            TestContext.Progress.WriteLine("MyTest");
        }
    }
}
