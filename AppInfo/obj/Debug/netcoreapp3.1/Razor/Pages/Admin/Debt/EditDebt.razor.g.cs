#pragma checksum "C:\Users\Anil\Desktop\AppInfo\AppInfo\Pages\Admin\Debt\EditDebt.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbd4ebf33a55b5f272e20461790202528ac20875"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/editdebt/{CurrentID}")]
    public partial class EditDebt : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Aidat G??ncelle</h2>\r\n<hr>\r\n\r\n");
            __builder.OpenElement(1, "form");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-md-8");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "form-group");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.AddMarkupContent(12, "<label for=\"Ad\" class=\"control-label\">Aidat ??simi</label>\r\n                ");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "form", "Ad");
            __builder.AddAttribute(15, "class", "form-control");
            __builder.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\Users\Anil\Desktop\AppInfo\AppInfo\Pages\Admin\Debt\EditDebt.razor"
                                                             objDebt.DebtName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objDebt.DebtName = __value, objDebt.DebtName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "form-group");
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.AddMarkupContent(23, "<label for=\"Total\" class=\"control-label\">Tutar</label>\r\n                ");
            __builder.OpenElement(24, "input");
            __builder.AddAttribute(25, "form", "Total");
            __builder.AddAttribute(26, "class", "form-control");
            __builder.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\Anil\Desktop\AppInfo\AppInfo\Pages\Admin\Debt\EditDebt.razor"
                                                                objDebt.Total

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objDebt.Total = __value, objDebt.Total));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "form-group");
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.AddMarkupContent(34, "<label for=\"FlatNumber\" class=\"control-label\">Daire Numaras??</label>\r\n                ");
            __builder.OpenElement(35, "select");
            __builder.AddAttribute(36, "class", "form-control");
            __builder.AddAttribute(37, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\Users\Anil\Desktop\AppInfo\AppInfo\Pages\Admin\Debt\EditDebt.razor"
                                                    objDebt.FlatNumber

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objDebt.FlatNumber = __value, objDebt.FlatNumber));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(39, "\r\n                    ");
            __builder.OpenElement(40, "option");
            __builder.AddAttribute(41, "value", true);
            __builder.AddMarkupContent(42, "-- Daire Numaras?? Se?? --");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                    ");
            __builder.OpenElement(44, "option");
            __builder.AddAttribute(45, "value", "1");
            __builder.AddContent(46, "1");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                    ");
            __builder.OpenElement(48, "option");
            __builder.AddAttribute(49, "value", "2");
            __builder.AddContent(50, "2");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                    ");
            __builder.OpenElement(52, "option");
            __builder.AddAttribute(53, "value", "3");
            __builder.AddContent(54, "3");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                    ");
            __builder.OpenElement(56, "option");
            __builder.AddAttribute(57, "value", "4");
            __builder.AddContent(58, "4");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                    ");
            __builder.OpenElement(60, "option");
            __builder.AddAttribute(61, "value", "5");
            __builder.AddContent(62, "5");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                    ");
            __builder.OpenElement(64, "option");
            __builder.AddAttribute(65, "value", "6");
            __builder.AddContent(66, "6");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                    ");
            __builder.OpenElement(68, "option");
            __builder.AddAttribute(69, "value", "7");
            __builder.AddContent(70, "7");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                    ");
            __builder.OpenElement(72, "option");
            __builder.AddAttribute(73, "value", "8");
            __builder.AddContent(74, "8");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n                    ");
            __builder.OpenElement(76, "option");
            __builder.AddAttribute(77, "value", "9");
            __builder.AddContent(78, "9");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                    ");
            __builder.OpenElement(80, "option");
            __builder.AddAttribute(81, "value", "10");
            __builder.AddContent(82, "10");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n    ");
            __builder.OpenElement(88, "div");
            __builder.AddAttribute(89, "class", "row");
            __builder.AddMarkupContent(90, "\r\n        ");
            __builder.OpenElement(91, "div");
            __builder.AddAttribute(92, "class", "col-md-4");
            __builder.AddMarkupContent(93, "\r\n            ");
            __builder.OpenElement(94, "div");
            __builder.AddAttribute(95, "class", "form-group");
            __builder.AddMarkupContent(96, "\r\n                ");
            __builder.OpenElement(97, "input");
            __builder.AddAttribute(98, "type", "button");
            __builder.AddAttribute(99, "class", "btn btn-primary");
            __builder.AddAttribute(100, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\Anil\Desktop\AppInfo\AppInfo\Pages\Admin\Debt\EditDebt.razor"
                                                                        UpdateDebt

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(101, "value", "G??ncelle");
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n                ");
            __builder.OpenElement(103, "input");
            __builder.AddAttribute(104, "type", "button");
            __builder.AddAttribute(105, "class", "btn btn-primary");
            __builder.AddAttribute(106, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\Anil\Desktop\AppInfo\AppInfo\Pages\Admin\Debt\EditDebt.razor"
                                                                        Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(107, "value", "??ptal Et");
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "C:\Users\Anil\Desktop\AppInfo\AppInfo\Pages\Admin\Debt\EditDebt.razor"
       
    [Parameter]
    public String CurrentID { get; set; }

    Debt objDebt = new Debt();
    protected void UpdateDebt()
    {
        objDebtService.UpdateDebt(objDebt);
        NavigationManager.NavigateTo("Debts");
    }
    void Cancel()
    {
        NavigationManager.NavigateTo("Debts");
    }

    protected override async Task OnInitializedAsync()
    {
        objDebt = await Task.Run(() => objDebtService.GetDebtById(Guid.Parse(CurrentID)));
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDebtService objDebtService { get; set; }
    }
}
#pragma warning restore 1591
