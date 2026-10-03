using System;
using System.Collections.Generic;
using UnityEngine;

public class GreyOutObjectScript : MonoBehaviour
{
	private class PickupOriginalMaterials
	{
		public MeshRenderer meshRenderer;

		public Material[] originalMaterials;

		public bool meshRendererEnabled;

		public PickupOriginalMaterials(MeshRenderer meshRenderer)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}

	public GameObject pickupObject;

	public Shader hiddenShader;

	private List<PickupOriginalMaterials> pickupOriginalMaterials;

	private bool isGreyedIn;

	public bool IsGreyedIn => false;

	private void Awake()
	{
	}

	public void Hide()
	{
	}

	public void GreyIn()
	{
	}

	public void GreyOut()
	{
	}

	public void InitializeOriginalMaterials()
	{
	}

	private static void GreyInExec(PickupOriginalMaterials pickupOriginalMaterial)
	{
	}

	private void GreyOutExec(PickupOriginalMaterials pickupOriginalMaterial)
	{
	}

	private void HideExec(PickupOriginalMaterials pickupOriginalMaterial)
	{
	}

	private void ExecuteOnMaterials(Action<PickupOriginalMaterials> action)
	{
	}
}
