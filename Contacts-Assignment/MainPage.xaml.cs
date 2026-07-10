using System.Collections.ObjectModel;

namespace Contacts_Assignment
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<ContactGroup> Contacts { get; set; }

        public MainPage()
        {
            InitializeComponent();

            Contacts = new ObservableCollection<ContactGroup>
            {
                new ContactGroup("C - F")
                {
                    new Contact
                    {
                        Name = "Captain Chips",
                        Image = "pics1.png",
                        Email = "captainchips@seagullmail.com",
                        Phone = "555-0101",
                        Description = "Captain of the local fry patrol. Has never successfully paid for a french fry."
                    },
                    new Contact
                    {
                        Name = "Dock Inspector",
                        Image = "pics2.png",
                        Email = "dockinspector@seagullmail.com",
                        Phone = "555-0102",
                        Description = "Inspects docks professionally. Mostly looking for unattended sandwiches."
                    },
                    new Contact
                    {
                        Name = "French Fry Thief",
                        Image = "pics3.png",
                        Email = "frenchfrythief@seagullmail.com",
                        Phone = "555-0103",
                        Description = "Wanted in seventeen beach towns for grand theft potato."
                    }
                },

                new ContactGroup("G")
                {
                    new Contact
                    {
                        Name = "Gullbert",
                        Image = "pics4.png",
                        Email = "gullbert@seagullmail.com",
                        Phone = "555-0201",
                        Description = "Polite until food appears."
                    },
                    new Contact
                    {
                        Name = "Gullfred",
                        Image = "pics1.png",
                        Email = "gullfred@seagullmail.com",
                        Phone = "555-0202",
                        Description = "Collects shiny bottle caps and refuses to explain why."
                    },
                    new Contact
                    {
                        Name = "Gulliam",
                        Image = "pics2.png",
                        Email = "gulliam@seagullmail.com",
                        Phone = "555-0203",
                        Description = "Pretends to be sophisticated. Still screams at boats."
                    },
                    new Contact
                    {
                        Name = "Gullia",
                        Image = "pics3.png",
                        Email = "gullia@seagullmail.com",
                        Phone = "555-0204",
                        Description = "Will absolutely steal your picnic."
                    },
                    new Contact
                    {
                        Name = "Gulliver",
                        Image = "pics4.png",
                        Email = "gulliver@seagullmail.com",
                        Phone = "555-0205",
                        Description = "Dreams of seeing every coastline in the world."
                    },
                    new Contact
                    {
                        Name = "Gulloria",
                        Image = "pics1.png",
                        Email = "gulloria@seagullmail.com",
                        Phone = "555-0206",
                        Description = "Queen of dramatic seagull entrances."
                    }
                },

                new ContactGroup("H - M")
                {
                    new Contact
                    {
                        Name = "Harbor Karen",
                        Image = "pics2.png",
                        Email = "harborkaren@seagullmail.com",
                        Phone = "555-0301",
                        Description = "Would like to speak to the captain immediately."
                    },
                    new Contact
                    {
                        Name = "McGull",
                        Image = "pics3.png",
                        Email = "mcgull@seagullmail.com",
                        Phone = "555-0302",
                        Description = "No relation to any fast-food restaurants, allegedly."
                    },
                    new Contact
                    {
                        Name = "Mine Mine",
                        Image = "pics4.png",
                        Email = "minemine@seagullmail.com",
                        Phone = "555-0303",
                        Description = "Communication skills consist entirely of shouting Mine."
                    }
                },

                new ContactGroup("S")
                {
                    new Contact
                    {
                        Name = "Seagillian",
                        Image = "pics1.png",
                        Email = "seagillian@seagullmail.com",
                        Phone = "555-0401",
                        Description = "A very distinguished bird with absolutely no qualifications."
                    },
                    new Contact
                    {
                        Name = "Sir Squawks-a-Lot",
                        Image = "pics2.png",
                        Email = "sirsquawks@seagullmail.com",
                        Phone = "555-0402",
                        Description = "Knighted for excessive squawking."
                    },
                    new Contact
                    {
                        Name = "Steven Seagull",
                        Image = "pics3.png",
                        Email = "stevenseagull@seagullmail.com",
                        Phone = "555-0403",
                        Description = "The most famous seagull on the boardwalk."
                    }
                },

                new ContactGroup("W")
                {
                    new Contact
                    {
                        Name = "Wing Commander Waffles",
                        Image = "pics4.png",
                        Email = "waffles@seagullmail.com",
                        Phone = "555-0501",
                        Description = "Somehow always knows exactly where breakfast is being served."
                    }
                }
            };

            ContactsCollectionView.ItemsSource = Contacts;
        }

        private async void ContactsCollectionView_SelectionChanged(
            object sender,
            SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.FirstOrDefault() is Contact selectedContact)
            {
                await Navigation.PushAsync(
                    new ContactsDetailsPage(selectedContact));

                ContactsCollectionView.SelectedItem = null;
            }
        }
    }
}