namespace ContactListApplication;

public partial class ContactsPage : ContentPage
{
	public List<ContactGroup> Contacts = new List<ContactGroup>();
	public ContactsPage()
	{
		InitializeComponent();
		Contacts.Add(new ContactGroup("A", new List<Contact>
		{
			new Contact(){ Name="Abraham", Email="abraham@fakemail.com", PhoneNumber="(513) 555-8167", Description="Abraham from math", ImageName="pic_three.png" },
			new Contact(){ Name="Alice", Email="alice@fakemail.com", PhoneNumber="(514) 526-6754", Description="Alice from the coffee shop", ImageName="pic_two.png" },
            new Contact(){ Name="Alex", Email="alex@fakemail.com", PhoneNumber="(529) 709-4679", Description="Alex from work", ImageName="pic_four.png" }

        }));
        Contacts.Add(new ContactGroup("B", new List<Contact>
        {
            new Contact(){ Name="Becca", Email="becca@fakemail.com", PhoneNumber="(524) 616-2785", Description="Becca from English", ImageName="pic_one.png" },
            new Contact(){ Name="Ben", Email="ben@fakemail.com", PhoneNumber="(535) 478-9012", Description="Ben from work", ImageName="pic_four.png" },
            new Contact(){ Name="Bailey", Email="bailey@fakemail.com", PhoneNumber="(529) 709-4679", Description="Bailey from work", ImageName="pic_two.png" }

        }));
        Contacts.Add(new ContactGroup("C", new List<Contact>
        {
            new Contact(){ Name="Catherine", Email="Cat@fakemail.com", PhoneNumber="(562) 148-5890", Description="Cat from Programming", ImageName="pic_two.png" },
            new Contact(){ Name="Charles", Email="Charles@fakemail.com", PhoneNumber="(712) 478-9012", Description="Charles from Geology", ImageName="pic_one.png" },
            new Contact(){ Name="Chloe", Email="chloe@fakemail.com", PhoneNumber="(529) 709-4679", Description="Chloe from work", ImageName="pic_four.png" }

        }));
        Contacts.Add(new ContactGroup("D", new List<Contact>
        {
            new Contact(){ Name="David", Email="Dave@fakemail.com", PhoneNumber="(556) 780-4320", Description="David from English", ImageName="pic_three.png" },
            new Contact(){ Name="Dominic", Email="Dom@fakemail.com", PhoneNumber="(529) 709-4679", Description="Dominic from work", ImageName="pic_one.png" },
            new Contact(){ Name="Danielle", Email="Dan@fakemail.com", PhoneNumber="(529) 709-4679", Description="Dan from work", ImageName="pic_two.png" }

        }));
        Contacts.Add(new ContactGroup("E", new List<Contact>
        {
            new Contact(){ Name="Eve", Email="becca@fakemail.com", PhoneNumber="(524) 616-2785", Description="Becca from English", ImageName="pic_four.png" },
            new Contact(){ Name="Evan", Email="Evan@fakemail.com", PhoneNumber="(535) 478-9012", Description="Evan from work", ImageName="pic_one.png" },
            new Contact(){ Name="Eric", Email="Eric@fakemail.com", PhoneNumber="(535) 478-9012", Description="Eric from work", ImageName="pic_one.png" }

        }));
        CVContacts.ItemsSource = Contacts;
	}

    private void CVContacts_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var selectedItem = e.CurrentSelection.FirstOrDefault() as Contact;
        if (selectedItem == null) return;
#if WINDOWS
        // Force WinUI to clear the selected container
        if (CVContacts.Handler?.PlatformView is Microsoft.UI.Xaml.Controls.ListViewBase lv)
            lv.SelectedIndex = -1;
#endif
        Navigation.PushAsync(new contactDetailsPage(selectedItem));
        ((CollectionView)sender).SelectedItem = null;
    }
}