using System.Collections.Generic;
using ReChooChoo.TrackSystem;
using UnityEngine;

namespace ReChooChoo.NavigationSystem
{
    public interface ITrainDestination
    {
        bool GeneratePath(Transform transform, List<TrackRoute> pathCorners);
    }
}
