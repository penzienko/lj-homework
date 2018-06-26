using lj_framework.Base;
using lj_framework.Config;
using lj_tests.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace lj_tests.Steps
{
    [Binding]
    internal class ExtendedSteps : BaseStep
    {
        [StepDefinition(@"I have navigated to the application")]
        public void GivenIHaveNavigatedToTheApplication()
        {
            NavigateSite();
            CurrentPage = GetInstance<Page>();
        }

        [StepDefinition(@"I click (.*) menu")]
        public void WhenIClickMenuButton(string menuButton)
        {
            switch (menuButton.ToLower())
            {
                case "home":
                    CurrentPage = CurrentPage.As<Page>().NavigateToHome();
                    break;
                case "error":
                    CurrentPage = CurrentPage.As<Page>().NavigateToError();
                    break;
                case "form":
                    CurrentPage = CurrentPage.As<Page>().NavigateToForm();
                    break;
                case "ui testing":
                    CurrentPage = CurrentPage.As<Page>().NavigateToMain();
                    break;
                default:
                    throw new Exception($"ERROR: There is no such item in the menu: {menuButton}");
            }
        }

        [StepDefinition(@"The title should be ""(.*)""")]
        public void ThenTheTitleShouldBe(string expectedPageTitle)
        {
            var actualPageTitle = CurrentPage.As<Page>().PageTitle;
            Assert.That(actualPageTitle, Is.EqualTo(expectedPageTitle),
                $"ERROR: Page title is incorrect: {actualPageTitle}");
        }

        [StepDefinition(@"The company logo should be visible")]
        public void ThenTheCompanyLogoShouldBeVisible()
        {
            Assert.That(CurrentPage.As<Page>().IsLogoDisplayed, Is.True, "ERROR: There is no logo on the page");
        }

        [StepDefinition(@"I should get navigated to the (.*) page")]
        public void ThenIShouldGetNavigatedToThePage(string pageName)
        {
            var actualAbsolutePath = CurrentPage.As<Page>().GetPageUrl().AbsolutePath;
            var errorMessage = $"ERROR: Actual absolute path is: {actualAbsolutePath}";

            switch (pageName.ToLower())
            {
                case "home":
                    StringAssert.Contains("/", actualAbsolutePath, errorMessage);
                    break;
                case "form":
                    StringAssert.Contains("/form.html", actualAbsolutePath, errorMessage);
                    break;
                case "error":
                    StringAssert.Contains("/error", actualAbsolutePath, errorMessage);
                    break;
                case "hello":
                    StringAssert.Contains("/hello.html", actualAbsolutePath, errorMessage);
                    break;
                default:
                    throw new Exception($"ERROR: there is no such page: {pageName}");
            }
        }

        [StepDefinition(@"It should turn to active status")]
        public void ThenItShouldTurnToActiveStatus()
        {
            Type t = CurrentPage.GetType();
            if (t.Equals(typeof(HomePage)))
            {
                Assert.That(CurrentPage.As<HomePage>().IsHomeMenuButtonActive, Is.True, "ERROR: Home Menu button is not active");
            }
            else if (t.Equals(typeof(FormPage)))
            {
                Assert.That(CurrentPage.As<FormPage>().IsFormMenuButtonActive, Is.True, "ERROR: Form Menu button is not active");
            }
            else if (t.Equals(typeof(ErrorPage)))
            {
                Assert.That(CurrentPage.As<ErrorPage>().IsErrorMenuButtonActive, Is.True, "ERROR: Error Menu button is not active");
            }
            else
            {
                throw new Exception("ERROR: Your page is undefined");
            }
        }

        [StepDefinition(@"I open the (.*) page")]
        public void WhenIOpenThePage(string pageName)
        {
            switch (pageName.ToLower())
            {
                case "home":
                    DriverContext.Driver.Navigate().GoToUrl(Settings.AUT);
                    CurrentPage = GetInstance<HomePage>();
                    break;
                case "form":
                    DriverContext.Driver.Navigate().GoToUrl(Settings.AUT + "/form.html");
                    CurrentPage = GetInstance<FormPage>();
                    break;
                case "error":
                    DriverContext.Driver.Navigate().GoToUrl(Settings.AUT + "/error");
                    CurrentPage = GetInstance<ErrorPage>();
                    break;
                case "hello":
                    DriverContext.Driver.Navigate().GoToUrl(Settings.AUT + "/hello.html");
                    CurrentPage = GetInstance<HelloPage>();
                    break;
                default:
                    throw new Exception($"ERROR: There is no such page: {pageName}");
            }
        }


    }
}
