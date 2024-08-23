using TestApp.Model;
namespace TestApp.Pages;
public partial class Registration2 : ContentPage
{
    private string sex;
    private string date;
    private UserLoginInfo ParentInfo;
    public Registration2(UserLoginInfo userLoginInfo)
	{
		InitializeComponent();
        ParentInfo = userLoginInfo;
    }

    private UserData CreateDataEntity()
    {
        UserData userData = new UserData()
        {
            FirstName1 = FirstName_Editor.Text,
            MiddelName1 = MiddelName_Editor.Text,
            LastName1 = LastName_Editor.Text,
            AccountName1 = ParentInfo.AccountName,
            EmailAddress1 = ParentInfo.EmailAddress,
            StreetAddress1 = StreetAddress_Editor.Text,
            City1 = City_Editor.Text,
            Suburb1 = Suburb_Editor.Text,
            Province1= Province_Editor.Text,   
            ContactNumber1 = ContactNumber_Editor.Text,
            Country1 = Country_Editor.Text,
            Race1 = Race_Picker.SelectedItem.ToString(),
            FKID1 = ParentInfo.Id,
            Sex1 = sex,
            Birthdate1 = date,
        };
        return userData;
    }

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