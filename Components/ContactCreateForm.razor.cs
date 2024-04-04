using Microsoft.AspNetCore.Components;
using Week11Exercise.Models;

namespace Week11Exercise.Components;

public partial class ContactCreateForm: ComponentBase {

    public Contact ContactToCreate {get; set;} = new Contact();

    [Parameter]
    public EventCallback<Contact> ContactCreated {get; set;} 

    private void CreateContact() {
        this.ContactCreated.InvokeAsync(this.ContactToCreate);
        this.ContactToCreate = new Contact();
    }

}