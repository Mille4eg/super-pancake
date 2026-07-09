using System.Collections.ObjectModel;

namespace Contacts_Assignment
{
    public class ContactGroup : ObservableCollection<Contact>
    {
        public string GroupName { get; set; }

        public ContactGroup(string groupName)
        {
            GroupName = groupName;
        }
    }
}