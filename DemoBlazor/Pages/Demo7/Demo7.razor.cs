using Microsoft.AspNetCore.SignalR.Client;

namespace DemoBlazor.Pages.Demo7
{
    public partial class Demo7
    {
        //Microsoft.AspNetCore.SignalR.Client

        HubConnection _hubConnection;

        public List<string> Messages { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Messages = new List<string>();

            _hubConnection = new HubConnectionBuilder()
                            .WithUrl("https://localhost:7130/chathub")
                            .Build();

            _hubConnection.On("ReceptionMessage", (string message) => 
            {
                Messages.Add(message);
                StateHasChanged();
            });

            await _hubConnection.StartAsync();
        }

        public string Message { get; set; }
        public async Task SendMessage()
        {
            await _hubConnection.SendAsync("SendMessage", Message);
        }

        public async Task JoinGroup()
        {
            await _hubConnection.SendAsync("JoinGroup", "monSuperGroupe");
            _hubConnection.On("ReceptionDuGroup", (string message) => {
                Messages.Add(message);
                StateHasChanged();
            });
        }
        public async Task SendToGroup()
        {
            await _hubConnection.SendAsync("SendToGroup", Message, "monSuperGroupe");
        }
    }
}
