using Microsoft.AspNetCore.SignalR.Client;

namespace DemoBlazor.Pages.Demo7
{
    public partial class Demo7
    {
        //Microsoft.AspNetCore.SignalR.Client

        HubConnection _hubConnection;

        public List<Message> Messages { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Messages = new List<Message>();

            _hubConnection = new HubConnectionBuilder()
                            .WithUrl("https://localhost:7130/chathub")
                            .Build();

            _hubConnection.On("ReceptionMessage", (Message message) => 
            {
                Messages.Add(message);
                StateHasChanged();
            });

            await _hubConnection.StartAsync();
        }

        public string Sender { get; set; }
        public string Message { get; set; }
        public async Task SendMessage()
        {
            Message m = new Message {
                Sender = Sender,
                Content = Message,
                SendingDate = DateTime.Now,
                IsPrivate = false            
            };
            await _hubConnection.SendAsync("SendMessage", m);
            Message = "";
        }

        public async Task JoinGroup()
        {
            await _hubConnection.SendAsync("JoinGroup", "monSuperGroupe");

            _hubConnection.On("ReceptionDuGroup", (Message message) => {
                Messages.Add(message);
                StateHasChanged();
            });
        }
        public async Task SendToGroup()
        {
            Message m = new Message
            {
                Sender = Sender,
                Content = Message,
                SendingDate = DateTime.Now,
                IsPrivate = true
            };
            await _hubConnection.SendAsync("SendToGroup", m, "monSuperGroupe");
            Message = "";
        }
    }
}
