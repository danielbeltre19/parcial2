#pragma checksum "c:\programacion3\tarea7\Components\ModalD.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "607f3c94df73f1f32c0825f1d4ee6610cea6b46d"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace tarea7.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\programacion3\tarea7\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\programacion3\tarea7\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\programacion3\tarea7\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\programacion3\tarea7\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\programacion3\tarea7\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\programacion3\tarea7\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\programacion3\tarea7\_Imports.razor"
using tarea7;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\programacion3\tarea7\_Imports.razor"
using tarea7.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "c:\programacion3\tarea7\Components\ModalD.razor"
using System.Drawing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\programacion3\tarea7\Components\ModalD.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\programacion3\tarea7\Components\ModalD.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\programacion3\tarea7\Components\ModalD.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\programacion3\tarea7\Components\ModalD.razor"
using System.Text.Json.Serialization;

#line default
#line hidden
#nullable disable
    public partial class ModalD : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 74 "c:\programacion3\tarea7\Components\ModalD.razor"
       
    [Parameter]
    public string Id {get; set;}
    [Parameter]
    public Treasure ts {get; set;}



    private bool details = true;
    private bool maps = false;
    private bool images = false;

    private void viewDetails(){
        details =true;
        maps = false;
        images = false;
    }
    private void viewMaps(){
        details =false;
        maps = true;
        images = false;
    }
    private void viewImages(){
        details =false;
        maps = false;
        images = true;
    }
   



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime runtime { get; set; }
    }
}
#pragma warning restore 1591
