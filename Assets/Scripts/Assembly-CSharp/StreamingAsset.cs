using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Networking;

public abstract class StreamingAsset<AssetType, PreviewType> : StreamingAsset where AssetType : UnityEngine.Object where PreviewType : UnityEngine.Object
{
	[Tooltip("If true, bundle will be cached in memory, and never unloaded. It will also require a unique bundle name. If false, bundle will be destroyed and resources freed on destruction.")]
	[SerializeField]
	protected bool useCache;

	[SerializeField]
	[Tooltip("If true, will not download this asset for WebGL")]
	private bool excludeWebGL;

	private AssetType asset;

	public AssetType Asset
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	protected virtual void Start()
	{
	}

	protected void DownloadWhenPossible()
	{
	}

	protected override void OnDownloadFinished(UnityWebRequest www)
	{
	}

	public static implicit operator AssetType(StreamingAsset<AssetType, PreviewType> a)
	{
		return null;
	}

	protected override void OnDestroy()
	{
	}
}
public abstract class StreamingAsset : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CDelayedUnload_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UnityWebRequest www;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CDelayedUnload_003Ed__11(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[SerializeField]
	[HideInInspector]
	protected string url;

	protected UnityAction onAssetSetAction;

	private static HashSet<UnityWebRequest> cachedAssetBundles;

	private static string assetBundleUrl;

	public string Url
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static string AssetBundleUrl => null;

	protected abstract void OnAssetSet();

	public static void ClearCache()
	{
	}

	private static AssetType UnpackBundle<AssetType>(UnityWebRequest www) where AssetType : UnityEngine.Object
	{
		return null;
	}

	public static AssetType UnpackBundle_Cached<AssetType>(UnityWebRequest www) where AssetType : UnityEngine.Object
	{
		return null;
	}

	protected static AssetType UnpackBundle_NonCached<AssetType>(UnityWebRequest www, MonoBehaviour coroutineHost) where AssetType : UnityEngine.Object
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CDelayedUnload_003Ed__11))]
	protected static IEnumerator DelayedUnload(UnityWebRequest www)
	{
		return null;
	}

	public static string DBUrlToServerUrl(string url)
	{
		return null;
	}

	protected void Download_Cached(string url, UnityAction onAssetSetAction)
	{
	}

	protected void Download_NonCached(string url, UnityAction onAssetSetAction)
	{
	}

	protected abstract void OnDownloadFinished(UnityWebRequest www);

	protected virtual void OnDestroy()
	{
	}
}
