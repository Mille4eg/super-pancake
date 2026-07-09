namespace Contacts_Assignment
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(ContactsDetailsPage), typeof(ContactsDetailsPage));
        }
    }
}