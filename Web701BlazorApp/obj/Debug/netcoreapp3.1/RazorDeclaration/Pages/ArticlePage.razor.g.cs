#pragma checksum "E:\@SkyDrive\SkyDrive\@backup\@nmit\WEB701\WEB701PRJ\Web701BlazorApp\Pages\ArticlePage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12705b028cb82646e513526ed92736f71585bcb8"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Web701BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\@SkyDrive\SkyDrive\@backup\@nmit\WEB701\WEB701PRJ\Web701BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\@SkyDrive\SkyDrive\@backup\@nmit\WEB701\WEB701PRJ\Web701BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\@SkyDrive\SkyDrive\@backup\@nmit\WEB701\WEB701PRJ\Web701BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\@SkyDrive\SkyDrive\@backup\@nmit\WEB701\WEB701PRJ\Web701BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\@SkyDrive\SkyDrive\@backup\@nmit\WEB701\WEB701PRJ\Web701BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\@SkyDrive\SkyDrive\@backup\@nmit\WEB701\WEB701PRJ\Web701BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\@SkyDrive\SkyDrive\@backup\@nmit\WEB701\WEB701PRJ\Web701BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\@SkyDrive\SkyDrive\@backup\@nmit\WEB701\WEB701PRJ\Web701BlazorApp\_Imports.razor"
using Web701BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\@SkyDrive\SkyDrive\@backup\@nmit\WEB701\WEB701PRJ\Web701BlazorApp\_Imports.razor"
using Web701BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\@SkyDrive\SkyDrive\@backup\@nmit\WEB701\WEB701PRJ\Web701BlazorApp\Pages\ArticlePage.razor"
using Web701BlazorApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\@SkyDrive\SkyDrive\@backup\@nmit\WEB701\WEB701PRJ\Web701BlazorApp\Pages\ArticlePage.razor"
using WEB701GRPC.Protos;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/article/{id}")]
    public partial class ArticlePage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "E:\@SkyDrive\SkyDrive\@backup\@nmit\WEB701\WEB701PRJ\Web701BlazorApp\Pages\ArticlePage.razor"
       
    [Parameter]
    public string id { get; set; }
    private WEB701GRPC.Protos.Article ArticleItem { get; set; } = new Article();

    protected override async void OnInitialized()
    {
        try
        {
            ArticleItem = (await gRPCClient.GetArticleList()).Find(x=>x.Id==int.Parse(id));
        }
        catch (Exception e)
        {
            Console.WriteLine(e.GetBaseException().Message);
        }
        this.StateHasChanged();
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
