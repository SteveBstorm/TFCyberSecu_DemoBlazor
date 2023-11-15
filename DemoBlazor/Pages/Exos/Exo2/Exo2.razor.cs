using DemoBlazor.Pages.Exos.Exo2.Models;

namespace DemoBlazor.Pages.Exos.Exo2
{
    public partial class Exo2
    {
        public List<Article> ArticleList { get; set; }
        public Article Selected { get; set; }
        public Exo2()
        {
            ArticleList = new List<Article>();
            AddArticle(new Article { Nom = "Coca", Prix = 2, Categorie = "Boisson", Description = "100% pur sucre" });
            AddArticle(new Article { Nom = "RTX 4090", Prix = 2000, Categorie = "Hardware", Description = "Trop cher pour ce que c'est" });
        }

        public void AddArticle(Article article)
        {
            article.Id = ArticleList.Count() + 1;
            ArticleList.Add(article);
        }

        public void SelectArticle(int id)
        {

            Selected = ArticleList.FirstOrDefault(x => x.Id == id);
        }
    }
}
