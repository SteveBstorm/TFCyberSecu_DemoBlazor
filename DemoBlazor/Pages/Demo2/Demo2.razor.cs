namespace DemoBlazor.Pages.Demo2
{
    public partial class Demo2
    {
        public int InfoFromChildren { get; set; }

        void ReceiveInfo(int i)
        {
            InfoFromChildren = i;
        }
    }
}
