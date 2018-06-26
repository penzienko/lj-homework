using lj_framework.Base;
using lj_tests.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace lj_tests.Steps
{
    [Binding]
    internal class HelloPageSteps : BaseStep
    {
        [StepDefinition(@"I see following text (.*)")]
        public void ThenISeeFollowingText(string expectedText)
        {
            var actualText = CurrentPage.As<HelloPage>().GetPageHeader();
            Assert.That(actualText, Is.EqualTo(expectedText),
                $"ERROR: Page header is different: {actualText}");
        }
    }
}
