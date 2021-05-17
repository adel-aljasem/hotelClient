#pragma checksum "C:\Hotel\Hotel_Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ceef8c0c9c4abef43d93cb54c21ceb600ef04f4a"
// <auto-generated/>
#pragma warning disable 1591
namespace Hotel_Client.Shared
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "class", "navbar navbar-expand-sm navbar-dark bg-dark p-0");
            __builder.AddAttribute(2, "b-w67h2nqoxg");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand mx-4\" href=\"#\" b-w67h2nqoxg>Navbar</a>\r\n    ");
            __builder.AddMarkupContent(4, @"<button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"" b-w67h2nqoxg><span class=""navbar-toggler-icon"" b-w67h2nqoxg></span></button>

    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "collapse navbar-collapse pr-2");
            __builder.AddAttribute(7, "id", "navbarSupportedContent");
            __builder.AddAttribute(8, "b-w67h2nqoxg");
            __builder.AddMarkupContent(9, "<ul class=\"navbar-nav mr-auto\" b-w67h2nqoxg></ul>\r\n        ");
            __builder.OpenElement(10, "ul");
            __builder.AddAttribute(11, "class", "my-0 navbar-nav");
            __builder.AddAttribute(12, "b-w67h2nqoxg");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(13);
            __builder.AddAttribute(14, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(15, "li");
                __builder2.AddAttribute(16, "class", "nav-item p-0");
                __builder2.AddAttribute(17, "b-w67h2nqoxg");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(18);
                __builder2.AddAttribute(19, "class", "nav-link");
                __builder2.AddAttribute(20, "href", "#");
                __builder2.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(22, "span");
                    __builder3.AddAttribute(23, "class", "p-2");
                    __builder3.AddAttribute(24, "b-w67h2nqoxg");
                    __builder3.AddMarkupContent(25, "\r\n                                مرحبا ");
                    __builder3.AddContent(26, 
#nullable restore
#line 15 "C:\Hotel\Hotel_Client\Shared\NavMenu.razor"
                                       context.User.Identity.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n                    ");
                __builder2.OpenElement(28, "li");
                __builder2.AddAttribute(29, "class", "nav-item p-0");
                __builder2.AddAttribute(30, "b-w67h2nqoxg");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(31);
                __builder2.AddAttribute(32, "class", "nav-link");
                __builder2.AddAttribute(33, "href", "logout");
                __builder2.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(35, "<span class=\"p-2\" b-w67h2nqoxg>\r\n                                خروج\r\n                            </span>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(36, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(37, "li");
                __builder2.AddAttribute(38, "class", "nav-item p-0");
                __builder2.AddAttribute(39, "b-w67h2nqoxg");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(40);
                __builder2.AddAttribute(41, "class", "nav-link");
                __builder2.AddAttribute(42, "href", "registration");
                __builder2.AddAttribute(43, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(44, "<span class=\"p-2\" b-w67h2nqoxg>\r\n                                تسجيل\r\n                            </span>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n                    ");
                __builder2.OpenElement(46, "li");
                __builder2.AddAttribute(47, "class", "nav-item p-0");
                __builder2.AddAttribute(48, "b-w67h2nqoxg");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(49);
                __builder2.AddAttribute(50, "class", "nav-link");
                __builder2.AddAttribute(51, "href", "login");
                __builder2.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(53, "<span class=\"p-2\" b-w67h2nqoxg>\r\n                                دخول\r\n                            </span>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
