using Microsoft.AspNetCore.Components;
using Week11Exercise.Models;

namespace Week11Exercise.Components;

public partial class ContactCard: ComponentBase {

    [Parameter]
    public Contact Contact {get; set;}

    [Parameter]
    public EventCallback<Contact> ContactDeleted {get; set;}

    private void DeleteContact() {
        this.ContactDeleted.InvokeAsync(this.Contact);
    }

}