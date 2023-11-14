using Microsoft.AspNetCore.Components;

namespace DemoBlazor.Pages
{
    public partial class Demo1
    {
        public int MyValue { get; set; }
        public Demo1()
        {
            MyValue = 1;

            maliste = new List<string>();
            maliste.Add("bidule");
            maliste.Add("machin");
            maliste.Add("truc");
            maliste.Add("bazar");
        }

        void ajout(int value)
        {
            
            MyValue+=value;
        }
        void retrait()
        {
            
            if(MyValue > 0) { MyValue--; }
        }

        public List<string> maliste{ get; set; }

        void affiche(string s)
        {
            Console.WriteLine(s);
        }
    }
}
