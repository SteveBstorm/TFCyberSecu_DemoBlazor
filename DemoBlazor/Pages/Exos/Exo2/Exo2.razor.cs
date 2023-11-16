using DemoBlazor.Pages.Exos.Exo2.Models;
using DemoBlazor.Pages.Exos.Exo2.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;

namespace DemoBlazor.Pages.Exos.Exo2
{
    public partial class Exo2
    {
        private HubConnection _hubConnection;
        public List<Article> ArticleList { get; set; }
        //public Article Selected { get; set; }

        public int SelectedId { get; set; }

        [Inject]
        public IArticleService ArticleService { get; set; }
        public Exo2()
        {
            ArticleList = new List<Article>();
        }

        protected override async Task OnInitializedAsync()
        {
            _hubConnection = new HubConnectionBuilder()
                .WithUrl("https://localhost:7130/articlehub").Build();

            _hubConnection.On("newArticle", async () => { await LoadData(); });

            await _hubConnection.StartAsync();

            await LoadData();
        }

        private async Task LoadData()
        {
            ArticleList = (await ArticleService.GetAll()).ToList();
            StateHasChanged();
        }

        public async void AddArticle(Article article)
        {
            await ArticleService.Create(article);
            await LoadData();
            
            //article.Id = ArticleList.Count() + 1;
            //ArticleList.Add(article);
        }

        public void SelectArticle(int id)
        {
            SelectedId = id;
            //Selected = ArticleList.FirstOrDefault(x => x.Id == id);
        }
    }
}
