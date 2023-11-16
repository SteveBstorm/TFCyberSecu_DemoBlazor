using DemoBlazor.Pages.Exos.Exo2.Models;
using DemoBlazor.Pages.Exos.Exo2.Services;
using Microsoft.AspNetCore.Components;

namespace DemoBlazor.Pages.Exos.Exo2
{
    public partial class Detail
    {
        //[Parameter]
        public Article CurrentArticle { get; set; }

        [Parameter]
        public int CurrentId { get; set; }

        [Inject]
        public IArticleService ArticleService { get; set; }

        protected override async Task OnParametersSetAsync()
        {
            CurrentArticle = await ArticleService.GetById(CurrentId);
        }
    }
}
