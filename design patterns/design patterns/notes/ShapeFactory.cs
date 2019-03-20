namespace design_patterns.notes
{
	public class ShapeFactory
	{
		public Shape CreateShape(string type)
		{
			if (string.IsNullOrEmpty(type))
			{
				return null;
			}

			if (type == "triangle")
			{

			}

			return null;

		}
	}
}