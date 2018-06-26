using lj_framework.Base;
using lj_framework.Utils;
using lj_tests.Pages;
using NUnit.Framework;
using System.Net;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace lj_tests.Steps
{
    [Binding]
    internal class ErrorPageSteps : BaseStep
    {
        [StepDefinition(@"I should get ""(.*)"" HTTP response code")]
        public async Task ThenIShouldGetHTTPResponseCode(string expectedCode)
        {
            var url = CurrentPage.As<ErrorPage>().GetPageUrl();
            var actualHttpStatusCode = await HttpClientTools.GetHttpStatusCode(url);
            if (expectedCode == "404")
            {
                Assert.That(actualHttpStatusCode, Is.EqualTo(HttpStatusCode.NotFound),
                    $"ERROR: Http status code is different: {actualHttpStatusCode}");
            }
        }
    }
}
