using Timberborn.CoreUI;
using UnityEngine.UIElements;

namespace Timberborn.DropdownSystem
{
	internal class DropdownInitializer : IVisualElementInitializer
	{
		private readonly DropdownListDrawer _dropdownListDrawer;

		public DropdownInitializer(DropdownListDrawer dropdownListDrawer)
		{
			_dropdownListDrawer = dropdownListDrawer;
		}

		public void InitializeVisualElement(VisualElement visualElement)
		{
			(visualElement as Dropdown)?.Initialize(_dropdownListDrawer);
		}
	}
}
