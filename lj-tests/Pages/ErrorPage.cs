namespace lj_tests.Pages
{
    public class ErrorPage : Page
    {
        public bool IsErrorMenuButtonActive()
        {
            return IsMenuButtonActive(ErrorMenuButton);
        }
    }
}
