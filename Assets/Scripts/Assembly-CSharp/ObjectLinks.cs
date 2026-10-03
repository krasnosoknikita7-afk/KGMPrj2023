using System.Collections.Generic;
using MV.WorldObject;

public class ObjectLinks
{
	protected readonly Dictionary<int, ObjectLink> objectLinks;

	protected readonly Dictionary<int, ObjectLinkObjectScript> objectLinkObjects;

	public ObjectLink GetObjectLink(int objectLinkID)
	{
		return null;
	}

	public void Update()
	{
	}

	public bool Contains(int objectLinkID)
	{
		return false;
	}

	public bool RemoveObjectLink(ObjectLink link, MVWorldObjectClient objectConnectorWo, MVWorldObjectClient objectWo)
	{
		return false;
	}

	public bool AddObjectLink(ObjectLink objectLink, MVWorldObjectClient objectConnectorWo, MVWorldObjectClient objectWo)
	{
		return false;
	}
}
