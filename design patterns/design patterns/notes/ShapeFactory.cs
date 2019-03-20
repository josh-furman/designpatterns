using System;

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

			var args = new object[] { };
			return Activator.CreateInstance(Type.GetType("design_patterns." + type), args) as Shape;
		}
	}
}