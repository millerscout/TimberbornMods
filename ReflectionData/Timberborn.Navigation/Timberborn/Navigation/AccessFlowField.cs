using System.Collections.Generic;
using Timberborn.Common;

namespace Timberborn.Navigation
{
	internal class AccessFlowField : IFlowField
	{
		private readonly struct VisitedNode
		{
			public int ParentNodeId { get; }

			public float Distance { get; }

			public VisitedNode(int parentNodeId, float distance)
			{
				ParentNodeId = parentNodeId;
				Distance = distance;
			}
		}

		private readonly Dictionary<int, VisitedNode> _nodes = new Dictionary<int, VisitedNode>();

		public bool IsFilled { get; private set; }

		public int NumberOfNodes => _nodes.Count;

		public bool FoundPath(int destinationNodeId)
		{
			if (IsFilled)
			{
				return HasNode(destinationNodeId);
			}
			return false;
		}

		public void MarkAsFilled()
		{
			IsFilled = true;
		}

		public void AddNode(int nodeId, int parentNodeId, float distance)
		{
			_nodes[nodeId] = new VisitedNode(parentNodeId, distance);
		}

		public bool HasNode(int nodeId)
		{
			return _nodes.ContainsKey(nodeId);
		}

		public int GetParentId(int nodeId)
		{
			return _nodes[nodeId].ParentNodeId;
		}

		public float GetDistance(int nodeId)
		{
			return _nodes[nodeId].Distance;
		}

		public IEnumerable<FlowFieldNode> GetAllNodes()
		{
			foreach (KeyValuePair<int, VisitedNode> node in _nodes)
			{
				node.Deconstruct(out var key, out var value);
				int id = key;
				VisitedNode visitedNode = value;
				yield return new FlowFieldNode(id, visitedNode.Distance);
			}
		}

		public IReadOnlyCollection<int> GetAllNodeIds()
		{
			return _nodes.Keys;
		}

		public void OnNodesChanged(ReadOnlyList<int> nodeIds)
		{
			for (int i = 0; i < nodeIds.Count; i++)
			{
				if (HasNode(nodeIds[i]))
				{
					Clear();
					break;
				}
			}
		}

		public void Clear()
		{
			_nodes.Clear();
			IsFilled = false;
		}
	}
}
