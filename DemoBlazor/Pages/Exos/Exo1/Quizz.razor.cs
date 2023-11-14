using System.Reflection.PortableExecutable;

namespace DemoBlazor.Pages.Exos.Exo1
{
    public partial class Quizz
    {
        public string Pseudo { get; set; }

        public List<string> Responses { get; set; }
        public bool IsFinished { get; set; } = false;
        public Quizz()
        {
            Responses = new List<string>();
        }

        void AddResponse(string r)
        {
            Responses.Add(r);
        }

        void FinishGame()
        {
            IsFinished = true;
        }
    }
}
