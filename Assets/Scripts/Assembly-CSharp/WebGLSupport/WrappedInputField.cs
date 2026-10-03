using UnityEngine;
using UnityEngine.UI;
using WebGLSupport.Detail;

namespace WebGLSupport
{
	internal class WrappedInputField : IInputField
	{
		private InputField input;

		private RebuildChecker checker;

		public bool ReadOnly => false;

		public string text
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string placeholder => null;

		public int fontSize => 0;

		public ContentType contentType => ContentType.Standard;

		public LineType lineType => LineType.SingleLine;

		public int characterLimit => 0;

		public int caretPosition => 0;

		public bool isFocused => false;

		public int selectionFocusPosition
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int selectionAnchorPosition
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool OnFocusSelectAll => false;

		public WrappedInputField(InputField input)
		{
		}

		public RectTransform RectTransform()
		{
			return null;
		}

		public void ActivateInputField()
		{
		}

		public void DeactivateInputField()
		{
		}

		public void Rebuild()
		{
		}
	}
}
