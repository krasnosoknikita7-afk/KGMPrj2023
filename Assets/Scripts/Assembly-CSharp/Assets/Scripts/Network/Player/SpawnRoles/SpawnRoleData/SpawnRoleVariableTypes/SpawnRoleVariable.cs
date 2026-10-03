using System.Runtime.CompilerServices;

namespace Assets.Scripts.Network.Player.SpawnRoles.SpawnRoleData.SpawnRoleVariableTypes
{
	public class SpawnRoleVariable<T>
	{
		public delegate void SubDelegate(T value);

		protected readonly SubscribableVariable<T> subscribableVariable;

		[CompilerGenerated]
		private SubDelegate m_OnChange;

		public T Value => default;

		public event SubDelegate OnChange
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

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		protected SpawnRoleVariable(T value)
		{
		}

		private void SubscribableVariableOnOnChange(T value)
		{
		}

		public static implicit operator T(SpawnRoleVariable<T> s)
		{
			return default;
		}

		public bool Equals(SpawnRoleVariable<T> other)
		{
			return false;
		}

		public static bool operator ==(SpawnRoleVariable<T> a, SpawnRoleVariable<T> b)
		{
			return false;
		}

		public static bool operator !=(SpawnRoleVariable<T> a, SpawnRoleVariable<T> b)
		{
			return false;
		}

		public static bool operator !=(SpawnRoleVariable<T> a, T b)
		{
			return false;
		}

		public static bool operator ==(SpawnRoleVariable<T> a, T b)
		{
			return false;
		}

		public static bool operator !=(T b, SpawnRoleVariable<T> a)
		{
			return false;
		}

		public static bool operator ==(T b, SpawnRoleVariable<T> a)
		{
			return false;
		}
	}
}
