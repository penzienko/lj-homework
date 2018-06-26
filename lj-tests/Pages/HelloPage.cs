using OpenQA.Selenium;

namespace lj_tests.Pages
{
    public class HelloPage : Page
    {
        private IWebElement PageHeader => _driver.FindElement(By.TagName("h1"));

        public string GetPageHeader()
        {
            return PageHeader.Text;
        }
    }
}
