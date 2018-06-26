using lj_framework.Base;
using lj_tests.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace lj_tests.Steps
{
    [Binding]
    internal class HomePageSteps : BaseStep
    {
        [StepDefinition(@"I see (.*) in (.*) tag")]
        public void ThenISeeTextInHTag(string text, string expectedTagName)
        {
            var actualTagName = CurrentPage.As<HomePage>().GetContainterTagName(text);
            Assert.That(actualTagName, Is.EqualTo(expectedTagName),
                $"ERROR: The text is wrapped by another tag: {actualTagName}");
        }
    }
}
