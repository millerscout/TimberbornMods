using System.Collections.Generic;
using ReChooChoo.TrackSystem;
using UnityEngine;

namespace ReChooChoo.NavigationSystem
{
    public class TrainPositionDestination : ITrainDestination
    {
        private readonly TrainNavigationService _trainNavigationService;

        public TrainDestination Destination { get; }

        public TrainPositionDestination(TrainNavigationService trainNavigationService, TrainDestination destination)
        {
            _trainNavigationService = trainNavigationService;
            Destination = destination;
        }

        public bool GeneratePath(Transform transform, List<TrackRoute> pathCorners)
        {
            var pathFound = _trainNavigationService.FindTrackPath(transform, Destination, pathCorners);
            // Plugin.Log.LogInfo("Path Found: " + pathFound);
            return pathFound;
        }
    }
}
