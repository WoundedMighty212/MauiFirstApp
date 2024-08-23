using System.ComponentModel;
using TestApp.Model;
namespace TestApp.Pages;
public partial class Registration2 : ContentPage
{
    private string sex;
    //private string date;
    private UserLoginInfo ParentInfo;
    public Registration2(UserLoginInfo userLoginInfo)
	{
		InitializeComponent();
        ParentInfo = userLoginInfo;
        UpdateDropDownlist();
    }

    private void UpdateDropDownlist()
    {
        Race_Picker.ItemsSource = Enum.GetNames(typeof(Enums.Races)).ToList();
    }

    private UserData CreateDataEntity()
    {
        if (MaleRadioButton.IsChecked)
        {
            sex = "Male";
        }
        if (FemaleRadioButton.IsChecked)
        {
            sex = "Female";
        }
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
            Race1 = Race_Picker.SelectedItem?.ToString() ?? string.Empty,
            FKID1 = ParentInfo.Id,
            Sex1 = sex,
            Birthdate1 = Birthdate_Picker.Date.ToShortDateString(),
        };
        return userData;
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