using System.Windows;

namespace Launcher.Resources
{
    public partial class LoginStyle
    {

        private void Close_Windows(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
