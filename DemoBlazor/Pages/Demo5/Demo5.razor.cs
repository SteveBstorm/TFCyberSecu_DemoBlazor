using Microsoft.AspNetCore.Components;

namespace DemoBlazor.Pages.Demo5
{
    public partial class Demo5
    {
        public int Counter { get; set; }

        //Etape 1
        public Demo5()
        {
            Console.WriteLine("Passage dans le constructeur");
        }


        //Etape 2
        protected override async Task OnInitializedAsync()
        {
            Console.WriteLine("Passage dans OnInitialized");
        }

        //Etape 3 ==> On charge les composants Enfants (Demo5Bis)

        //Etape 4 ==> AfterRender prend la main
        //Etape 4bis ==> Chaque changement d'une valeur passée en paramètre dans l'enfant
        //               Déclenche OnParameterSet (se trouvant dans l'enfant)
        protected override void OnAfterRender(bool firstRender)
        {
            if (firstRender)
            {
                Console.WriteLine("Nombre de rendu : " + Counter);
                Console.WriteLine("First render");
            }
            else
               
                Console.WriteLine("La catégorie recherchée porte l'id : " + Counter);

        }

        public void SimulateRender()
        {
            Counter++;
        }

    }
}
