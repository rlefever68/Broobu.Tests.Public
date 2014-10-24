using Wulka.Test.Interfaces;

namespace Wulka.Test.Agents
{
    public class TestPortal
    {
       

        public static ITestSentry Agent
        {
            get { return new TestAgent();}
        }

    }
}