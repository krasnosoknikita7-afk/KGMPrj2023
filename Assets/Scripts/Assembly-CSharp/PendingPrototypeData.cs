internal struct PendingPrototypeData
{
	public int prevPrototypeId;

	public RuntimePrototypeCubeModel pendingRuntimePrototype;

	public PendingPrototypeData(int prevPrototypeId, RuntimePrototypeCubeModel pendingRuntimePrototype)
	{
		this.prevPrototypeId = 0;
		this.pendingRuntimePrototype = null;
	}
}
