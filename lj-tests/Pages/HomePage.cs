using OpenQA.Selenium;

namespace lj_tests.Pages
{
    public class HomePage : Page
    {
        public bool IsHomeMenuButtonActive()
        {
            return IsMenuButtonActive(HomeMenuButton);
        }

        public string GetContainterTagName(string text)
        {
            var element = _driver.FindElement(By.XPath($"//*[contains(text(), '{text}')]"));
            return element.TagName;
        }

    }
}