using DemoBlazor.Pages.Exos.Exo2.Models;
using Microsoft.AspNetCore.Components;

namespace DemoBlazor.Pages.Exos.Exo2
{
    public partial class Detail
    {
        [Parameter]
        public Article CurrentArticle { get; set; }
    }
}
