using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParameterIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterIO.Tests
{
    [TestClass()]
    public class AMLParameterObjectTests
    {
        [TestMethod()]
        public void GetPostUrlTest_Null()
        {
            string url = null;

            string actual = AMLParameterObject.GetPostUrl(url);

            Assert.IsNull(actual, "Null post url was expected.");
        }

        [TestMethod()]
        public void GetPostUrlTest_Empty()
        {
            string url = string.Empty;

            string actual = AMLParameterObject.GetPostUrl(url);

            Assert.IsNull(actual, "Null post url was expected.");
        }

        [TestMethod()]
        public void GetPostUrlTest_ClassicWebService_ApiHelpPageLink()
        {
            string url = "https://ussouthcentral.services.azureml.net/workspaces/5e50059a3b724c58a1cff1908bcd0c18/services/acfd77e2a1824d5286f30780997ad70a/execute?api-version=2.0&details=true";

            string actual = AMLParameterObject.GetPostUrl(url);

            Assert.AreEqual("https://ussouthcentral.services.azureml.net/workspaces/5e50059a3b724c58a1cff1908bcd0c18/services/acfd77e2a1824d5286f30780997ad70a/execute?api-version=2.0&details=true", actual, "Post url was not as expected.");
        }

        [TestMethod()]
        public void GetPostUrlTest_ClassicWebService_TestPreviewPageLink()
        {
            string url = "https://ussouthcentral.services.azureml.net/workspaces/5e50059a3b724c58a1cff1908bcd0c18/services/acfd77e2a1824d5286f30780997ad70a/execute?api-version=2.0&format=swagger";

            string actual = AMLParameterObject.GetPostUrl(url);

            Assert.AreEqual("https://ussouthcentral.services.azureml.net/workspaces/5e50059a3b724c58a1cff1908bcd0c18/services/acfd77e2a1824d5286f30780997ad70a/execute?api-version=2.0&details=true", actual, "Post url was not as expected.");
        }

        [TestMethod()]
        public void GetPostUrlTest_PreviewWebService_Link()
        {
            string url = "https://ussouthcentral.services.azureml.net/subscriptions/92c76a2f0e1c4216b65eabf7a3f34c1e/services/a80940cb57624716a8e7c2223c6bb672/execute?api-version=2.0&format=swagger";

            string actual = AMLParameterObject.GetPostUrl(url);

            Assert.AreEqual("https://ussouthcentral.services.azureml.net/subscriptions/92c76a2f0e1c4216b65eabf7a3f34c1e/services/a80940cb57624716a8e7c2223c6bb672/execute?api-version=2.0&details=true", actual, "Post url was not as expected.");
        }

        [TestMethod()]
        public void GetSwaggerUrlTest_ClassicWebService_ApiHelpPageLink()
        {
            string url = "https://ussouthcentral.services.azureml.net/workspaces/5e50059a3b724c58a1cff1908bcd0c18/services/acfd77e2a1824d5286f30780997ad70a/execute?api-version=2.0&details=true";

            string actual = AMLParameterObject.GetSwaggerUrl(url);

            Assert.AreEqual("https://ussouthcentral.services.azureml.net/workspaces/5e50059a3b724c58a1cff1908bcd0c18/services/acfd77e2a1824d5286f30780997ad70a/swagger.json", actual, "Swagger url was not as expected.");
        }

        [TestMethod()]
        public void GetSwaggerUrlTest_ClassicWebService_TestPreviewPageLink()
        {
            string url = "https://ussouthcentral.services.azureml.net/workspaces/5e50059a3b724c58a1cff1908bcd0c18/services/acfd77e2a1824d5286f30780997ad70a/execute?api-version=2.0&format=swagger";

            string actual = AMLParameterObject.GetSwaggerUrl(url);

            Assert.AreEqual("https://ussouthcentral.services.azureml.net/workspaces/5e50059a3b724c58a1cff1908bcd0c18/services/acfd77e2a1824d5286f30780997ad70a/swagger.json", actual, "Swagger url was not as expected.");
        }

        [TestMethod()]
        public void GetSwaggerUrlTest_PreviewWebService_Link()
        {
            string url = "https://ussouthcentral.services.azureml.net/subscriptions/92c76a2f0e1c4216b65eabf7a3f34c1e/services/a80940cb57624716a8e7c2223c6bb672/execute?api-version=2.0&format=swagger";

            string actual = AMLParameterObject.GetSwaggerUrl(url);

            Assert.AreEqual("https://ussouthcentral.services.azureml.net/subscriptions/92c76a2f0e1c4216b65eabf7a3f34c1e/services/a80940cb57624716a8e7c2223c6bb672/swagger.json", actual, "Swagger url was not as expected.");
        }

        [TestMethod()]
        public void GetSwaggerUrlTest_ClassicWebService_ApiHelpPageLink_DifferentCharCase()
        {
            string url = "https://Ussouthcentral.Services.Azureml.Net/Workspaces/5e50059a3b724c58a1cff1908bcd0c18/Services/acfd77e2a1824d5286f30780997ad70a/Execute?api-version=2.0&details=true";

            string actual = AMLParameterObject.GetSwaggerUrl(url);

            Assert.AreEqual("https://ussouthcentral.services.azureml.net/workspaces/5e50059a3b724c58a1cff1908bcd0c18/services/acfd77e2a1824d5286f30780997ad70a/swagger.json", actual, "Swagger url was not as expected.");
        }

        [TestMethod()]
        public void GetSwaggerUrlTest_ClassicWebService_ApiHelpPageLink_DifferentRegion()
        {
            string url = "https://westus.services.azureml.net/workspaces/5e50059a3b724c58a1cff1908bcd0c18/services/acfd77e2a1824d5286f30780997ad70a/execute?api-version=2.0&details=true";

            string actual = AMLParameterObject.GetSwaggerUrl(url);

            Assert.AreEqual("https://westus.services.azureml.net/workspaces/5e50059a3b724c58a1cff1908bcd0c18/services/acfd77e2a1824d5286f30780997ad70a/swagger.json", actual, "Swagger url was not as expected.");
        }
    }
}