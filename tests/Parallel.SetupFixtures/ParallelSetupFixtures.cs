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
        [OneTimeSetUp]
        public void FooSetUpMethod()
        {
            Console.WriteLine("FooSetUp");
        }
    }

    // [Parallelizable(ParallelScope.None)]  // if this line is uncommented, then NUnit will not hang
    [SetUpFixture]
    public class BarSetUp
    {
        [OneTimeSetUp]
        public void BarSetUpMethod()
        {
            Thread.Sleep(500); // if this line is commented out, then NUnit will not hang
            Console.WriteLine("BarSetUp");
        }
    }

    [TestFixture]
    public class MyTests
    {
        [Test]
        public void MyTest()
        {
            Console.WriteLine("MyTest");
        }
    }
}
