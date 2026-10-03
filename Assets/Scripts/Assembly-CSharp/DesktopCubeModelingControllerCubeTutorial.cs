using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using MV.WorldObject.MetaData;
using UnityEngine;
using UnityEngine.UI;

public class DesktopCubeModelingControllerCubeTutorial : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003COverRideIfDefaultMaterial_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DesktopCubeModelingControllerCubeTutorial _003C_003E4__this;

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
		public _003COverRideIfDefaultMaterial_003Ed__20(int _003C_003E1__state)
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

	private byte defaultMaterial;

	private CubeModelingStateMachine cubeModelingStateMachine;

	private MaterialsController materialsController;

	[SerializeField]
	private RawImage materialsButtonImage;

	[SerializeField]
	private DesktopCubeModelingToolsController desktopCubeModelingController;

	[SerializeField]
	private GameObject deleteTool;

	[SerializeField]
	private GameObject paintTool;

	[SerializeField]
	private GameObject cubeTool;

	[SerializeField]
	private FirstTimeCubeEditFadeButtons materialButton;

	[SerializeField]
	private DesktopCubeModelingToolsController desktopCubeModelingToolsController;

	[SerializeField]
	private FirstTimeEvent exitFirstTimeEvent;

	private bool paintHasBeenActivated;

	public void Initialize(CubeModelingStateMachine cubeModelingStateMachine, MaterialsController materialsController)
	{
	}

	private void OnFirstTimeState(FirstTimeState firstTimeState, FirstTimeEvent firstTimeEvent)
	{
	}

	private void UpdateDelete()
	{
	}

	private void UpdatePaint()
	{
	}

	private void DeactivateAllToolButtons()
	{
	}

	public void SetMaterial(byte materialId)
	{
	}

	private void DoSetMaterial(byte materialId)
	{
	}

	public void MaterialsPop()
	{
	}

	[IteratorStateMachine(typeof(_003COverRideIfDefaultMaterial_003Ed__20))]
	private IEnumerator OverRideIfDefaultMaterial()
	{
		return null;
	}

	private void OnDestroy()
	{
	}
}
