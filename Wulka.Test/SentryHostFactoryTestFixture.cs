using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wulka.Networking.Wcf;
using Wulka.Test.Services;

namespace Wulka.Test
{
    [TestClass]
    public class SentryHostFactoryTestFixture
    {

        [TestMethod]
        public void Try_CreateNetPipeTestSentry()
        {
            var f = SentryHostFactory.CreateAnnouncingHost(typeof(TestSentry), new[] { new Uri("net.pipe://localhost/testservice") });
            f.Open();
        }


        [TestMethod]
        public void Try_CreateHTTPTestSentry()
        {
            var f = SentryHostFactory.CreateAnnouncingHost(typeof(TestSentry), new[] { new Uri("http://localhost:18011/testservice") });
            f.Open();
        }



    }
}
