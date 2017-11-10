using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using NUnit.Framework;

// Tests https://github.com/nunit/nunit/issues/2471

namespace Parallel.Children
{
    [TestFixture]
    class Deserialization
    {
        public static IEnumerable<TimeSpan> ShouldDeserializeAllCases()
              => Enumerable.Repeat(0, 5).Select(x => TimeSpan.FromSeconds(2));

        [TestCaseSource("ShouldDeserializeAllCases"), Parallelizable(ParallelScope.Children)]
        public void ShouldDeserializeAll(TimeSpan t)
        {
            Thread.Sleep(t);
            Assert.AreEqual(1, 1);
        }
    }
}
