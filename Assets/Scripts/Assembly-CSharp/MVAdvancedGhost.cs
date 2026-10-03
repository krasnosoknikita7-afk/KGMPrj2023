using System.Collections.Generic;
using MV.Common;
using MV.WorldObject;
using UnityEngine;

public class MVAdvancedGhost : MVBlueprintBase, IGameStateControllerSubscriber, ITeamInteractorNPC, IHealRayAttachementObject
{
	private AdvancedGhostBehaviour advancedGhostBehaviour;

	private ClientSideNPCInteractable interactable;

	private AdvancedGhostCubeModelWrapper editableCubeModelWrapper;

	private AdvancedGhostIcon advancedGhostIcon;

	private GameObject attachmentObject;

	private AdvancedGhostObject advGhostObject;

	private ClientSideNPCInteractionHandler interactionHandler;

	private const float deathExplosionDamageValue = 20f;

	private const float deathExplosionRadius = 5f;

	private const float deathExplosionImpulse = 1000f;

	public override MVWorldObjectDocumentationType DocumentationType => MVWorldObjectDocumentationType.Missing;

	private MVTeam Team => MVTeam.Blue;

	public override Vector3 WorldPivot => default;

	public MVAdvancedGhost(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null)
	{
	}

	public override void Initialize()
	{
	}

	private void OnPositionChanged(MVWorldObjectClient arg0, PositionChangedEventArgs positionChangedEventArgs)
	{
	}

	private void SetupEditorIcon(MVCubeModelBase cubeModelBody, bool enableCulling)
	{
	}

	public override void InitializeInventory()
	{
	}

	private void SetGameMode(bool isPlayMode)
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

	public override Bounds GetLocalBounds(BoundsContext boundsContext)
	{
		return default;
	}

	public override void Select(Color color)
	{
	}

	public override void DeSelect()
	{
	}

	public override void Destroy()
	{
	}

	public override Vector3 GetTargetPosition()
	{
		return default;
	}

	private void ReceiveDamage(float amount, MVPlayer damageDealer, PlayerKilledByType damageType)
	{
	}

	public override void Reset()
	{
	}

	public bool IsOnSameTeam(MVTeam team)
	{
		return false;
	}

	public override void OnDataUpdate()
	{
	}

	private void SetTeam(MVTeam team)
	{
	}

	private void SetTeam_Edit(MVTeam team)
	{
	}

	public void GameStateChanged(UpdateCondition condition)
	{
	}

	public GameObject GetHealRayAttachmentObject()
	{
		return null;
	}
}
