using System;
using System.Collections;
using NUnit.Framework;

namespace Parallel.Children
{
    public class BaseTest<T> where T : Animal, new()
    {
        [SetUp]
        public void SetUp()
        {
            Base.ThreadLocalContext.Value = new T();
        }

        [TearDown]
        public void TearDown()
        {
            Base.ThreadLocalContext.Value.Do();
        }
    }

    [TestFixture]
    [Parallelizable(ParallelScope.Children)]
    [TestFixture(typeof(Dog))]
    [TestFixture(typeof(Cat))]
    public class Test1<T> : BaseTest<T> where T : Animal, new()
    {
        [Test, TestCaseSource(typeof(DataProvider), nameof(DataProvider.TestCases))]
        public void Test(string url)
        {
            Console.WriteLine(url + " " + Base.ThreadLocalContext.Value);
        }
    }

    public class DataProvider
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData("hello");
                yield return new TestCaseData("hi");
                yield return new TestCaseData("bonjour");
                yield return new TestCaseData("hola");
                yield return new TestCaseData("hey");
            }
        }
    }
}
