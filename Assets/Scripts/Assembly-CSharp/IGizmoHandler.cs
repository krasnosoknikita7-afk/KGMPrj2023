using UnityEngine.EventSystems;

public interface IGizmoHandler : IEventSystemHandler
{
	void Handle(GizmoAction action);

	void IgnoreSelectionOnce();
}
