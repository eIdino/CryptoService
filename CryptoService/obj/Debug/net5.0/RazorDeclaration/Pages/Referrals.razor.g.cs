// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Referrals : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "C:\Users\Elpeeni\Downloads\CryptoService\CryptoService\Pages\Referrals.razor"
       
    private Currency[] currencies;

    protected override async Task OnInitializedAsync()
    {
        currencies = await Http.GetFromJsonAsync<Currency[]>("https://api.n.exchange/en/api/v1/currency/");
    }

    public class Currency
    {
        public string code { get; set; }
        public string name { get; set; }
        public int? min_confirmations { get; set; }
        public bool is_crypto { get; set; }
        public string minimal_amount { get; set; }
        public string maximal_amount { get; set; }
        public bool is_base_of_enabled_pair { get; set; }
        public bool is_quote_of_enabled_pair { get; set; }
        public bool has_enabled_pairs { get; set; }
        public bool is_base_of_enabled_pair_for_test { get; set; }
        public bool is_quote_of_enabled_pair_for_test { get; set; }
        public bool has_enabled_pairs_for_test { get; set; }
        public string withdrawal_fee { get; set; }
        public string extra_id { get; set; }
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
