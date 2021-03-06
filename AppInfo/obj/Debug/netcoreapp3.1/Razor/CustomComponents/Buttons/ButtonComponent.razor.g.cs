#pragma checksum "C:\Users\Anil\Desktop\AppInfo\AppInfo\CustomComponents\Buttons\ButtonComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f15592ef4197744886b19d93aba821347b2bc6b"
// <auto-generated/>
#pragma warning disable 1591
namespace AppInfo.CustomComponents.Buttons
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Anil\Desktop\AppInfo\AppInfo\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Anil\Desktop\AppInfo\AppInfo\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Anil\Desktop\AppInfo\AppInfo\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Anil\Desktop\AppInfo\AppInfo\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Anil\Desktop\AppInfo\AppInfo\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Anil\Desktop\AppInfo\AppInfo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Anil\Desktop\AppInfo\AppInfo\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Anil\Desktop\AppInfo\AppInfo\_Imports.razor"
using AppInfo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Anil\Desktop\AppInfo\AppInfo\_Imports.razor"
using AppInfo.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Anil\Desktop\AppInfo\AppInfo\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Anil\Desktop\AppInfo\AppInfo\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Anil\Desktop\AppInfo\AppInfo\_Imports.razor"
using AppInfo.CustomComponents.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Anil\Desktop\AppInfo\AppInfo\_Imports.razor"
using AppInfo.CustomComponents.ModalComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Anil\Desktop\AppInfo\AppInfo\_Imports.razor"
using AppInfo.Utils;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Anil\Desktop\AppInfo\AppInfo\_Imports.razor"
using AppInfo.Context;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Anil\Desktop\AppInfo\AppInfo\_Imports.razor"
using AppInfo.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Anil\Desktop\AppInfo\AppInfo\_Imports.razor"
using AppInfo.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Anil\Desktop\AppInfo\AppInfo\_Imports.razor"
using AppInfo.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Anil\Desktop\AppInfo\AppInfo\_Imports.razor"
using AppInfo.Services.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Anil\Desktop\AppInfo\AppInfo\_Imports.razor"
using AppInfo.Pages.Admin;

#line default
#line hidden
#nullable disable
    public partial class ButtonComponent : BaseButtonComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "button");
            __builder.AddAttribute(1, "class", "btn" + (
#nullable restore
#line 3 "C:\Users\Anil\Desktop\AppInfo\AppInfo\CustomComponents\Buttons\ButtonComponent.razor"
                    IsSmall ? " btn-sm":""

#line default
#line hidden
#nullable disable
            ) + " btn" + (
#nullable restore
#line 3 "C:\Users\Anil\Desktop\AppInfo\AppInfo\CustomComponents\Buttons\ButtonComponent.razor"
                                                 IsOutline ? "-outline":""

#line default
#line hidden
#nullable disable
            ) + "-" + (
#nullable restore
#line 3 "C:\Users\Anil\Desktop\AppInfo\AppInfo\CustomComponents\Buttons\ButtonComponent.razor"
                                                                             Color

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "type", "submit");
            __builder.AddAttribute(3, "disabled", 
#nullable restore
#line 5 "C:\Users\Anil\Desktop\AppInfo\AppInfo\CustomComponents\Buttons\ButtonComponent.razor"
                   IsBusy

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(4, "onclick", 
#nullable restore
#line 6 "C:\Users\Anil\Desktop\AppInfo\AppInfo\CustomComponents\Buttons\ButtonComponent.razor"
                  OnClick

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(5, "title", 
#nullable restore
#line 7 "C:\Users\Anil\Desktop\AppInfo\AppInfo\CustomComponents\Buttons\ButtonComponent.razor"
                ToolTipStr

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "span");
            __builder.AddAttribute(8, "class", "fa" + " fa-" + (
#nullable restore
#line 8 "C:\Users\Anil\Desktop\AppInfo\AppInfo\CustomComponents\Buttons\ButtonComponent.razor"
                        Icon

#line default
#line hidden
#nullable disable
            ) + " fa-fw");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 9 "C:\Users\Anil\Desktop\AppInfo\AppInfo\CustomComponents\Buttons\ButtonComponent.razor"
     if (IsBusy)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(10, "        <span class=\"spinner-border spinner-border-sm mr-1\"></span>\r\n");
#nullable restore
#line 12 "C:\Users\Anil\Desktop\AppInfo\AppInfo\CustomComponents\Buttons\ButtonComponent.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "    ");
            __builder.AddContent(12, 
#nullable restore
#line 13 "C:\Users\Anil\Desktop\AppInfo\AppInfo\CustomComponents\Buttons\ButtonComponent.razor"
     Caption

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(13, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
