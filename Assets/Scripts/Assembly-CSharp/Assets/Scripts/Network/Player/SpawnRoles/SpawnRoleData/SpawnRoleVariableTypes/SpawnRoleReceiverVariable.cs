using Assets.Scripts.Network.Player.SpawnRoles.SpawnRoleData.Mediator;

namespace Assets.Scripts.Network.Player.SpawnRoles.SpawnRoleData.SpawnRoleVariableTypes
{
	public class SpawnRoleReceiverVariable<T>
	{
		private readonly SpawnRoleDataReceiver spawnRoleDataReceiver;

		private readonly SubscribableVariable<T> subscribableVariableExternal;

		protected readonly SubscribableVariable<T> subscribableVariable;

		public T Value
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public SpawnRoleReceiverVariable(SubscribableVariable<T> subscribableVariableExternal, SpawnRoleDataReceiver spawnRoleDataReceiver)
		{
		}

		private void OnChange(T newValue)
		{
		}
	}
}
