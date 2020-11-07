#pragma checksum "C:\programacion3\tarea7\Components\Mapa.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c491f31d2a1c143b347612735b2f136a887fd17"
// <auto-generated/>
#pragma warning disable 1591
namespace tarea7.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\programacion3\tarea7\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\programacion3\tarea7\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\programacion3\tarea7\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\programacion3\tarea7\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\programacion3\tarea7\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\programacion3\tarea7\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\programacion3\tarea7\_Imports.razor"
using tarea7;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\programacion3\tarea7\_Imports.razor"
using tarea7.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\programacion3\tarea7\Components\Mapa.razor"
using System.Drawing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\programacion3\tarea7\Components\Mapa.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\programacion3\tarea7\Components\Mapa.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\programacion3\tarea7\Components\Mapa.razor"
using Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\programacion3\tarea7\Components\Mapa.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\programacion3\tarea7\Components\Mapa.razor"
using System.Text.Json.Serialization;

#line default
#line hidden
#nullable disable
    public partial class Mapa : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
    #vista-mapa, .map {
    height: 90%;
    width: 90%;
    position: absolute !important;
  }
  .map-Container {
      min-width: 80vmin;
      width: 100%;
      min-height: 90vmin;
      height: 100%;
      position: relative;
      display: flex;
      justify-content: center;
      margin-top: 15px;
  }
</style>

");
            __builder.AddMarkupContent(1, "<div class=\"map-Container\">\r\n    <div class=\"map\" id=\"vista-mapa\"></div>\r\n</div>\r\n");
            __builder.AddMarkupContent(2, @"<div id=""modalDataEvent"" class=""modal fade"" tabindex=""-1"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <div id=""modalContentMap""></div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\programacion3\tarea7\Components\Mapa.razor"
       
    [Parameter]
    public string TID {get; set;}

    List<Coordinate> coordinates;
    List<Treasure> treasures;
   
    protected override async Task OnAfterRenderAsync(bool firstRender){
        if (firstRender){
            if(TID != null)
            await Load();
        }
    }

    private async Task Load(){
        if(TID != null && TID != ""){
            coordinates = await TS.GetAllCoordinate(Guid.Parse(TID));
            treasures = await TS.GetAllTreasure(Guid.Parse(TID));
            string json = JsonSerializer.Serialize(coordinates.ToArray());
            string TJson = JsonSerializer.Serialize(treasures.ToArray());
            await runtime.InvokeVoidAsync("initMap", json, 8, TJson);
        }else{
            await runtime.InvokeVoidAsync("initMap");
        }

    }
 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime runtime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITesoroService TS { get; set; }
    }
}
#pragma warning restore 1591
