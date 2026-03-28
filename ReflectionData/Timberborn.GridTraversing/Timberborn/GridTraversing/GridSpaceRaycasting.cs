using UnityEngine;

namespace Timberborn.GridTraversing
{
	public static class GridSpaceRaycasting
	{
		public static Vector3? HitHorizontalPlane(Ray ray, float height)
		{
			if (new Plane(Vector3.back, height).Raycast(ray, out float enter))
			{
				return ray.GetPoint(enter);
			}
			return null;
		}
	}
}
