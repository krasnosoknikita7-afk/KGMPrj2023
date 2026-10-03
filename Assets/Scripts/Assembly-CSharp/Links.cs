using System.Collections.Generic;
using MV.WorldObject;

public class Links
{
	private readonly Dictionary<int, Link> links;

	private readonly Dictionary<int, LinkObjectScript> linkObjects;

	public bool RemoveLink(int linkID, MVWorldObjectClient outputWo, MVWorldObjectClient inputWo)
	{
		return false;
	}

	public void Update()
	{
	}

	public bool Contains(int linkID)
	{
		return false;
	}

	public Link GetLink(int linkID)
	{
		return null;
	}

	public void AddLink(Link link, MVWorldObjectClient outputWo, MVWorldObjectClient inputWo)
	{
	}
}
