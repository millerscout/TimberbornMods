using Timberborn.WindSystem;

namespace ReChooChoo.Trains
{
    public class StaticWindService
    {
        public static WindService WindService { get; private set; }

        private StaticWindService(WindService windService)
        {
            WindService = windService;
        }
    }
}
