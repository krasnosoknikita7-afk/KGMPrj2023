using System;

public abstract class World
{
	protected MVWorldObjectClientManagerNetwork worldObjectClientManager;

	protected MVWorldInventory worldInventory;

	protected RuntimeEventManagerNetwork runtimeEventManagerNetwork;

	public EventHandler<InitializedGameQueryDataEventArgs> InitializedGameQueryData;

	public MVWorldInventory WorldInventory => null;

	public MVWorldObjectClientManager WorldObjectClientManager => null;

	public RuntimeEventManager RuntimeEventManager => null;
}
