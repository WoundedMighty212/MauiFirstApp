namespace TestApp.Pages;
using Model;
public partial class Registration : ContentPage
{
	public Registration()
	{
		InitializeComponent();
	}
    private UserLoginInfo CreateDataEntity()
    {
        UserLoginInfo userLoginInfo = new UserLoginInfo()
        {
            AccountName = AccountName_Editor.Text,
            EmailAddress = EmailAddress_Editor.Text,
            Password = Password_Editor.Text
        };
        return userLoginInfo;
    }

    private bool ValidateData()
    {
        bool isEmailSame = false;
        bool isPassSame = false;
        if (EmailAddress_Editor.Text != Retype_EmailAddress_Editor.Text)
        {
            lblEmailmatch.IsVisible = true;
            isEmailSame = false;
        }
        else
        {
            lblEmailmatch.IsVisible = false;
            isEmailSame = true;
        }
        if(Password_Editor.Text != Retype_Password_Editor.Text)
        {
            lblPassmatch.IsVisible = true;
            isPassSame = false;
        }
        else
        {
            lblPassmatch.IsVisible = false;
            isPassSame = true;
        }
        if(isEmailSame == true && isPassSame == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private void Next_Register_Clicked(object sender, EventArgs e)
    {
        if (ValidateData())
        {
            Task task = NavigateToRegistrationPageAsync(CreateDataEntity());
        }
    }

    private async Task NavigateToRegistrationPageAsync(UserLoginInfo userLoginInfo)
    {
        await Navigation.PushAsync(new Registration2(userLoginInfo));
    }
}