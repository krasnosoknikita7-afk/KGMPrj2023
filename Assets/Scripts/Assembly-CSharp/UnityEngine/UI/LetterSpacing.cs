using System.Collections;
using System.Collections.Generic;

namespace UnityEngine.UI
{
	[AddComponentMenu("UI/Effects/Letter Spacing", 15)]
	public class LetterSpacing : BaseMeshEffect
	{
		private const string SupportedTagRegexPattersn = "<b>|</b>|<i>|</i>|<size=.*?>|</size>|<color=.*?>|</color>|<material=.*?>|</material>";

		[SerializeField]
		private bool useRichText;

		[SerializeField]
		private float m_spacing;

		public float spacing
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		protected LetterSpacing()
		{
		}

		public override void ModifyMesh(VertexHelper vh)
		{
		}

		public void ModifyVertices(List<UIVertex> verts)
		{
		}

		private IEnumerator GetRegexMatchedTagCollection(string line, out int lineLengthWithoutTags)
		{
			lineLengthWithoutTags = default;
			return null;
		}
	}
}
