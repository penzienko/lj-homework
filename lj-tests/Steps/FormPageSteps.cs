using lj_framework.Base;
using lj_tests.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace lj_tests.Steps
{
    [Binding]
    internal class FormPageSteps : BaseStep
    {
        [StepDefinition(@"I see (.*) of (.*) element")]
        public void ThenISeeNumberOfElements(int expectedNumber, string elementType)
        {
            string element = "";
            if (elementType.Equals("input", System.StringComparison.OrdinalIgnoreCase))
            {
                element = "input";
            }
            else if (elementType.Equals("submit", System.StringComparison.OrdinalIgnoreCase))
            {
                element = "button[@type='submit']";
            }
            var actualNumber = CurrentPage.As<FormPage>().GetNumberOfVisibleElements(element);

            Assert.That(actualNumber, Is.EqualTo(expectedNumber),
                $"ERROR: Incorrect Number of {elementType} elements: {actualNumber}");
        }

        [StepDefinition(@"I type (.*) the input field")]
        public void WhenITypeTheInputField(string text)
        {
            CurrentPage.As<FormPage>().TypeName(text);
        }

        [StepDefinition(@"I submit the form")]
        public void WhenISubmitTheForm()
        {
            CurrentPage = CurrentPage.As<FormPage>().SubmitForm();
        }
    }
}
