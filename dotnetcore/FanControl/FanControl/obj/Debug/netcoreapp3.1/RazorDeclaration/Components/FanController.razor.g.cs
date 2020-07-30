#pragma checksum "/home/pi/source/smartiot/dotnetcore/FanControl/FanControl/Components/FanController.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2312fbe7fa2b093360d8fca457ae12efe8127e49"
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
#line 1 "/home/pi/source/smartiot/dotnetcore/FanControl/FanControl/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/pi/source/smartiot/dotnetcore/FanControl/FanControl/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/pi/source/smartiot/dotnetcore/FanControl/FanControl/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/pi/source/smartiot/dotnetcore/FanControl/FanControl/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/pi/source/smartiot/dotnetcore/FanControl/FanControl/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/pi/source/smartiot/dotnetcore/FanControl/FanControl/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/pi/source/smartiot/dotnetcore/FanControl/FanControl/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/pi/source/smartiot/dotnetcore/FanControl/FanControl/_Imports.razor"
using FanControl;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/pi/source/smartiot/dotnetcore/FanControl/FanControl/_Imports.razor"
using FanControl.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/pi/source/smartiot/dotnetcore/FanControl/FanControl/_Imports.razor"
using FanControl.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/pi/source/smartiot/dotnetcore/FanControl/FanControl/Components/FanController.razor"
using FanControl.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/pi/source/smartiot/dotnetcore/FanControl/FanControl/Components/FanController.razor"
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
#line 44 "/home/pi/source/smartiot/dotnetcore/FanControl/FanControl/Components/FanController.razor"
       

    [Parameter]
    public string FanUrl { get; set; } = "";

    [Parameter]
    public int MotorOffset { get; set; } = 0;

    [Parameter]
    public int FanFactor { get; set; } = 0;

    [Parameter]
    public int FanCount { get; set; } = 0;

    public bool busy { get; set; } = false;

    private Fan fan;

    private void makeBusy()
    {
        busy = true;
    }

    protected override void OnInitialized()
    {
        Console.WriteLine("Fan URL is: " + this.FanUrl);

        fan = Svc.GetFanByUrl(this.FanUrl);
        fan.MotorOneBrake = this.MotorOffset;
        fan.FanFactor = this.FanFactor;
        fan.FanCount = this.FanCount;
    }


    public async Task Increment()
    {
        busy = true;
        await Task.Delay(1);  

        Svc.Increment(this.FanUrl);

        await Task.Delay(1);  
        busy = false;
    }

    public async Task Decrement()
    {
        busy = true;
        await Task.Delay(1);  
        
        Svc.Decrement(this.FanUrl);
        
        busy = false;
        await Task.Delay(1);  
    }

    public async Task SetTo(int newSpeed)
    {
        busy = true;
        await Task.Delay(1);  

        Svc.SetToSpeed(this.FanUrl, newSpeed);

        busy = false;
        await Task.Delay(1);  

        
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FanService Svc { get; set; }
    }
}
#pragma warning restore 1591
