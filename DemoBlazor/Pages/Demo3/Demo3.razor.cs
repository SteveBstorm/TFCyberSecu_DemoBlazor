namespace DemoBlazor.Pages.Demo3
{
    public partial class Demo3
    {
        public Client MonClient { get; set; }

        public Demo3()
        {
            MonClient = new Client();
        }

        void Validation()
        {
            Console.WriteLine(MonClient.Firstname + " - " + MonClient.Email);
        }
    }
}
