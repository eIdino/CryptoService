#pragma checksum "C:\Users\Elpeeni\Downloads\CryptoService\CryptoService\Pages\PriceHistory.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f8d4f5a4442f7684cfc49b399d52c4fa32bc8ca"
// <auto-generated/>
#pragma warning disable 1591
namespace CryptoService.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Elpeeni\Downloads\CryptoService\CryptoService\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Elpeeni\Downloads\CryptoService\CryptoService\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Elpeeni\Downloads\CryptoService\CryptoService\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Elpeeni\Downloads\CryptoService\CryptoService\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Elpeeni\Downloads\CryptoService\CryptoService\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Elpeeni\Downloads\CryptoService\CryptoService\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Elpeeni\Downloads\CryptoService\CryptoService\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Elpeeni\Downloads\CryptoService\CryptoService\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Elpeeni\Downloads\CryptoService\CryptoService\_Imports.razor"
using CryptoService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Elpeeni\Downloads\CryptoService\CryptoService\_Imports.razor"
using CryptoService.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Elpeeni\Downloads\CryptoService\CryptoService\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/pricehistory")]
    public partial class PriceHistory : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Crypto Information Service</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>See the price history and latest price of currencies and pairs. Crypto to Crypto support for BTC - Bitcoin, LTC - Litecoin, and ETH - Ethereum</p>");
