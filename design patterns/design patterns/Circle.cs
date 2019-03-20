namespace design_patterns
{
	public class Circle : Shape
	{
		public override string type { get; set; }
		public override int sides { get; set; }
		public override string area { get; set; }

		public Circle()
		{
			this.type = "Circle";
			this.sides = 0;
			this.area = "pi * r * r";
		}
	}
}