using Wulka.Test.Interfaces;

namespace Wulka.Test
{
    public class TestPortal
    {
       

        public static ITestSentry Agent
        {
            get { return new TestAgent();}
        }

    }
}