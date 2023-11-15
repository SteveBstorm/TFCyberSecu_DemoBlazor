using DemoBlazor.Pages.Exos.Exo2.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace DemoBlazor.Pages.Demo6
{
    public partial class Demo6
    {
        [Inject]
        public IJSRuntime _js { get; set; }

        public string MyValue { get; set; }

        async void SaveValue()
        {
            await _js.InvokeVoidAsync("localStorage.setItem", "valeur", MyValue);
            
        }
        async void ReadValue()
        {
            string s = await _js.InvokeAsync<string>("localStorage.getItem", "valeur");
            await Console.Out.WriteLineAsync(s);
        }

    }
}
