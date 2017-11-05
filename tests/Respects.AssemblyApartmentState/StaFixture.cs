using System.Threading;
using NUnit.Framework;

// Tests Regression in 3.8.1: ApartmentAttribute no longer works when applied to an assembly #2426

[assembly: Apartment(ApartmentState.STA)]

namespace Respects.AssemblyApartmentState
{
    [TestFixture]
    public class StaFixture
    {
        [Test]
        public void Test()
        {
            if (Thread.CurrentThread.GetApartmentState() != ApartmentState.STA)
            {
                throw new ThreadStateException("The current threads apartment state is not STA");
            }
        }
    }
}
