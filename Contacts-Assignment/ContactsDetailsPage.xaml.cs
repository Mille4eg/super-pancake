using System.Xml;

namespace Contacts_Assignment
{
    public partial class ContactsDetailsPage : ContentPage
    {
        public ContactsDetailsPage(Contact contact)
        {
            InitializeComponent();

            ContactImage.Source = contact.Image;
            NameLabel.Text = contact.Name;
            EmailLabel.Text = $"Email: {contact.Email}";
            PhoneLabel.Text = $"Phone: {contact.Phone}";
            DescriptionLabel.Text = contact.Description;
        }

        private async void BackButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}