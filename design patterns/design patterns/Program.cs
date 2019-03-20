using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using design_patterns.notes;

namespace design_patterns
{
	class Program
	{
		static void Main(string[] args)
		{
			var selection = "circle";
			var factory = new ShapeFactory();
			Shape shape = factory.CreateShape(selection);

			List<Shape> shapes = new List<Shape>();
			

		}
	}
}
