using System;
using System.ServiceModel;
using Wulka.Test.Interfaces;

namespace Wulka.Test.Services
{
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class TestSentry : ITestSentry
    {
        public string SayHello(string name)
        {
            return String.Format("Hi, {0}", name);
        }
    }
}