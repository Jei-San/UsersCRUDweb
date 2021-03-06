#pragma checksum "C:\Users\jason\Desktop\UsersCRUDweb\UsersCRUDweb\Client\Pages\EditUser.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "345619cb189492aaac461d5a464775efa9a5fa97"
// <auto-generated/>
#pragma warning disable 1591
namespace UsersCRUDweb.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\jason\Desktop\UsersCRUDweb\UsersCRUDweb\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jason\Desktop\UsersCRUDweb\UsersCRUDweb\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jason\Desktop\UsersCRUDweb\UsersCRUDweb\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jason\Desktop\UsersCRUDweb\UsersCRUDweb\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jason\Desktop\UsersCRUDweb\UsersCRUDweb\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jason\Desktop\UsersCRUDweb\UsersCRUDweb\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jason\Desktop\UsersCRUDweb\UsersCRUDweb\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\jason\Desktop\UsersCRUDweb\UsersCRUDweb\Client\_Imports.razor"
using UsersCRUDweb.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\jason\Desktop\UsersCRUDweb\UsersCRUDweb\Client\_Imports.razor"
using UsersCRUDweb.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\jason\Desktop\UsersCRUDweb\UsersCRUDweb\Client\_Imports.razor"
using UsersCRUDweb.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/userlist/edituser/{userId:int}")]
    public partial class EditUser : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Edit User</h2>\r\n");
            __builder.OpenComponent<UsersCRUDweb.Client.Shared.UserForm>(1);
            __builder.AddAttribute(2, "ButtonText", "Edit User");
            __builder.AddAttribute(3, "User", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<UsersCRUDweb.Shared.TblUser>(
#nullable restore
#line 6 "C:\Users\jason\Desktop\UsersCRUDweb\UsersCRUDweb\Client\Pages\EditUser.razor"
                                        user

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 7 "C:\Users\jason\Desktop\UsersCRUDweb\UsersCRUDweb\Client\Pages\EditUser.razor"
                          PutUser

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\jason\Desktop\UsersCRUDweb\UsersCRUDweb\Client\Pages\EditUser.razor"
       
    [Parameter] public int userId { get; set; }
    TblUser user = new TblUser();

    private async Task PutUser()
    {
        user.UserId = userId;
        await Http.PutAsJsonAsync("User/EditUsers", user);
        NavigationManager.NavigateTo("/userlist");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
