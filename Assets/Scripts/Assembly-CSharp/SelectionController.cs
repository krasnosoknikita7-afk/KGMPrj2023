using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class SelectionController : ISelectionController
{
	private HashSet<int> selectedIDs;

	private Stack<int> parentGroups;

	[CompilerGenerated]
	private EventHandler<WorldObjectDestroyedEventArgs> m_SelectedWorldObjectDeleted;

	private MVWorldObjectClientManager WOCM => null;

	public int ParentGroupID => 0;

	public bool ParentGroupIsRoot => false;

	public MVGroup ParentGroup => null;

	public HashSet<int> SelectedIDs => null;

	public HashSet<MVWorldObjectClient> SelectedWOs => null;

	public MVWorldObjectClient SingleSelectedWO => null;

	public event EventHandler<WorldObjectDestroyedEventArgs> SelectedWorldObjectDeleted
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void WOCM_WorldObjectDestroyedHandler(object sender, WorldObjectDestroyedEventArgs e)
	{
	}

	private void PushWOParents(MVWorldObjectClient wo, bool addAsParent = false)
	{
	}

	public WorldObjectClientRef SelectWO(int id, bool addToSelection = false, bool showVisuals = true)
	{
		return null;
	}

	public WorldObjectClientRef Select(bool addToSelection = false, bool showVisuals = true, int layerMask = -5)
	{
		return null;
	}

	public WorldObjectClientRef Select(VoxelHit hit, bool addToSelection = false, bool showVisuals = true)
	{
		return null;
	}

	public bool SelectParent(bool showVisuals = true)
	{
		return false;
	}

	public void DeSelectAll()
	{
	}

	public void DeSelectAllExcept(int id)
	{
	}

	public void DeSelectWorldObject(MVWorldObjectClient wo)
	{
	}

	public void EnterGroup(MVGroup group)
	{
	}

	public int ExitGroup()
	{
		return 0;
	}

	public int ExitGroupToRoot()
	{
		return 0;
	}

	public bool IsSelected(int id)
	{
		return false;
	}

	public bool IsChildOf(int childId, int parentId)
	{
		return false;
	}

	public bool IsChildOf(MVWorldObjectClient child, MVWorldObjectClient parent)
	{
		return false;
	}
}
