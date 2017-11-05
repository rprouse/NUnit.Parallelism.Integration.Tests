using NUnit.Framework;

// Test for issue #2438 - [Parallelizable] hangs after a few tests

namespace Parallel.Children
{
    [TestFixture]
    public class NunitParallelizationTest
    {
        [Parallelizable(ParallelScope.All)]
        [Test]
        public void Test([Range(1, 10)] int x)
        {

        }
    }
}
