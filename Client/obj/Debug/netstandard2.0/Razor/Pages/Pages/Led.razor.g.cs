#pragma checksum "/home/pi/src/Blazor.Pi/Client/Pages/Pages/Led.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7c499c9694820a6e1c3d00a3260b6594aa54d46"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor.Pi.Client.Pages.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "/home/pi/src/Blazor.Pi/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "/home/pi/src/Blazor.Pi/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "/home/pi/src/Blazor.Pi/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "/home/pi/src/Blazor.Pi/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "/home/pi/src/Blazor.Pi/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "/home/pi/src/Blazor.Pi/Client/_Imports.razor"
using Blazor.Pi.Client;

#line default
#line hidden
#line 7 "/home/pi/src/Blazor.Pi/Client/_Imports.razor"
using Blazor.Pi.Client.Shared;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/led")]
    public partial class Led : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Led Toggle</h1>\n\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Current On: ");
            __builder.AddContent(3, 
#line 6 "/home/pi/src/Blazor.Pi/Client/Pages/Pages/Led.razor"
                toggle

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\n");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "btn btn-primary");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 7 "/home/pi/src/Blazor.Pi/Client/Pages/Pages/Led.razor"
                                          ToggleLed

#line default
#line hidden
            ));
            __builder.AddContent(8, "Toggle");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 9 "/home/pi/src/Blazor.Pi/Client/Pages/Pages/Led.razor"
       
    bool toggle = false;

    async Task ToggleLed()
    {
        toggle = !toggle;
        await Http.SendJsonAsync(HttpMethod.Post, "LED", toggle);
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
