using Wulka.Networking.Wcf;
using Wulka.Test.Interfaces;

namespace Wulka.Test.Agents
{
    class TestAgent : DiscoProxy<ITestSentry>, ITestSentry
    {
        public string SayHello(string name)
        {
            return Client.SayHello(name);
        }

        protected override string GetContractNamespace()
        {
            return TestServiceConst.Namespace;
        }
    }
}