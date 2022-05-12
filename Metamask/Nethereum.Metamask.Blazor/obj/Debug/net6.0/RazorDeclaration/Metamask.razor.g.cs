// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Nethereum.Metamask.Blazor
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Metamask\Nethereum.Metamask.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Metamask\Nethereum.Metamask.Blazor\Metamask.razor"
using Nethereum.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Metamask\Nethereum.Metamask.Blazor\Metamask.razor"
using NftContractHandler;

#line default
#line hidden
#nullable disable
    public partial class Metamask : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "D:\Metamask\Nethereum.Metamask.Blazor\Metamask.razor"
       

    bool MetamaskAvailable { get; set; }
    string SelectedAccount { get; set; }
    protected string AuthenticatedAccount { get; set; }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            _metamaskHostProvider.SelectedAccountChanged += MetamaskHostProvider_SelectedAccountChanged;
            MetamaskAvailable = await _metamaskHostProvider.CheckProviderAvailabilityAsync();

            if (_testExample.ConnectButtonClick)
                await EnableEthereumAsync();
            
            StateHasChanged();
        }
    }

    private async Task MetamaskHostProvider_SelectedAccountChanged(string account)
    {
        SelectedAccount = account;
        this.StateHasChanged();
    }

    protected async Task EnableEthereumAsync()
    {
        SelectedAccount = await _metamaskHostProvider.EnableProviderAsync();
        _testExample.Web3 = await _metamaskHostProvider.GetWeb3Async();
        _testExample.CurrentUserAddress = SelectedAccount;
        _testExample.ConnectButtonClick = true;
    }
    
    

   

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TestExample _testExample { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NethereumSiweAuthenticatorService _nethereumSiweAuthenticatorService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IEthereumHostProvider _metamaskHostProvider { get; set; }
    }
}
#pragma warning restore 1591
