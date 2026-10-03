using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.WorldObjectTypes.EditablePickupItem
{
	public abstract class MVEditablePickupItemBaseBlueprint : MVBlueprintBase
	{
		public const string ItemBaseKey = "ItemBase";

		public const string ItemCubeModelKey = "ItemCubeModel";

		protected const float scale = 0.3f;

		protected MVEditablePickupItemBase itemBase;

		protected EditableCubeModelWrapper editableCubeModelWrapper;

		protected MVCubeModelInstance editableCubeModel;

		protected Transform cubeModelBaseParent;

		private int cubeModelId;

		private int cubeModelPid;

		public MVEditablePickupItemBase ItemBase => null;

		public int CubeModelId => 0;

		public int CubeModelPid => 0;

		public MVEditablePickupItemBaseBlueprint(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
			: base(null, null)
		{
		}

		public override void InitializeInventory()
		{
		}

		public override void Initialize()
		{
		}

		public virtual void OnStartEditing()
		{
		}

		public virtual void OnEndEditing()
		{
		}

		public override void OnDataUpdate()
		{
		}

		private void ToggleCubeModelColliders(bool state)
		{
		}

		public override void Select(Color color)
		{
		}

		public override void DeSelect()
		{
		}

		public override bool OnEnterObject(EditorStateMachine e)
		{
			return false;
		}

		public override bool OnExitObject(EditorStateMachine e)
		{
			return false;
		}

		private void SetCubeSize()
		{
		}
	}
}
