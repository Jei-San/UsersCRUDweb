// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace UsersCRUDweb.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\jason\Desktop\UsuariosCRUDweb\UsuariosCRUDweb\UsersCRUDweb\UsersCRUDweb\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jason\Desktop\UsuariosCRUDweb\UsuariosCRUDweb\UsersCRUDweb\UsersCRUDweb\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jason\Desktop\UsuariosCRUDweb\UsuariosCRUDweb\UsersCRUDweb\UsersCRUDweb\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jason\Desktop\UsuariosCRUDweb\UsuariosCRUDweb\UsersCRUDweb\UsersCRUDweb\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jason\Desktop\UsuariosCRUDweb\UsuariosCRUDweb\UsersCRUDweb\UsersCRUDweb\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jason\Desktop\UsuariosCRUDweb\UsuariosCRUDweb\UsersCRUDweb\UsersCRUDweb\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jason\Desktop\UsuariosCRUDweb\UsuariosCRUDweb\UsersCRUDweb\UsersCRUDweb\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\jason\Desktop\UsuariosCRUDweb\UsuariosCRUDweb\UsersCRUDweb\UsersCRUDweb\Client\_Imports.razor"
using UsersCRUDweb.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\jason\Desktop\UsuariosCRUDweb\UsuariosCRUDweb\UsersCRUDweb\UsersCRUDweb\Client\_Imports.razor"
using UsersCRUDweb.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\jason\Desktop\UsuariosCRUDweb\UsuariosCRUDweb\UsersCRUDweb\UsersCRUDweb\Client\_Imports.razor"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\jason\Desktop\UsuariosCRUDweb\UsuariosCRUDweb\UsersCRUDweb\UsersCRUDweb\Client\Pages\EditUser.razor"
       
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
