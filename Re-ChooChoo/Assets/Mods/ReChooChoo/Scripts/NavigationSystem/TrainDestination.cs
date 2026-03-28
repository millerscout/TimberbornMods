using ReChooChoo.TrackSystem;
using Timberborn.BaseComponentSystem;

namespace ReChooChoo.NavigationSystem
{
    public class TrainDestination : BaseComponent
    {
        public TrackPiece TrackPiece { get; private set; }

        private void Awake()
        {
            TrackPiece = GetComponentFast<TrackPiece>();
        }
    }
}
