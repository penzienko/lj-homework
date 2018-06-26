using lj_framework.Config;

namespace lj_framework.Base
{
    public abstract class BaseStep : Base
    {
        public virtual void NavigateSite()
        {
            DriverContext.Driver.Navigate().GoToUrl(Settings.AUT);
        }
    }
}
