using Timberborn.BaseComponentSystem;
using Timberborn.SelectionSystem;

namespace Timberborn.CharacterModelSystem
{
	internal class VisibleSelectedCharacterModel : BaseComponent, IAwakableComponent, ISelectionListener
	{
		private CharacterModel _characterModel;

		public void Awake()
		{
			_characterModel = GetComponent<CharacterModel>();
		}

		public void OnSelect()
		{
			_characterModel.IgnoreModelBlockade();
		}

		public void OnUnselect()
		{
			_characterModel.UnignoreModelBlockade();
		}
	}
}
