#pragma checksum "C:\Users\Anil\Desktop\AppInfo\AppInfo\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e1b216a2aa77b9fcada47c5e28ebd821133dcd5"
// <auto-generated/>
#pragma warning disable 1591
namespace AppInfo.Pages
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
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(EmptyLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<!DOCTYPE html>\r\n");
            __builder.AddMarkupContent(1, "<html>\r\n<head>\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n    <style>\r\n        body {\r\n            font-family: Arial, Helvetica, sans-serif;\r\n        }\r\n       \r\n\r\n        form {\r\n            border: 3px solid #f1f1f1;\r\n        }\r\n\r\n        input[type=text], input[type=password] {\r\n            width: 100%;\r\n            padding: 12px 20px;\r\n            margin: 8px 0;\r\n            display: inline-block;\r\n            border: 1px solid #ccc;\r\n            box-sizing: border-box;\r\n        }\r\n\r\n        button {\r\n            background-color: #04AA6D;\r\n            color: white;\r\n            padding: 14px 20px;\r\n            margin: 8px 0;\r\n            border: none;\r\n            cursor: pointer;\r\n            width: 100%;\r\n        }\r\n\r\n            button:hover {\r\n                opacity: 0.8;\r\n            }\r\n\r\n        .cancelbtn {\r\n            width: auto;\r\n            padding: 10px 18px;\r\n            background-color: #f44336;\r\n        }\r\n\r\n        .imgcontainer {\r\n            text-align: center;\r\n            margin: 24px 0 12px 0;\r\n        }\r\n\r\n        img.avatar {\r\n            width: 40%;\r\n            border-radius: 50%;\r\n        }\r\n\r\n        .container {\r\n            padding: 16px;\r\n        }\r\n\r\n        span.psw {\r\n            float: right;\r\n            padding-top: 16px;\r\n        }\r\n    </style>\r\n</head>\r\n<body>\r\n    <form action=\"/action_page.php\" method=\"post\">\r\n\r\n        <div class=\"container\">\r\n            <label for=\"uname\"><b>Username</b></label>\r\n            <input type=\"text\" placeholder=\"Enter Username\" name=\"uname\" required>\r\n\r\n            <label for=\"psw\"><b>Password</b></label>\r\n            <input type=\"password\" placeholder=\"Enter Password\" name=\"psw\" required>\r\n\r\n            <button type=\"submit\">Login</button>\r\n            <label>\r\n                <input type=\"checkbox\" checked=\"checked\" name=\"remember\"> Remember me\r\n            </label>\r\n        </div>\r\n\r\n        <div class=\"container\" style=\"background-color:#f1f1f1\">\r\n            <button type=\"button\" class=\"cancelbtn\">Cancel</button>\r\n            <span class=\"psw\">Forgot <a href=\"#\">password?</a></span>\r\n        </div>\r\n    </form>\r\n</body>\r\n\r\n</html>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591