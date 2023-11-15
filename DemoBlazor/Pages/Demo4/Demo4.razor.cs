namespace DemoBlazor.Pages.Demo4
{
    public partial class Demo4
    {
        List<Guid> guids { get; set; }

        public Demo4()
        {
            guids = new List<Guid>();
            for(int i = 0; i < 500; i++)
            {
                guids.Add(Guid.NewGuid());
            }
        }
    }
}
