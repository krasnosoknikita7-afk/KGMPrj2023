using System.Text;

namespace GNU.Gettext
{
	public class RecursiveTracer
	{
		public int Level { get; set; }

		public StringBuilder Text { get; private set; }

		public void SaveToFile(string fileName)
		{
		}

		public void Indent()
		{
		}
	}
}
