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
                new ContactGroup("A")
                {
                    new Contact
                    {
                        Name = "Ari Bloom",
                        Image = "pics1.png",
                        Email = "ari.bloom@email.com",
                        Phone = "555-100-1001",
                        Description = "Ari is a cheerful contact who enjoys gardening, photography, and weekend coffee trips."
                    },
                    new Contact
                    {
                        Name = "Ava Stone",
                        Image = "pics2.png",
                        Email = "ava.stone@email.com",
                        Phone = "555-100-1002",
                        Description = "Ava is organized, dependable, and always keeps track of important plans."
                    },
                    new Contact
                    {
                        Name = "Atlas Reed",
                        Image = "pics3.png",
                        Email = "atlas.reed@email.com",
                        Phone = "555-100-1003",
                        Description = "Atlas enjoys technology, hiking, and learning new creative skills."
                    }
                },

                new ContactGroup("B")
                {
                    new Contact
                    {
                        Name = "Bella Moon",
                        Image = "pics4.png",
                        Email = "bella.moon@email.com",
                        Phone = "555-200-2001",
                        Description = "Bella is friendly, artistic, and loves sharing book recommendations."
                    },
                    new Contact
                    {
                        Name = "Ben Carter",
                        Image = "pics1.png",
                        Email = "ben.carter@email.com",
                        Phone = "555-200-2002",
                        Description = "Ben is calm, practical, and usually the first person to solve a problem."
                    },
                    new Contact
                    {
                        Name = "Briar Lane",
                        Image = "pics2.png",
                        Email = "briar.lane@email.com",
                        Phone = "555-200-2003",
                        Description = "Briar has a creative eye and enjoys design, music, and cozy projects."
                    }
                },

                new ContactGroup("C")
                {
                    new Contact
                    {
                        Name = "Cleo Hart",
                        Image = "pics3.png",
                        Email = "cleo.hart@email.com",
                        Phone = "555-300-3001",
                        Description = "Cleo is energetic, funny, and always brings good ideas to the table."
                    },
                    new Contact
                    {
                        Name = "Cal Quinn",
                        Image = "pics4.png",
                        Email = "cal.quinn@email.com",
                        Phone = "555-300-3002",
                        Description = "Cal enjoys coding, puzzles, and working on small app ideas."
                    },
                    new Contact
                    {
                        Name = "Cora Finch",
                        Image = "pics1.png",
                        Email = "cora.finch@email.com",
                        Phone = "555-300-3003",
                        Description = "Cora is thoughtful, detail-oriented, and loves quiet afternoons."
                    }
                },

                new ContactGroup("D")
                {
                    new Contact
                    {
                        Name = "Daisy Wells",
                        Image = "pics2.png",
                        Email = "daisy.wells@email.com",
                        Phone = "555-400-4001",
                        Description = "Daisy is bright, kind, and enjoys cooking and collecting cute stationery."
                    },
                    new Contact
                    {
                        Name = "Dante Rivers",
                        Image = "pics3.png",
                        Email = "dante.rivers@email.com",
                        Phone = "555-400-4002",
                        Description = "Dante likes games, teamwork, and finding clever solutions."
                    },
                    new Contact
                    {
                        Name = "Delia Fox",
                        Image = "pics4.png",
                        Email = "delia.fox@email.com",
                        Phone = "555-400-4003",
                        Description = "Delia is confident, stylish, and always ready for a new challenge."
                    }
                },

                new ContactGroup("E")
                {
                    new Contact
                    {
                        Name = "Eli Moss",
                        Image = "pics1.png",
                        Email = "eli.moss@email.com",
                        Phone = "555-500-5001",
                        Description = "Eli is easygoing, reliable, and enjoys learning about new technology."
                    },
                    new Contact
                    {
                        Name = "Ember Vale",
                        Image = "pics2.png",
                        Email = "ember.vale@email.com",
                        Phone = "555-500-5002",
                        Description = "Ember is creative, bold, and loves colorful design work."
                    },
                    new Contact
                    {
                        Name = "Ezra Lake",
                        Image = "pics3.png",
                        Email = "ezra.lake@email.com",
                        Phone = "555-500-5003",
                        Description = "Ezra is curious, thoughtful, and enjoys solving technical problems."
                    }
                }
            };

            ContactsCollectionView.ItemsSource = Contacts;
        }

        private async void ContactsCollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.FirstOrDefault() is Contact selectedContact)
            {
                await Navigation.PushAsync(new ContactsDetailsPage(selectedContact));
                ContactsCollectionView.SelectedItem = null;
            }
        }
    }
}