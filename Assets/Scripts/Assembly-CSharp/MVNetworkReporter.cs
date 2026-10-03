using System;
using UnityEngine;

public class MVNetworkReporter : MVNetworkObject
{
	private struct SendTransformData : IEquatable<SendTransformData>
	{
		private Vector3 position;

		private byte[] rotation;

		public SendTransformData(Vector3 position, byte[] rotation)
		{
			this.position = default;
			this.rotation = null;
		}

		public bool Equals(SendTransformData other)
		{
			return false;
		}

		public static bool operator ==(SendTransformData std1, SendTransformData std2)
		{
			return false;
		}

		public static bool operator !=(SendTransformData std1, SendTransformData std2)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}

	private long lastUpdateTimestamp;

	public bool suspendTransformReporting;

	private SendTransformData prevSendTransformData;

	private bool stopPackageSent;

	public override bool RemoveFromUpdate => false;

	public MVNetworkReporter(MVWorldObjectClient owner)
		: base(null)
	{
	}

	public override void Update(MVNetworkGame game)
	{
	}
}
