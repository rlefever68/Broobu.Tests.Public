using System.ServiceModel;

namespace Wulka.Test.Interfaces
{
    [ServiceContract(Namespace = TestServiceConst.Namespace)]
    public interface ITestSentry
    {
        [OperationContract]
        string SayHello(string name);
    }
}