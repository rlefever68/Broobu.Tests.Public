using System;
using System.ServiceModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NLog;
using Wulka.Exceptions;
using Wulka.Networking.Wcf;
using Wulka.Test.Agents;
using Wulka.Test.Services;

namespace Wulka.Test
{
    [TestClass]
    public class SentryHostFactoryTestFixture
    {
        private static ServiceHost f1;
        private static ServiceHost f2;


        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        
        [TestMethod]
        public void Try_CreateNetPipeTestSentry()
        {
            const string baseAddress = "net.pipe://localhost/testsentry";
            f1 = CreateTestSentry(baseAddress);
        }

        private static ServiceHost CreateTestSentry(string baseAddress)
        {

            try
            {
                Logger.Info("Calling TestSentry @ {0}", baseAddress);
                var f = SentryHostFactory.CreateAnnouncingHost(typeof(TestSentry), 
                    new[] { new Uri(baseAddress) });
                f.Open();
                return f;
            }
            catch (Exception ex)
            {
                Logger.Error(ex.GetCombinedMessages());
                throw;
            }
        }


        [TestMethod]
        public void Try_CreateHTTPTestSentry()
        {
            const string baseAddress = "http://localhost:18011/testsentry";
            f2 = CreateTestSentry(baseAddress);
        }



        [TestMethod]
        public void Try_ConsumeTestSentry()
        {
            var s = TestPortal.Agent.SayHello("Test Person");
            Console.WriteLine(s);
        }





    }
}
