using lj_framework.Base;
using OpenQA.Selenium;
using System;

namespace lj_tests.Pages
{
    public class Page : BasePage
    {
        protected IWebElement MainMenuButton => _driver.FindElement(By.Id("site"));

        protected IWebElement HomeMenuButton => _driver.FindElement(By.Id("home"));

        protected IWebElement FormMenuButton => _driver.FindElement(By.Id("form"));

        protected IWebElement ErrorMenuButton => _driver.FindElement(By.Id("error"));

        protected IWebElement Logo => _driver.FindElement(By.Id("dh_logo"));

        public string PageTitle => _driver.Title;

        public bool IsLogoDisplayed => Logo.Displayed;

        public HomePage NavigateToHome()
        {
            HomeMenuButton.Click();
            return GetInstance<HomePage>();
        }

        public FormPage NavigateToForm()
        {
            FormMenuButton.Click();
            return GetInstance<FormPage>();
        }

        public ErrorPage NavigateToError()
        {
            ErrorMenuButton.Click();
            return GetInstance<ErrorPage>();
        }

        public HomePage NavigateToMain()
        {
            MainMenuButton.Click();
            return GetInstance<HomePage>();
        }

        public Uri GetPageUrl()
        {
            return new Uri(_driver.Url);
        }

        //public string GetAbsolutePath()
        //{
        //    return GetPageUrl().AbsolutePath;
        //}

        protected bool IsMenuButtonActive(IWebElement element)
        {
            var classAttributeValue = element.FindElement(By.XPath("..")).GetAttribute("class");
            return classAttributeValue == "active";
        }

        public int GetNumberOfVisibleElements(string locator)
        {
            var numberOfVisibleElements = 0;
            foreach (var element in _driver.FindElements(By.XPath($"//{locator}")))
            {
                if (element.Displayed)
                {
                    numberOfVisibleElements++;
                }
            }
            return numberOfVisibleElements;
        }
    }
}
