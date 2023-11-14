using Microsoft.AspNetCore.Components;

namespace DemoBlazor.Pages.Demo2
{
    public partial class Demo2Bis
    {
        [Parameter]
        public int ValueFromParent { get; set; }
        [Parameter]
        public EventCallback<int> MonSuperEvent { get; set; }
        public  int Value { get; set; }
        void SendToPapa() {
            MonSuperEvent.InvokeAsync(Value);
        }
    }
}
