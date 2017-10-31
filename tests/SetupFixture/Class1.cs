using NUnit.Framework;

namespace BugNUnit
{
    [SetUpFixture]
    public class AssemblySetup
    {
        public AssemblySetup()
        {
        }
    }

    [TestFixture]
    public class TestInNamespace
    {
    }
}

namespace OtherNamespace
{
    [TestFixture]
    public class TestInAnotherNamespace
    {
    }
}
