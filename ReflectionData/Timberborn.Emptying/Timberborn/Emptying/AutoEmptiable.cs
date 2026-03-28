using System;
using Timberborn.BaseComponentSystem;
using Timberborn.BlockingSystem;
using Timberborn.BlockSystem;

namespace Timberborn.Emptying
{
	public class AutoEmptiable : BaseComponent, IAwakableComponent, IFinishedStateListener
	{
		private BlockableObject _blockableObject;

		private Emptiable _emptiable;

		public void Awake()
		{
			_blockableObject = GetComponent<BlockableObject>();
			_emptiable = GetComponent<Emptiable>();
		}

		public void OnEnterFinishedState()
		{
			_blockableObject.ObjectUnblocked += OnObjectUnblocked;
			_blockableObject.ObjectBlocked += OnObjectBlocked;
		}

		public void OnExitFinishedState()
		{
			_blockableObject.ObjectUnblocked -= OnObjectUnblocked;
			_blockableObject.ObjectBlocked -= OnObjectBlocked;
			_emptiable.UnmarkForEmptying();
		}

		private void OnObjectUnblocked(object sender, EventArgs e)
		{
			_emptiable.UnmarkForEmptying();
		}

		private void OnObjectBlocked(object sender, EventArgs e)
		{
			_emptiable.MarkForEmptyingWithoutStatus();
		}
	}
}
