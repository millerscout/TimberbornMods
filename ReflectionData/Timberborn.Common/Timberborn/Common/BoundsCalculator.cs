using System.Linq;
using UnityEngine;

namespace Timberborn.Common
{
	public class BoundsCalculator
	{
		public float GetRendererYMaxBound(Transform parent)
		{
			return GetRendererYMaxBoundInternal(parent, includeInactive: true);
		}

		public float GetEnabledRendererYMaxBound(Transform parent)
		{
			return GetRendererYMaxBoundInternal(parent, includeInactive: false);
		}

		private static float GetRendererYMaxBoundInternal(Transform parent, bool includeInactive)
		{
			return (from c in parent.GetComponentsInChildren<Renderer>(includeInactive)
				select c.bounds.max.y).DefaultIfEmpty(0f).Max();
		}
	}
}
