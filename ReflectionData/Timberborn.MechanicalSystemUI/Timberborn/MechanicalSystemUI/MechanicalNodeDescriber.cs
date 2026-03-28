using System.Collections.Generic;
using Timberborn.BaseComponentSystem;
using Timberborn.EntityPanelSystem;
using Timberborn.Localization;
using Timberborn.MechanicalSystem;
using Timberborn.UIFormatters;
using UnityEngine.UIElements;

namespace Timberborn.MechanicalSystemUI
{
	internal class MechanicalNodeDescriber : BaseComponent, IAwakableComponent, IEntityDescriber
	{
		private static readonly string PowerClass = "described-amount--power";

		private static readonly string PowerInputKey = "Mechanical.PowerInput";

		private static readonly string PowerOutputLocKey = "Mechanical.PowerOutput";

		private static readonly string PowerUnitLocKey = "Unit.HorsePower.NumberAndUnit";

		private readonly ILoc _loc;

		private readonly DescribedAmountFactory _describedAmountFactory;

		private readonly ProductionItemFactory _productionItemFactory;

		private MechanicalNode _mechanicalNode;

		private MechanicalNodeSpec _mechanicalNodeSpec;

		private MechanicalNodeDescriptionSpec _mechanicalNodeDescriptionSpec;

		public MechanicalNodeDescriber(ILoc loc, DescribedAmountFactory describedAmountFactory, ProductionItemFactory productionItemFactory)
		{
			_loc = loc;
			_describedAmountFactory = describedAmountFactory;
			_productionItemFactory = productionItemFactory;
		}

		public void Awake()
		{
			_mechanicalNode = GetComponent<MechanicalNode>();
			_mechanicalNodeSpec = GetComponent<MechanicalNodeSpec>();
			_mechanicalNodeDescriptionSpec = GetComponent<MechanicalNodeDescriptionSpec>();
		}

		public IEnumerable<EntityDescription> DescribeEntity()
		{
			if (_mechanicalNodeSpec != null && !_mechanicalNode.Enabled)
			{
				int powerOutput = _mechanicalNodeSpec.PowerOutput;
				int powerInput = _mechanicalNodeSpec.PowerInput;
				if (powerOutput > 0)
				{
					string tooltipText = GetTooltipText(powerOutput, PowerOutputLocKey);
					string amount = FormatPower(powerOutput) ?? "";
					VisualElement output = _describedAmountFactory.CreatePlain(PowerClass, amount, tooltipText);
					VisualElement content = _productionItemFactory.CreateOutput(output);
					yield return EntityDescription.CreateOutputSection(content, 2147483646);
				}
				if (powerInput > 0)
				{
					string tooltipText2 = GetTooltipText(powerInput, PowerInputKey);
					string amount2 = FormatPower(powerInput) ?? "";
					VisualElement content2 = _describedAmountFactory.CreatePlain(PowerClass, amount2, tooltipText2);
					yield return EntityDescription.CreateMiddleSection(content2, 4);
				}
			}
		}

		private string GetTooltipText(int power, string typeLocKey)
		{
			return _loc.T(typeLocKey, FormatPower(power));
		}

		private string FormatPower(int power)
		{
			string key = ((_mechanicalNodeDescriptionSpec != null) ? _mechanicalNodeDescriptionSpec.AlternativePowerUnitLocKey : PowerUnitLocKey);
			return _loc.T(key, power);
		}
	}
}
