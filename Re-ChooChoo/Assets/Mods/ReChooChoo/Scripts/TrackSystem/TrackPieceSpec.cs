using UnityEngine;
using UnityEngine.Serialization;

namespace ReChooChoo.TrackSystem
{
    public class TrackPieceSpec : MonoBehaviour
    {
        [FormerlySerializedAs("_size")]
        [SerializeField]
        private int _trackRouteCount;
        [SerializeField]
        private TrackRouteSpec[] _trackRouteSpecs;

        public int TrackRouteCount => _trackRouteCount;
        public TrackRouteSpec[] TrackRouteSpecs => _trackRouteSpecs;
    }
}
