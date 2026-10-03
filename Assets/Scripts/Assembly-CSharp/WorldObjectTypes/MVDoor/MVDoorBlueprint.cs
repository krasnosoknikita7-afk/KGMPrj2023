using System.Collections.Generic;
using UnityEngine;

namespace WorldObjectTypes.MVDoor
{
	public class MVDoorBlueprint : MVBlueprintBase
	{
		private MVDoor doorLogic;

		private EditableCubeModelWrapper editableCubeModelWrapper;

		private MVCubeModelInstance editableCubeModel;

		public override MVWorldObjectDocumentationType DocumentationType => MVWorldObjectDocumentationType.Missing;

		public MVDoor DoorLogic => null;

		public MVDoorBlueprint(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
			: base(null, null)
		{
		}

		public override void InitializeInventory()
		{
		}

		public override void Initialize()
		{
		}

		private void SetCubeSize()
		{
		}

		public override void OnDataUpdate()
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
	}
}
