#pragma checksum "E:\ResturentDemo\Resturent\Pages\Users.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4056990ee4b1882b554c19a92b3821f3e9c2b6a9"
// <auto-generated/>
#pragma warning disable 1591
namespace Resturent.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\ResturentDemo\Resturent\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ResturentDemo\Resturent\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\ResturentDemo\Resturent\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\ResturentDemo\Resturent\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\ResturentDemo\Resturent\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\ResturentDemo\Resturent\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\ResturentDemo\Resturent\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\ResturentDemo\Resturent\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\ResturentDemo\Resturent\_Imports.razor"
using Resturent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\ResturentDemo\Resturent\_Imports.razor"
using Resturent.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ResturentDemo\Resturent\Pages\Users.razor"
using Resturent.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/user")]
    public partial class Users : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Users</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(1);
            __builder.AddAttribute(2, "class", "nav-link");
            __builder.AddAttribute(3, "href", "/addUser");
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(5, "<span class=\"oi oi-plus\" aria-hidden=\"true\"></span> &nbsp; Add Users\r\n");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 13 "E:\ResturentDemo\Resturent\Pages\Users.razor"
 if (objUser == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "<p>Loading....</p>");
#nullable restore
#line 16 "E:\ResturentDemo\Resturent\Pages\Users.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "class", "table");
            __builder.AddMarkupContent(9, @"<thead><tr><th>UserName</th>
                <th>Password</th>
                <th>Email</th>
                <th>Email Password</th>
                <th>Mobile No.</th>
                <th>Is Admin</th>
                <th>Is Active</th>
                <th>Entry Date</th>
                <th>Modification Date</th></tr></thead>
        ");
            __builder.OpenElement(10, "tbody");
#nullable restore
#line 34 "E:\ResturentDemo\Resturent\Pages\Users.razor"
             foreach (var user in objUser)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "tr");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 37 "E:\ResturentDemo\Resturent\Pages\Users.razor"
                     user.UserName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 38 "E:\ResturentDemo\Resturent\Pages\Users.razor"
                     user.Password

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 39 "E:\ResturentDemo\Resturent\Pages\Users.razor"
                     user.EmailId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 40 "E:\ResturentDemo\Resturent\Pages\Users.razor"
                     user.EmailPass

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 41 "E:\ResturentDemo\Resturent\Pages\Users.razor"
                     user.MobileNo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.OpenElement(27, "td");
            __builder.AddContent(28, 
#nullable restore
#line 42 "E:\ResturentDemo\Resturent\Pages\Users.razor"
                     user.IsAdmin.GetValueOrDefault()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.OpenElement(30, "td");
            __builder.AddContent(31, 
#nullable restore
#line 43 "E:\ResturentDemo\Resturent\Pages\Users.razor"
                     user.IsActive.GetValueOrDefault()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                ");
            __builder.OpenElement(33, "td");
            __builder.AddContent(34, 
#nullable restore
#line 44 "E:\ResturentDemo\Resturent\Pages\Users.razor"
                     user.EDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                ");
            __builder.OpenElement(36, "td");
            __builder.AddContent(37, 
#nullable restore
#line 45 "E:\ResturentDemo\Resturent\Pages\Users.razor"
                     user.MDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n\r\n                ");
            __builder.OpenElement(39, "td");
            __builder.OpenElement(40, "a");
            __builder.AddAttribute(41, "href", "/editUser/" + (
#nullable restore
#line 48 "E:\ResturentDemo\Resturent\Pages\Users.razor"
                                        user.UserId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(42, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                    ");
            __builder.OpenElement(44, "a");
            __builder.AddAttribute(45, "href", "/deleteUser/" + (
#nullable restore
#line 49 "E:\ResturentDemo\Resturent\Pages\Users.razor"
                                          user.UserId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(46, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 52 "E:\ResturentDemo\Resturent\Pages\Users.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 55 "E:\ResturentDemo\Resturent\Pages\Users.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "E:\ResturentDemo\Resturent\Pages\Users.razor"
       
    List<User> objUser;

    protected override async Task OnInitializedAsync()
    {
        objUser = await Task.Run(() => objUserService.GetUser());
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserService objUserService { get; set; }
    }
}
#pragma warning restore 1591