#nullable restore
#line 8 "C:\Users\Elpeeni\Downloads\CryptoService\CryptoService\Pages\PriceHistory.razor"
 if (history == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading price history...</em></p>");
#nullable restore
#line 11 "C:\Users\Elpeeni\Downloads\CryptoService\CryptoService\Pages\PriceHistory.razor"
}
// If the list is not empty
else
{   
    // Search form with validation and search button

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(3);
            __builder.AddAttribute(4, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 16 "C:\Users\Elpeeni\Downloads\CryptoService\CryptoService\Pages\PriceHistory.razor"
                      Model

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.OpenElement(10, "div");
                __builder2.AddMarkupContent(11, "<label for=\"PairName\">Pair Name</label>\r\n            ");
                __builder2.OpenElement(12, "input");
                __builder2.AddAttribute(13, "id", "PairName");
                __builder2.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "C:\Users\Elpeeni\Downloads\CryptoService\CryptoService\Pages\PriceHistory.razor"
                                              Model.PairName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Model.PairName = __value, Model.PairName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n            ");
                __Blazor.CryptoService.Pages.PriceHistory.TypeInference.CreateValidationMessage_0(__builder2, 17, 18, 
#nullable restore
#line 22 "C:\Users\Elpeeni\Downloads\CryptoService\CryptoService\Pages\PriceHistory.razor"
                                    () => Model.PairName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(19, "\r\n            <p></p>\r\n            ");
                __builder2.AddMarkupContent(20, "<label for=\"Hours\">Hours</label>\r\n            ");
                __builder2.OpenElement(21, "input");
                __builder2.AddAttribute(22, "id", "Hours");
                __builder2.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "C:\Users\Elpeeni\Downloads\CryptoService\CryptoService\Pages\PriceHistory.razor"
                                           Model.Hours

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Model.Hours = __value, Model.Hours));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n            ");
                __Blazor.CryptoService.Pages.PriceHistory.TypeInference.CreateValidationMessage_1(__builder2, 26, 27, 
#nullable restore
#line 26 "C:\Users\Elpeeni\Downloads\CryptoService\CryptoService\Pages\PriceHistory.razor"
                                    () => Model.Hours

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(28, "\r\n            <p></p>\r\n            ");
                __builder2.AddMarkupContent(29, "<label for=\"DataPoints\">Data Points</label>\r\n            ");
                __builder2.OpenElement(30, "input");
                __builder2.AddAttribute(31, "id", "DataPoints");
                __builder2.AddAttribute(32, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "C:\Users\Elpeeni\Downloads\CryptoService\CryptoService\Pages\PriceHistory.razor"
                                                Model.DataPoints

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Model.DataPoints = __value, Model.DataPoints));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n            ");
                __Blazor.CryptoService.Pages.PriceHistory.TypeInference.CreateValidationMessage_2(__builder2, 35, 36, 
#nullable restore
#line 30 "C:\Users\Elpeeni\Downloads\CryptoService\CryptoService\Pages\PriceHistory.razor"
                                    () => Model.DataPoints

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(37, "\r\n            <p></p>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n        ");
                __builder2.OpenElement(39, "div");
                __builder2.OpenElement(40, "button");
                __builder2.AddAttribute(41, "class", "btn btn-primary");
                __builder2.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\Elpeeni\Downloads\CryptoService\CryptoService\Pages\PriceHistory.razor"
                                                      Lookup

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(43, "Search");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n        <br>");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 38 "C:\Users\Elpeeni\Downloads\CryptoService\CryptoService\Pages\PriceHistory.razor"
    
    // Displaying data in a table

#line default
#line hidden
#nullable disable
            __builder.OpenElement(45, "table");
            __builder.AddAttribute(46, "class", "table");
            __builder.AddMarkupContent(47, @"<thead><tr><th>Time of Price Creation</th>
                <th>Price Creation Unix Timestamp</th>
                <th>Price Expiration Unix Timestamp</th>
                <th>Asking Price</th>
                <th>Bidding Price</th>
                <th>Market Name</th>
                <th>Market Code</th>
                <th>Rate</th>
                <th>ID</th>
                <th>Historic Prive Variance</th>
                <th>Historic Prive Age</th></tr></thead>
        ");
            __builder.OpenElement(48, "tbody");
#nullable restore
#line 57 "C:\Users\Elpeeni\Downloads\CryptoService\CryptoService\Pages\PriceHistory.razor"
             foreach (var item in history)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(49, "tr");
            __builder.OpenElement(50, "td");
            __builder.AddContent(51, 
#nullable restore
#line 60 "C:\Users\Elpeeni\Downloads\CryptoService\CryptoService\Pages\PriceHistory.razor"
                         item.created_on

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                    ");
            __builder.OpenElement(53, "td");
            __builder.AddContent(54, 
#nullable restore
#line 61 "C:\Users\Elpeeni\Downloads\CryptoService\CryptoService\Pages\PriceHistory.razor"
                         item.unix_time

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                    ");
            __builder.OpenElement(56, "td");
            __builder.AddContent(57, 
#nullable restore
#line 62 "C:\Users\Elpeeni\Downloads\CryptoService\CryptoService\Pages\PriceHistory.razor"
                         item.expiration_time_unix

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                    ");
            __builder.OpenElement(59, "td");
            __builder.AddContent(60, 
#nullable restore
#line 63 "C:\Users\Elpeeni\Downloads\CryptoService\CryptoService\Pages\PriceHistory.razor"
                         item.ticker.ask

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                    ");
            __builder.OpenElement(62, "td");
            __builder.AddContent(63, 
#nullable restore
#line 64 "C:\Users\Elpeeni\Downloads\CryptoService\CryptoService\Pages\PriceHistory.razor"
                         item.ticker.bid

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                    ");
            __builder.OpenElement(65, "td");
            __builder.AddContent(66, 
#nullable restore
#line 65 "C:\Users\Elpeeni\Downloads\CryptoService\CryptoService\Pages\PriceHistory.razor"
                         item.market.name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                    ");
            __builder.OpenElement(68, "td");
            __builder.AddContent(69, 
#nullable restore
#line 66 "C:\Users\Elpeeni\Downloads\CryptoService\CryptoService\Pages\PriceHistory.razor"
                         item.market.code

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                    ");
            __builder.OpenElement(71, "td");
            __builder.AddContent(72, 
#nullable restore
#line 67 "C:\Users\Elpeeni\Downloads\CryptoService\CryptoService\Pages\PriceHistory.razor"
                         item.rate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                    ");
            __builder.OpenElement(74, "td");
            __builder.AddContent(75, 
#nullable restore
#line 68 "C:\Users\Elpeeni\Downloads\CryptoService\CryptoService\Pages\PriceHistory.razor"
                         item.rate_id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                    ");
            __builder.OpenElement(77, "td");
            __builder.AddContent(78, 
#nullable restore
#line 69 "C:\Users\Elpeeni\Downloads\CryptoService\CryptoService\Pages\PriceHistory.razor"
                         item.allowed_historic_price_variance

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                    ");
            __builder.OpenElement(80, "td");
            __builder.AddContent(81, 
#nullable restore
#line 70 "C:\Users\Elpeeni\Downloads\CryptoService\CryptoService\Pages\PriceHistory.razor"
                         item.allowed_historic_price_age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 72 "C:\Users\Elpeeni\Downloads\CryptoService\CryptoService\Pages\PriceHistory.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 75 "C:\Users\Elpeeni\Downloads\CryptoService\CryptoService\Pages\PriceHistory.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 77 "C:\Users\Elpeeni\Downloads\CryptoService\CryptoService\Pages\PriceHistory.razor"
       

    // New Model Object for user inputs
    Model Model = new Model();

    private Root[] history;

    // Get Data
    protected override async Task OnInitializedAsync()
    {
        history = await Http.GetFromJsonAsync<Root[]>($"https://api.n.exchange/en/api/v1/price/BTCLTC/history/?hours=0.1&data_points=3&market_code=nex");
    }

    // Get Data by User
    protected async Task SecondList()
    {
        history = await Http.GetFromJsonAsync<Root[]>($"https://api.n.exchange/en/api/v1/price/{Model.PairName}/history/?hours={Model.Hours}&data_points={Model.DataPoints}&market_code=nex");
    }

    // Search function
    public void Lookup()
    {
        SecondList();
        StateHasChanged();
    }

    // Other class
    public class Ticker
    {
        public string ask { get; set; }
        public string bid { get; set; }
    }

    // Other class
    public class Market
    {
        public string name { get; set; }
        public string code { get; set; }
    }

    // Main class
    public class Root
    {
        public string detail { get; set; }
        public DateTime created_on { get; set; }
        public string unix_time { get; set; }
        public string expiration_time_unix { get; set; }
        public Ticker ticker { get; set; }
        public Market market { get; set; }
        public string rate { get; set; }
        public string rate_id { get; set; }
        public bool allowed_historic_price_variance { get; set; }
        public bool allowed_historic_price_age { get; set; }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.CryptoService.Pages.PriceHistory
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591