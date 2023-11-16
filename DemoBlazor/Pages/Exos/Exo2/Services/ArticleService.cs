using DemoBlazor.Pages.Exos.Exo2.Models;
using Newtonsoft.Json;
using System.Text;

namespace DemoBlazor.Pages.Exos.Exo2.Services
{
    public class ArticleService : IArticleService
    {
        private readonly HttpClient _httpClient;

        public ArticleService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Article>> GetAll()
        {
            using (HttpResponseMessage response = await _httpClient.GetAsync("article"))
            {
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<IEnumerable<Article>>(json);
                }
                else
                    throw new HttpRequestException(response.StatusCode.ToString());
            }
        }

        public async Task<Article> GetById(int id)
        {
            using (HttpResponseMessage response = await _httpClient.GetAsync("article/" + id))
            {
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<Article>(json);
                }
                else
                    throw new HttpRequestException(response.StatusCode.ToString());
            }
        }

        public async Task Create(Article a)
        {
            string json = JsonConvert.SerializeObject(a);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");

            using (HttpResponseMessage response = await _httpClient.PostAsync("article", content))
            {
                if (!response.IsSuccessStatusCode)
                    throw new HttpRequestException(response.StatusCode.ToString());
            }
        }
    }
}
