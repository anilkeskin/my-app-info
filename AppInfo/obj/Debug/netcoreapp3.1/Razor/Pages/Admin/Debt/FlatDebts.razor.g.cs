#pragma checksum "C:\Users\Anil\Desktop\AppInfo\AppInfo\Pages\Admin\Debt\FlatDebts.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "170bb42fb71ea783a8e1345ae9f5001f25d5cd77"
// <auto-generated/>
#pragma warning disable 1591
namespace AppInfo.Pages.Admin.Debt
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/debts")]
    public partial class FlatDebts : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Aidatlar</h3>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(1);
            __builder.AddAttribute(2, "class", "nav-link");
            __builder.AddAttribute(3, "href", "addnewdebt");
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    <span class=\"oi oi-plus\" aria-hidden=\"true\"></span>Yeni Aidat Ekle\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n");
#nullable restore
#line 8 "C:\Users\Anil\Desktop\AppInfo\AppInfo\Pages\Admin\Debt\FlatDebts.razor"
 if (objDebt == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "    ");
            __builder.AddMarkupContent(8, "<p><em>Y??kleniyor...</em></p>\r\n");
#nullable restore
#line 11 "C:\Users\Anil\Desktop\AppInfo\AppInfo\Pages\Admin\Debt\FlatDebts.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "    ");
            __builder.OpenElement(10, "table");
            __builder.AddAttribute(11, "class", "table");
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.AddMarkupContent(13, "<thead>\r\n            <tr>\r\n                <th>Aidat Ad??</th>\r\n                <th>Tutar</th>\r\n                <th>Daire</th>\r\n                <th>Aksiyon</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(14, "tbody");
            __builder.AddMarkupContent(15, "\r\n");
#nullable restore
#line 24 "C:\Users\Anil\Desktop\AppInfo\AppInfo\Pages\Admin\Debt\FlatDebts.razor"
             foreach (var dbt in objDebt)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "                ");
            __builder.OpenElement(17, "tr");
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 27 "C:\Users\Anil\Desktop\AppInfo\AppInfo\Pages\Admin\Debt\FlatDebts.razor"
                         dbt.DebtName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 28 "C:\Users\Anil\Desktop\AppInfo\AppInfo\Pages\Admin\Debt\FlatDebts.razor"
                         dbt.Total

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 29 "C:\Users\Anil\Desktop\AppInfo\AppInfo\Pages\Admin\Debt\FlatDebts.razor"
                         dbt.FlatNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n\r\n                    ");
            __builder.OpenElement(28, "td");
            __builder.AddMarkupContent(29, "\r\n                        ");
            __builder.OpenElement(30, "a");
            __builder.AddAttribute(31, "class", "nav-link");
            __builder.AddAttribute(32, "href", "editdebt/" + (
#nullable restore
#line 32 "C:\Users\Anil\Desktop\AppInfo\AppInfo\Pages\Admin\Debt\FlatDebts.razor"
                                                            dbt.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(33, "\r\n                            <span class=\"oi oi-pencil\" aria-hidden=\"true\"></span>G??ncelle\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                        ");
            __builder.OpenElement(35, "a");
            __builder.AddAttribute(36, "class", "nav-link");
            __builder.AddAttribute(37, "href", "DeleteDebt/" + (
#nullable restore
#line 35 "C:\Users\Anil\Desktop\AppInfo\AppInfo\Pages\Admin\Debt\FlatDebts.razor"
                                                              dbt.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(38, "\r\n                            <span class=\"oi oi-trash\" aria-hidden=\"true\"></span>Sil\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n");
#nullable restore
#line 40 "C:\Users\Anil\Desktop\AppInfo\AppInfo\Pages\Admin\Debt\FlatDebts.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(42, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n");
#nullable restore
#line 43 "C:\Users\Anil\Desktop\AppInfo\AppInfo\Pages\Admin\Debt\FlatDebts.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Users\Anil\Desktop\AppInfo\AppInfo\Pages\Admin\Debt\FlatDebts.razor"
       

    List<Debt> objDebt;
    protected override async Task OnInitializedAsync()
    {
        objDebt = await Task.Run(() => objDebtService.GetDebts());
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDebtService objDebtService { get; set; }
    }
}
#pragma warning restore 1591
