using DemoBlazor.Pages.Exos.Exo2.Models;

namespace DemoBlazor.Pages.Exos.Exo2.Services
{
    public interface IArticleService
    {
        Task Create(Article a);
        Task<IEnumerable<Article>> GetAll();
        Task<Article> GetById(int id);
    }
}