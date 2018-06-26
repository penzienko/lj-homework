using OpenQA.Selenium;

namespace lj_tests.Pages
{
    public class FormPage : Page
    {
        private IWebElement NameInput => _driver.FindElement(By.Id("hello-input"));

        private IWebElement SubmitButton => _driver.FindElement(By.Id("hello-submit"));

        public bool IsFormMenuButtonActive()
        {
            return IsMenuButtonActive(FormMenuButton);
        }

        public FormPage TypeName(string name)
        {
            NameInput.SendKeys(name);
            return this;
        }

        public HelloPage SubmitForm()
        {
            SubmitButton.Submit();
            return GetInstance<HelloPage>();
        }
    }
}
