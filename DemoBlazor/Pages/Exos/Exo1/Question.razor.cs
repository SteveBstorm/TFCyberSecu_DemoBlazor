using Microsoft.AspNetCore.Components;

namespace DemoBlazor.Pages.Exos.Exo1
{
    public partial class Question
    {
        [Parameter]
        public string Pseudo { get; set; }

        [Parameter]
        public EventCallback<string> NotifyResponse { get; set; }
        [Parameter]
        public EventCallback NotifyGameIsOver { get; set; }

        public List<string> QuestionList{ get; set; }
        public int Counter { get; set; }
        public string CurrentQuestion { get; set; }

        public Question()
        {
            QuestionList = new List<string>();
            QuestionList.Add("Avez-vous bien mangé à midi ?");
            QuestionList.Add("Avez vous compris Blazor ?");
            QuestionList.Add("Une tite pause ?");

            Counter = 0;
            CurrentQuestion = QuestionList[Counter];
            Counter++;
        }

        void Repondre(string resp)
        {
            NotifyResponse.InvokeAsync(resp);
            
            if(Counter >= QuestionList.Count)
            {
                CurrentQuestion = "";
                NotifyGameIsOver.InvokeAsync();
            }
            else
            {
                CurrentQuestion = QuestionList[Counter];
                Counter++;
            }
        }
    }
}
