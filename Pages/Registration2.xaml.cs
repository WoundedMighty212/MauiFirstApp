using TestApp.Model;
namespace TestApp.Pages;
public partial class Registration2 : ContentPage
{
    private UserLoginInfo ParentInfo;
    public Registration2(UserLoginInfo userLoginInfo)
	{
		InitializeComponent();
        ParentInfo = userLoginInfo;
    }

    //private UserData

    private void Race_Picker_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void FemaleRadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {

    }

    private void MaleRadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {

    }

    private void Country_Editor_TextChanged(object sender, TextChangedEventArgs e)
    {

    }

    private void Province_Editor_TextChanged(object sender, TextChangedEventArgs e)
    {

    }

    private void City_Editor_TextChanged(object sender, TextChangedEventArgs e)
    {

    }

    private void Suburb_Editor_TextChanged(object sender, TextChangedEventArgs e)
    {

    }

    private void Submit_Register_Clicked(object sender, EventArgs e)
    {

    }
}