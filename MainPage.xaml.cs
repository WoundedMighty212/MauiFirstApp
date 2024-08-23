
using TestApp.Pages;

namespace TestApp
{
    public partial class MainPage : ContentPage //push
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void RegisterBtn_Clicked(object sender, EventArgs e)
        {
            Task task = NavigateToRegistrationPageAsync();
        }

        private void LoginBtn_Clicked(object sender, EventArgs e)
        {
            Task task = NavigateToLoginPageAsync();
        }

        private async Task NavigateToRegistrationPageAsync()
        {
            await Navigation.PushAsync(new Registration());
        }

        private async Task NavigateToLoginPageAsync()
        {
            await Navigation.PushAsync(new Login());
        }
    }

}
