using DemoBlazor.Pages.Exos.Exo2.Models;
using Microsoft.AspNetCore.Components;

namespace DemoBlazor.Pages.Exos.Exo2
{
    public partial class AddForm
    {
        public Article NewArticle { get; set; }

        [Parameter]
        public EventCallback<Article> NotifyNewArticle { get; set; }
        public AddForm()
        {
            NewArticle = new Article();          
        }

        public void OnSubmit()
        {
            NotifyNewArticle.InvokeAsync(NewArticle);
            NewArticle = new Article();
        }
    }
}
