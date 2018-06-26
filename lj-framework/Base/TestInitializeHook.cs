using lj_framework.Config;
using OpenQA.Selenium.Chrome;

namespace lj_framework.Base
{
    public abstract class TestInitializeHook : Base
    {
        public void InitializeSettings()
        {
            ConfigReader.SetFrameworkSettings();
            DriverContext.Driver = new ChromeDriver();
            DriverContext.Driver.Manage().Window.Maximize();

        }
    }
}
