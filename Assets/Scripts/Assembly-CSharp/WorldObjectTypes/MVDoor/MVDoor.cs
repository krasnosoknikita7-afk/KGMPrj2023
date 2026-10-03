using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Assets.Scripts.WorldObjectTypes.MVDoor;
using UnityEngine;

namespace WorldObjectTypes.MVDoor
{
	public class MVDoor : MVLogicObject, IIsLogicObjectFiringEventHandler, ILogicWorldObject
	{
		public struct DoorConfiguration
		{
			public string name;

			public bool beginOpen;

			public bool playersCanOpen;

			public bool reverseOpenDirection;

			public float openValue;

			public float closeValue;

			public float toggleTime;

			public MVWorldObjectDocumentationType docType;

			public DoorType doorType;
		}

		[CompilerGenerated]
		private sealed class _003CAnimationCoroutine_003Ed__55 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public MVDoor _003C_003E4__this;

			public float from;

			public float to;

			private float _003CcurrentValue_003E5__2;

			private float _003Ct_003E5__3;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CAnimationCoroutine_003Ed__55(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CCollisionCheckCoroutine_003Ed__57 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public MVDoor _003C_003E4__this;

			private MVAvatarLocal _003ClocalAvatar_003E5__2;

			private bool _003CfoundIntersection_003E5__3;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CCollisionCheckCoroutine_003Ed__57(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CBeginOpenCoroutine_003Ed__62 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public MVDoor _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CBeginOpenCoroutine_003Ed__62(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CServerResponseTimeoutRoutine_003Ed__67 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public MVDoor _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CServerResponseTimeoutRoutine_003Ed__67(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		public MVCubeModelInstance doorModelInstance;

		private const float serverResponseTimeoutSeconds = 1f;

		private MVDoorObject doorObject;

		private UseInteractor useInteractor;

		private DoorConfiguration doorConfig;

		private Dictionary<object, object> useInteractorData;

		private IEnumerator doorAnimationRoutine;

		private IEnumerator collisionCheckRoutine;

		private IEnumerator serverResponseTimeoutRoutine;

		private bool localIsOpen;

		private bool storedBeginOpen;

		private bool storedReverseOpenDirection;

		public IInputSignalReceiver InputSignalReceiver { get; private set; }

		public override bool HasInputConnector => false;

		public override bool HasOutputConnector => false;

		public DoorConfiguration DoorConfig => default;

		public DoorType DoorType => DoorType.Door;

		public MVDoorObject DoorObject => null;

		public override Vector3 InputConnectorOffset => default;

		public override Quaternion InputConnectorRotation => default;

		protected override bool HasVisualsInPlaymode => false;

		private bool IsOpen
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public MVDoorBlueprint DoorBlueprint { get; set; }

		public MVDoor(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
			: base(null, null, null)
		{
		}

		public override void Initialize()
		{
		}

		private void InputStateUpdateCallback(LogicInputState logicInputState, LogicObjectManager logicObjectManager)
		{
		}

		public override void OnDataUpdate()
		{
		}

		public void SetUseInteractorData(Dictionary<object, object> data)
		{
		}

		public void UpdateUseInteractor()
		{
		}

		private bool CheckIfOpen()
		{
			return false;
		}

		private void UpdateBeginOpen()
		{
		}

		private void UpdateReverseOpen()
		{
		}

		private DoorConfiguration ReadWorldObjectData()
		{
			return default;
		}

		private static DoorConfiguration CreateDefaultDoorConfig(DoorType doorType)
		{
			return default;
		}

		public bool Use(int userWoID)
		{
			return false;
		}

		public override void Reset()
		{
		}

		private void ToggleDoor(bool state)
		{
		}

		private void StartDoorAnimation(float from, float to)
		{
		}

		[IteratorStateMachine(typeof(_003CAnimationCoroutine_003Ed__55))]
		private IEnumerator AnimationCoroutine(float from, float to)
		{
			return null;
		}

		private void CollisionCheck()
		{
		}

		[IteratorStateMachine(typeof(_003CCollisionCheckCoroutine_003Ed__57))]
		private IEnumerator CollisionCheckCoroutine()
		{
			return null;
		}

		private bool IntersectsWithDoor(Bounds bound)
		{
			return false;
		}

		private void ToggleDoorColliders(bool val)
		{
		}

		private void DestroyUseInteractor()
		{
		}

		public override void Destroy()
		{
		}

		[IteratorStateMachine(typeof(_003CBeginOpenCoroutine_003Ed__62))]
		private IEnumerator BeginOpenCoroutine()
		{
			return null;
		}

		public void OnIsFiringChanged(bool isFiring)
		{
		}

		private void OnEditModeChange(EditModeChangeArgs arg)
		{
		}

		public (float, float) GetOpenCloseValues()
		{
			return default;
		}

		public override bool OnClickHandler(EditorStateMachine esm, Collider collider)
		{
			return false;
		}

		[IteratorStateMachine(typeof(_003CServerResponseTimeoutRoutine_003Ed__67))]
		private IEnumerator ServerResponseTimeoutRoutine()
		{
			return null;
		}
	}
}
