#pragma checksum "/Users/graham/Projects/BlazorApp1/BlazorApp1/Pages/SearchArtist.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76565efe6eab0fbc59621d83ae89d183c4101071"
// <auto-generated/>
#pragma warning disable 1591
namespace Copify.Pages
{
    #line hidden
    using System;
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
#nullable restore
#line 3 "/Users/graham/Projects/BlazorApp1/BlazorApp1/Pages/SearchArtist.razor"
using System.Runtime.Serialization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/graham/Projects/BlazorApp1/BlazorApp1/Pages/SearchArtist.razor"
using System.Collections;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/graham/Projects/BlazorApp1/BlazorApp1/Pages/SearchArtist.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/graham/Projects/BlazorApp1/BlazorApp1/Pages/SearchArtist.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/searchartist")]
    public partial class SearchArtist : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 10 "/Users/graham/Projects/BlazorApp1/BlazorApp1/Pages/SearchArtist.razor"
 if (data == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p><em>Loading...</em></p>");
#nullable restore
#line 13 "/Users/graham/Projects/BlazorApp1/BlazorApp1/Pages/SearchArtist.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.OpenElement(2, "input");
            __builder.AddAttribute(3, "placeholder", "Search Artist");
            __builder.AddAttribute(4, "id", "artist");
            __builder.AddAttribute(5, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "/Users/graham/Projects/BlazorApp1/BlazorApp1/Pages/SearchArtist.razor"
                                                              artist

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => artist = __value, artist));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\n        ");
            __builder.OpenElement(8, "button");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "/Users/graham/Projects/BlazorApp1/BlazorApp1/Pages/SearchArtist.razor"
                          Lookup

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(10, "<span class=\"oi oi-magnifying-glass\"></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\n        <p></p>");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n    <br>");
#nullable restore
#line 25 "/Users/graham/Projects/BlazorApp1/BlazorApp1/Pages/SearchArtist.razor"
     if (found)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "h1");
            __builder.AddContent(14, 
#nullable restore
#line 27 "/Users/graham/Projects/BlazorApp1/BlazorApp1/Pages/SearchArtist.razor"
               data.artist.name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n        <br>\n        <br>\n        ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "container");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "row");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "col-sm");
            __builder.OpenElement(22, "p");
            __builder.AddContent(23, 
#nullable restore
#line 34 "/Users/graham/Projects/BlazorApp1/BlazorApp1/Pages/SearchArtist.razor"
                         data.artist.bio.summary

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n                ");
            __builder.AddMarkupContent(25, "<div class=\"col-sm\"><img src=\"https://blueskyletters.com/uploads/pien-muller-Fh-Q-xfdh_o-unsplash.jpg\" alt=\"Image\" asp-append-version=\"true\" width=\"400px\"></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n            <br>\n            <br>\n\n            ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "row");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "col-sm-5");
            __builder.AddMarkupContent(31, "<h2>Releases</h2> ");
            __builder.OpenElement(32, "button");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "/Users/graham/Projects/BlazorApp1/BlazorApp1/Pages/SearchArtist.razor"
                                                        sort

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(34, "<span class=\"oi oi-sort-ascending\"></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\n                    ");
            __builder.OpenElement(36, "table");
            __builder.AddAttribute(37, "class", "table");
            __builder.OpenElement(38, "tbody");
#nullable restore
#line 50 "/Users/graham/Projects/BlazorApp1/BlazorApp1/Pages/SearchArtist.razor"
                             foreach (Object obj in artistAlbums)
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(39, "tr");
            __builder.AddMarkupContent(40, "<th scope=\"row\"></th>\n                                    ");
            __builder.OpenElement(41, "td");
            __builder.AddContent(42, 
#nullable restore
#line 54 "/Users/graham/Projects/BlazorApp1/BlazorApp1/Pages/SearchArtist.razor"
                                         obj

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 57 "/Users/graham/Projects/BlazorApp1/BlazorApp1/Pages/SearchArtist.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\n                <div class=\"col-sm-1\"></div>\n                ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "col-sm-6");
            __builder.AddMarkupContent(46, "<h2>Similar Artists</h2>\n\n                    ");
            __builder.OpenElement(47, "table");
            __builder.AddAttribute(48, "class", "table");
            __builder.OpenElement(49, "tbody");
#nullable restore
#line 71 "/Users/graham/Projects/BlazorApp1/BlazorApp1/Pages/SearchArtist.razor"
                             for (int i = 0; i < noSimilarArtists; i++)
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(50, "tr");
#nullable restore
#line 74 "/Users/graham/Projects/BlazorApp1/BlazorApp1/Pages/SearchArtist.razor"
                                      similarArtists.Add(@data.artist.similar.artist[i].name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "/Users/graham/Projects/BlazorApp1/BlazorApp1/Pages/SearchArtist.razor"
                                      int j = i;

#line default
#line hidden
#nullable disable
            __builder.OpenElement(51, "button");
            __builder.AddAttribute(52, "class", "similarArtistButton");
            __builder.AddAttribute(53, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 76 "/Users/graham/Projects/BlazorApp1/BlazorApp1/Pages/SearchArtist.razor"
                                                                                    e => goToSimilarArtist(j)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(54, 
#nullable restore
#line 76 "/Users/graham/Projects/BlazorApp1/BlazorApp1/Pages/SearchArtist.razor"
                                                                                                                  data.artist.similar.artist[i].name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 78 "/Users/graham/Projects/BlazorApp1/BlazorApp1/Pages/SearchArtist.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 86 "/Users/graham/Projects/BlazorApp1/BlazorApp1/Pages/SearchArtist.razor"

    }
    else
    {
        if (artist == "")
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(55, "<p><em>You must enter a value</em></p>");
#nullable restore
#line 93 "/Users/graham/Projects/BlazorApp1/BlazorApp1/Pages/SearchArtist.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(56, "<p><em>The artist you searched does not exist</em></p>");
#nullable restore
#line 97 "/Users/graham/Projects/BlazorApp1/BlazorApp1/Pages/SearchArtist.razor"
        }


    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "/Users/graham/Projects/BlazorApp1/BlazorApp1/Pages/SearchArtist.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 106 "/Users/graham/Projects/BlazorApp1/BlazorApp1/Pages/SearchArtist.razor"
       


    private String artist = "Led Zeppelin";
    private bool found;
    private Root data;
    private Application data1;
    List<string> similarArtists = new List<string>();

    private int noAlbums;
    ArrayList artistAlbums = new ArrayList();
    private int noSimilarArtists;



    private async Task GetArtistAsync()
    {
        try
        {
            string url = "http://ws.audioscrobbler.com/2.0/?method=artist.getinfo&artist=" + artist + "&api_key=e53ad041fac5d3189f2e8dffe9b6978a&format=json";
            data = await Http.GetFromJsonAsync<Root>(url);

            string url1 = "http://ws.audioscrobbler.com/2.0/?method=artist.gettopalbums&artist=" + artist + "&api_key=e53ad041fac5d3189f2e8dffe9b6978a&format=json";
            data1 = await Http.GetFromJsonAsync<Application>(url1);

            noAlbums = data1.topalbums.album.Count;
            noSimilarArtists = data.artist.similar.artist.Count;

            artistAlbums.Clear();
            similarArtists.Clear();

            

#line default
#line hidden
#nullable disable
#nullable restore
#line 137 "/Users/graham/Projects/BlazorApp1/BlazorApp1/Pages/SearchArtist.razor"
             for (int i = 0; i < noAlbums; i++)
            {
                if(data1.topalbums.album[i].name != "(null)")
                {
                    artistAlbums.Add(data1.topalbums.album[i].name);
                }


            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 145 "/Users/graham/Projects/BlazorApp1/BlazorApp1/Pages/SearchArtist.razor"
             

            found = true;
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

    //sort release list by alphabet
    public void sort()
    {
        artistAlbums.Sort();
    }

    //lookup
    public async void Lookup()
    {
        await GetArtistAsync();
        StateHasChanged();
    }

    public async void goToSimilarArtist(int loc)
    {
        artist = similarArtists[loc];
        await GetArtistAsync();
        StateHasChanged();
    }


    [DataContract]
    public class Image
    {
        [DataMember(Name = "#text")]
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

    [DataContract]
    public class Link
    {
        [DataMember(Name = "#text")]
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


    //albums

    public class Album
    {
        public string name { get; set; }
        public int playcount { get; set; }
        public string mbid { get; set; }
        public string url { get; set; }
        public Artist artist { get; set; }
        public IList<Image> image { get; set; }

    }
    public class Attr
    {
        public string artist { get; set; }
        public string page { get; set; }
        public string perPage { get; set; }
        public string totalPages { get; set; }
        public string total { get; set; }

    }
    public class Topalbums
    {
        public IList<Album> album { get; set; }
        public Attr @attr { get; set; }

    }
    public class Application
    {
        public Topalbums topalbums { get; set; }

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
