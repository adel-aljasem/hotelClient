#pragma checksum "C:\Hotel\Hotel_Client\Pages\Authentication\RedirectToLogin.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cdcc31c5c2c7322870f0c58dd412b4eed107d9b3"
// <auto-generated/>
#pragma warning disable 1591
namespace Hotel_Client.Pages.Authentication
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Hotel\Hotel_Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Hotel\Hotel_Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Hotel\Hotel_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Hotel\Hotel_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Hotel\Hotel_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Hotel\Hotel_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Hotel\Hotel_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Hotel\Hotel_Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Hotel\Hotel_Client\_Imports.razor"
using Hotel_Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Hotel\Hotel_Client\_Imports.razor"
using Hotel_Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Hotel\Hotel_Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Hotel\Hotel_Client\_Imports.razor"
using Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Hotel\Hotel_Client\_Imports.razor"
using Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Hotel\Hotel_Client\_Imports.razor"
using Model.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Hotel\Hotel_Client\_Imports.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Hotel\Hotel_Client\_Imports.razor"
using Hotel_Client.Service.IService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Hotel\Hotel_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
    public partial class RedirectToLogin : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Hotel\Hotel_Client\Pages\Authentication\RedirectToLogin.razor"
 if (notAuthorized) {


#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<div><p>\r\n            لايوجد لديك صلاحية الوصول لهذا الصفحة\r\n        </p></div>");
#nullable restore
#line 10 "C:\Hotel\Hotel_Client\Pages\Authentication\RedirectToLogin.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\Hotel\Hotel_Client\Pages\Authentication\RedirectToLogin.razor"
       

    [CascadingParameter]
    private Task<AuthenticationState> authentication { get; set; }
    bool notAuthorized { get; set; } = false;


    protected async override Task OnInitializedAsync()
    {
        var authState = await authentication;

        if (authState?.User?.Identity is null || !authState.User.Identity.IsAuthenticated)
        {

            var returnUrl = nav.ToBaseRelativePath(nav.Uri);
            if (string.IsNullOrEmpty(returnUrl))
            {
                nav.NavigateTo("login", true);
            }
            else
            {
                nav.NavigateTo($"login?retrunurl={returnUrl}", true);
            }
        }
        else
        {
            notAuthorized = true;
        }

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nav { get; set; }
    }
}
#pragma warning restore 1591
