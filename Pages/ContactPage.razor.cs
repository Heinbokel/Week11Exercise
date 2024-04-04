using System.Reflection.PortableExecutable;
using Microsoft.AspNetCore.Components;
using Week11Exercise.Models;

namespace Week11Exercise.Pages;

public partial class ContactPage : ComponentBase
{

    List<Contact> Contacts { get; set; } = new List<Contact>
        {
            new Contact { FullName = "John Doe", PhoneNumber = "123-456-7890" },
            new Contact { FullName = "Jane Smith", PhoneNumber = "987-654-3210" },
            new Contact { FullName = "Michael Johnson", PhoneNumber = "456-789-0123" },
            new Contact { FullName = "Emily Davis", PhoneNumber = "789-012-3456" },
            new Contact { FullName = "Daniel Wilson", PhoneNumber = "234-567-8901" },
            new Contact { FullName = "Sarah Brown", PhoneNumber = "567-890-1234" },
            new Contact { FullName = "Christopher Lee", PhoneNumber = "012-345-6789" },
            new Contact { FullName = "Jessica Taylor", PhoneNumber = "890-123-4567" },
            new Contact { FullName = "Ryan Martinez", PhoneNumber = "345-678-9012" },
            new Contact { FullName = "Amanda Rodriguez", PhoneNumber = "901-234-5678" }
        };

    private void OnContactDeleted(Contact contactToDelete) {
        this.Contacts.Remove(contactToDelete);
    }

    private void OnContactCreated(Contact contactToAdd) {
        this.Contacts.Add(contactToAdd);
    }

}