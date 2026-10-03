namespace GNU.Gettext
{
	internal class PluralFormsNode
	{
		public delegate void IterateNodesDelegate(PluralFormsNode node);

		private PluralFormsToken token;

		private PluralFormsNode[] nodes;

		private RecursiveTracer tracer;

		public PluralFormsToken Token => null;

		public PluralFormsNode[] Nodes => null;

		public int NodesCount => 0;

		internal RecursiveTracer Tracer
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public PluralFormsNode(PluralFormsToken token)
		{
		}

		public PluralFormsNode Node(int i)
		{
			return null;
		}

		public void SetNode(int i, PluralFormsNode n)
		{
		}

		public PluralFormsNode ReleaseNode(int i)
		{
			return null;
		}

		public long Evaluate(long n)
		{
			return 0L;
		}

		public override string ToString()
		{
			return null;
		}

		public static void IterateNodes(PluralFormsNode node, IterateNodesDelegate doBefore, IterateNodesDelegate doAfter)
		{
		}
	}
}
