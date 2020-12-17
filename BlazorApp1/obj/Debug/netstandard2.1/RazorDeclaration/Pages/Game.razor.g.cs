// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Copify.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/graham/Projects/BlazorApp1/BlazorApp1/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/graham/Projects/BlazorApp1/BlazorApp1/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/graham/Projects/BlazorApp1/BlazorApp1/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/graham/Projects/BlazorApp1/BlazorApp1/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/graham/Projects/BlazorApp1/BlazorApp1/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/graham/Projects/BlazorApp1/BlazorApp1/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/graham/Projects/BlazorApp1/BlazorApp1/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/graham/Projects/BlazorApp1/BlazorApp1/_Imports.razor"
using Copify;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/graham/Projects/BlazorApp1/BlazorApp1/_Imports.razor"
using Copify.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/game")]
    public partial class Game : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 122 "/Users/graham/Projects/BlazorApp1/BlazorApp1/Pages/Game.razor"
       
    private String artist1 = "Led Zeppelin";
    private String artist2 = "The Beatles";
    private bool found;
    private String winner = "";

    private Root data1;
    private Root data2;


    private async Task GetArtistAsync()
    {
        try
        {
            string url1 = "http://ws.audioscrobbler.com/2.0/?method=artist.getinfo&artist=" + artist1 + "&api_key=e53ad041fac5d3189f2e8dffe9b6978a&format=json";
            string url2 = "http://ws.audioscrobbler.com/2.0/?method=artist.getinfo&artist=" + artist2 + "&api_key=e53ad041fac5d3189f2e8dffe9b6978a&format=json";
            data1 = await Http.GetFromJsonAsync<Root>(url1);
            data2 = await Http.GetFromJsonAsync<Root>(url2);
            found = true;
            int x = Int32.Parse(data1.artist.stats.playcount);
            int y = Int32.Parse(data2.artist.stats.playcount);

            if (x > y)
            {
                winner = artist1;
            }
            else
            {
                winner = artist2;
            }

        }
        catch (Exception e)
        {
            found = false;
        }
    }

    //lifecycle method

    protected override async Task OnInitializedAsync()
    {
        await GetArtistAsync();
    }

    //lookup
    public async void Lookup()
    {
        await GetArtistAsync();
        StateHasChanged();
    }


    public class Image
    {
        public string text { get; set; }
        public string size { get; set; }
    }

    public class Stats
    {
        public string listeners { get; set; }
        public string playcount { get; set; }
    }

    public class Similar
    {
        public IList<Artist> artist { get; set; }
    }

    public class Tag
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Tags
    {
        public IList<Tag> tag { get; set; }
    }

    public class Link
    {
        public string text { get; set; }
        public string rel { get; set; }
        public string href { get; set; }
    }

    public class Links
    {
        public Link link { get; set; }
    }

    public class Bio
    {
        public Links links { get; set; }
        public string published { get; set; }
        public string summary { get; set; }
        public string content { get; set; }
    }

    public class Artist
    {
        public string name { get; set; }
        public string mbid { get; set; }
        public string url { get; set; }
        public IList<Image> image { get; set; }
        public string streamable { get; set; }
        public string ontour { get; set; }
        public Stats stats { get; set; }
        public Similar similar { get; set; }
        public Tags tags { get; set; }
        public Bio bio { get; set; }
    }

    public class Root
    {
        public Artist artist { get; set; }
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
