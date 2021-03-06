#pragma checksum "C:\Users\jason\Desktop\UsersCRUDweb\UsersCRUDweb\Client\Pages\UserList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4eb82d95facf9c85457fb6f51fc5003cda59f047"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/userlist")]
    public partial class UserList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>List Of Users</h1>\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "class", "btn btn-success");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "C:\Users\jason\Desktop\UsersCRUDweb\UsersCRUDweb\Client\Pages\UserList.razor"
                                           GetUsers

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(4, "GetUsers");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n<br>\r\n");
#nullable restore
#line 8 "C:\Users\jason\Desktop\UsersCRUDweb\UsersCRUDweb\Client\Pages\UserList.razor"
 if (Users == null)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "Loading...");
#nullable restore
#line 10 "C:\Users\jason\Desktop\UsersCRUDweb\UsersCRUDweb\Client\Pages\UserList.razor"
                           
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "container mb-3 mt-3");
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "table");
            __builder.AddAttribute(12, "class", "table table-striped table-bordered mydatatable");
            __builder.AddAttribute(13, "style", "width:100%");
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.AddMarkupContent(15, "<thead>\r\n                <tr>\r\n                    <th>First Name</th>\r\n                    <th>Last Name</th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            ");
            __builder.OpenElement(16, "tbody");
            __builder.AddMarkupContent(17, "\r\n");
#nullable restore
#line 24 "C:\Users\jason\Desktop\UsersCRUDweb\UsersCRUDweb\Client\Pages\UserList.razor"
                 foreach (var user in Users)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, "                    ");
            __builder.OpenElement(19, "tr");
            __builder.AddMarkupContent(20, "\r\n                        ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 27 "C:\Users\jason\Desktop\UsersCRUDweb\UsersCRUDweb\Client\Pages\UserList.razor"
                             user.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                        ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 28 "C:\Users\jason\Desktop\UsersCRUDweb\UsersCRUDweb\Client\Pages\UserList.razor"
                             user.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                        ");
            __builder.OpenElement(27, "td");
            __builder.AddMarkupContent(28, "\r\n                            ");
            __builder.OpenElement(29, "a");
            __builder.AddAttribute(30, "class", "btn btn-success");
            __builder.AddAttribute(31, "href", "userlist/edituser/" + (
#nullable restore
#line 30 "C:\Users\jason\Desktop\UsersCRUDweb\UsersCRUDweb\Client\Pages\UserList.razor"
                                                                                user.UserId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(32, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                            ");
            __builder.OpenElement(34, "button");
            __builder.AddAttribute(35, "class", "btn btn-danger");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\jason\Desktop\UsersCRUDweb\UsersCRUDweb\Client\Pages\UserList.razor"
                                                                      DeleteUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(37, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
#nullable restore
#line 34 "C:\Users\jason\Desktop\UsersCRUDweb\UsersCRUDweb\Client\Pages\UserList.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(41, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n");
#nullable restore
#line 38 "C:\Users\jason\Desktop\UsersCRUDweb\UsersCRUDweb\Client\Pages\UserList.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(45, "\r\n");
            __builder.AddMarkupContent(46, "<div>\r\n    <a class=\"btn btn-success\" href=\"userlist/createuser\">Create a User!</a>\r\n</div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\Users\jason\Desktop\UsersCRUDweb\UsersCRUDweb\Client\Pages\UserList.razor"
       
    [Parameter] public int userId { get; set; }
    List<TblUser> Users = new List<TblUser>();
    TblUser user = new TblUser();

    private async Task GetUsers()
    {
        Users = await Http.GetFromJsonAsync<List<TblUser>>("User/Users");
    }
    private async Task DeleteUser()
    {
        user.UserId = userId;
        await Http.PutAsJsonAsync("User/DeleteUsers", user);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
