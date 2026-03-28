using System;
using Timberborn.Automation;
using Timberborn.BaseComponentSystem;
using Timberborn.BlockingSystem;
using Timberborn.BlockSystem;
using Timberborn.Buildings;
using Timberborn.Localization;
using Timberborn.StatusSystem;

namespace Timberborn.AutomationBuildings
{
	public class PausableBuildingTerminal : BaseComponent, IAwakableComponent, IStartableComponent, IFinishedStateListener, ITerminal
	{
		private static readonly string PausedByAutomationLocKey = "Automation.PausedByAutomation";

		private readonly ILoc _loc;

		private Automatable _automatable;

		private BlockableObject _blockableObject;

		private PausableBuilding _pausableBuilding;

		private StatusToggle _statusToggle;

		public PausableBuildingTerminal(ILoc loc)
		{
			_loc = loc;
		}

		public void Awake()
		{
			_automatable = GetComponent<Automatable>();
			_blockableObject = GetComponent<BlockableObject>();
			_pausableBuilding = GetComponent<PausableBuilding>();
			_statusToggle = StatusToggle.CreatePriorityStatusWithFloatingIcon("PausedByAutomation", _loc.T(PausedByAutomationLocKey));
			DisableComponent();
		}

		public void Start()
		{
			GetComponent<StatusSubject>().RegisterStatus(_statusToggle);
		}

		public void OnEnterFinishedState()
		{
			EnableComponent();
			UpdateBlockable();
			_pausableBuilding.PausedChanged += OnPausedChanged;
		}

		public void OnExitFinishedState()
		{
			DisableComponent();
			UpdateBlockable();
			_pausableBuilding.PausedChanged -= OnPausedChanged;
		}

		public void Evaluate()
		{
			UpdateBlockable();
		}

		private void OnPausedChanged(object sender, EventArgs e)
		{
			UpdateStatusToggle();
		}

		private void UpdateBlockable()
		{
			if (base.Enabled && ShouldBlock())
			{
				_blockableObject.Block(this);
				UpdateStatusToggle();
			}
			else
			{
				_blockableObject.Unblock(this);
				UpdateStatusToggle();
			}
		}

		private void UpdateStatusToggle()
		{
			_statusToggle.Toggle(ShouldBlock() && !_pausableBuilding.Paused);
		}

		private bool ShouldBlock()
		{
			return _automatable.State == ConnectionState.Off;
		}
	}
}
