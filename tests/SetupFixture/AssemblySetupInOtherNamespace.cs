using NUnit.Framework;

// Tests https://github.com/nunit/nunit/issues/2467

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
