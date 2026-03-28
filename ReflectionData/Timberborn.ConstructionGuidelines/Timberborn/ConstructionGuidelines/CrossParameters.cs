using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;

namespace Timberborn.ConstructionGuidelines
{
	internal record CrossParameters
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(CrossParameters);
			}
		}

		public Vector3Int Center { get; private set; }

		public Vector2Int Min { get; private set; }

		public Vector2Int Max { get; private set; }

		private bool _isFromPreview;

		public bool CrossParametersUpdated(Vector3Int center, Vector2Int min, Vector2Int max, bool isFromPreview)
		{
			if (Center != center || Min != min || Max != max || _isFromPreview != isFromPreview)
			{
				Center = center;
				Min = min;
				Max = max;
				_isFromPreview = isFromPreview;
				return true;
			}
			return false;
		}

		public void Reset()
		{
			Center = new Vector3Int(-1, -1, -1);
			Min = new Vector2Int(-1, -1);
			Max = new Vector2Int(-1, -1);
		}

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("CrossParameters");
			stringBuilder.Append(" { ");
			if (PrintMembers(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		[CompilerGenerated]
		protected virtual bool PrintMembers(StringBuilder builder)
		{
			RuntimeHelpers.EnsureSufficientExecutionStack();
			builder.Append("Center = ");
			builder.Append(Center.ToString());
			builder.Append(", Min = ");
			builder.Append(Min.ToString());
			builder.Append(", Max = ");
			builder.Append(Max.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<Vector3Int>.Default.GetHashCode(Center)) * -1521134295 + EqualityComparer<Vector2Int>.Default.GetHashCode(Min)) * -1521134295 + EqualityComparer<Vector2Int>.Default.GetHashCode(Max)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(_isFromPreview);
		}

		[CompilerGenerated]
		public virtual bool Equals(CrossParameters? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<Vector3Int>.Default.Equals(Center, other!.Center) && EqualityComparer<Vector2Int>.Default.Equals(Min, other!.Min) && EqualityComparer<Vector2Int>.Default.Equals(Max, other!.Max))
				{
					return EqualityComparer<bool>.Default.Equals(_isFromPreview, other!._isFromPreview);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected CrossParameters(CrossParameters original)
		{
			Center = original.Center;
			Min = original.Min;
			Max = original.Max;
			_isFromPreview = original._isFromPreview;
		}

		public CrossParameters()
		{
			Center = new Vector3Int(-1, -1, -1);
			Min = new Vector2Int(-1, -1);
			Max = new Vector2Int(-1, -1);
			base._002Ector();
		}
	}
}
