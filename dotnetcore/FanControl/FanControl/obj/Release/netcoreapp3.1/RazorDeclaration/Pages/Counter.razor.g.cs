#pragma checksum "E:\source\smartiot\dotnetcore\FanControl\FanControl\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "455327d4897ed28ea7da59dd561c68b302aa5769"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FanControl.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\source\smartiot\dotnetcore\FanControl\FanControl\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\source\smartiot\dotnetcore\FanControl\FanControl\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\source\smartiot\dotnetcore\FanControl\FanControl\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\source\smartiot\dotnetcore\FanControl\FanControl\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\source\smartiot\dotnetcore\FanControl\FanControl\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\source\smartiot\dotnetcore\FanControl\FanControl\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\source\smartiot\dotnetcore\FanControl\FanControl\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\source\smartiot\dotnetcore\FanControl\FanControl\_Imports.razor"
using FanControl;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\source\smartiot\dotnetcore\FanControl\FanControl\_Imports.razor"
using FanControl.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\source\smartiot\dotnetcore\FanControl\FanControl\_Imports.razor"
using FanControl.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\source\smartiot\dotnetcore\FanControl\FanControl\Pages\Counter.razor"
using FanControl.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "E:\source\smartiot\dotnetcore\FanControl\FanControl\Pages\Counter.razor"
       
    private int currentCount = 0;

    private void IncrementCount()
    {
        currentCount++;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CounterService Svc { get; set; }
    }
}
#pragma warning restore 1591
