namespace ContactListApplication;

public partial class contactDetailsPage : ContentPage
{
	public contactDetailsPage(Contact item)
	{
		InitializeComponent();
        AvatarImage.Source = item.ImageName;
        LblName.Text = item.Name;
        LblEmail.Text = item.Email;
        LblPhoneNumber.Text = item.PhoneNumber;
        LblContactDesc.Text = item.Description;

    }

    private void BtnBack_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}