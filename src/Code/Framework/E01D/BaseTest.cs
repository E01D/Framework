using NUnit.Framework;

namespace Root.Code.Framework.E01D
{
    [TestFixture]
    
    public class BaseTest
    {
        [SetUp]
        public void Setup()
        {
            X.Logger = new ConsoleLogger();
        }
    }
}
