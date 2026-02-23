using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactListApplication
{
    public class ContactGroup : List<Contact>
    {
        public string GroupName { get; set; }
        public ContactGroup(string groupName, List<Contact> contacts) : base(contacts) { GroupName = groupName; }
    }
}
