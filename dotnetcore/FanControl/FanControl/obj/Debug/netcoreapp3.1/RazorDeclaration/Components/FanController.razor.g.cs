#pragma checksum "C:\Users\Lutz\source\repos\FanControl\FanControl\Components\FanController.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf720f236f5b7a1eec80018cf40b5b8ea90294b9"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FanControl.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Lutz\source\repos\FanControl\FanControl\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lutz\source\repos\FanControl\FanControl\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lutz\source\repos\FanControl\FanControl\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lutz\source\repos\FanControl\FanControl\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Lutz\source\repos\FanControl\FanControl\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Lutz\source\repos\FanControl\FanControl\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Lutz\source\repos\FanControl\FanControl\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Lutz\source\repos\FanControl\FanControl\_Imports.razor"
using FanControl;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Lutz\source\repos\FanControl\FanControl\_Imports.razor"
using FanControl.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Lutz\source\repos\FanControl\FanControl\_Imports.razor"
using FanControl.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lutz\source\repos\FanControl\FanControl\Components\FanController.razor"
using FanControl.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lutz\source\repos\FanControl\FanControl\Components\FanController.razor"
using FanControl.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fanController")]
    public partial class FanController : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Users\Lutz\source\repos\FanControl\FanControl\Components\FanController.razor"
       

    [Parameter]
    public string FanUrl { get; set; } = "";

    [Parameter]
    public int MotorOffset { get; set; } = 0;

    [Parameter]
    public int FanFactor { get; set; } = 0;

    [Parameter]
    public int FanCount { get; set; } = 0;


    private Fan fan;


    protected override void OnInitialized()
    {
        Console.WriteLine("Fan URL is: " + this.FanUrl);

        fan = Svc.GetFanByUrl(this.FanUrl);
        fan.MotorOneBrake = this.MotorOffset;
        fan.FanFactor = this.FanFactor;
        fan.FanCount = this.FanCount;
    }


    public void Increment()
    {
        Svc.Increment(this.FanUrl);
    }

    public void Decrement()
    {
        Svc.Decrement(this.FanUrl);
    }

    public void SetTo(int newSpeed)
    {
        Svc.SetToSpeed(this.FanUrl, newSpeed);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FanService Svc { get; set; }
    }
}
#pragma warning restore 1591