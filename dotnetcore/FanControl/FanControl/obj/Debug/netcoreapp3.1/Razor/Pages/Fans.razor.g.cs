#pragma checksum "C:\source\smartiot\smartiot\dotnetcore\FanControl\FanControl\Pages\Fans.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94dda926af130d5761f79a9f06bb7f2fdc6f7ddd"
// <auto-generated/>
#pragma warning disable 1591
namespace FanControl.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\source\smartiot\smartiot\dotnetcore\FanControl\FanControl\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\source\smartiot\smartiot\dotnetcore\FanControl\FanControl\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\source\smartiot\smartiot\dotnetcore\FanControl\FanControl\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\source\smartiot\smartiot\dotnetcore\FanControl\FanControl\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\source\smartiot\smartiot\dotnetcore\FanControl\FanControl\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\source\smartiot\smartiot\dotnetcore\FanControl\FanControl\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\source\smartiot\smartiot\dotnetcore\FanControl\FanControl\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\source\smartiot\smartiot\dotnetcore\FanControl\FanControl\_Imports.razor"
using FanControl;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\source\smartiot\smartiot\dotnetcore\FanControl\FanControl\_Imports.razor"
using FanControl.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\source\smartiot\smartiot\dotnetcore\FanControl\FanControl\Pages\Fans.razor"
using FanControl.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fans")]
    public partial class Fans : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<FanControl.Components.FanController>(0);
            __builder.AddAttribute(1, "FanName", "Allgemein");
            __builder.AddAttribute(2, "FanUrl", "http://192.168.178.12");
            __builder.AddAttribute(3, "MotorOffset", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 4 "C:\source\smartiot\smartiot\dotnetcore\FanControl\FanControl\Pages\Fans.razor"
                                                                               0

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "FanFactor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 4 "C:\source\smartiot\smartiot\dotnetcore\FanControl\FanControl\Pages\Fans.razor"
                                                                                             10

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "FanCount", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 4 "C:\source\smartiot\smartiot\dotnetcore\FanControl\FanControl\Pages\Fans.razor"
                                                                                                           4

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\n\n");
            __builder.OpenComponent<FanControl.Components.FanController>(7);
            __builder.AddAttribute(8, "FanName", "Büro");
            __builder.AddAttribute(9, "FanUrl", "http://192.168.178.20");
            __builder.AddAttribute(10, "MotorOffset", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 6 "C:\source\smartiot\smartiot\dotnetcore\FanControl\FanControl\Pages\Fans.razor"
                                                                           7

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "FanFactor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 6 "C:\source\smartiot\smartiot\dotnetcore\FanControl\FanControl\Pages\Fans.razor"
                                                                                         5

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "FanCount", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 6 "C:\source\smartiot\smartiot\dotnetcore\FanControl\FanControl\Pages\Fans.razor"
                                                                                                      2

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591