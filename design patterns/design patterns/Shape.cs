using System.Reflection.Emit;

namespace design_patterns
{
	public abstract class Shape
	{
		public abstract string type { get; set; }
		public abstract int sides { get; set; }
		public abstract string area { get; set; }
	}
}
