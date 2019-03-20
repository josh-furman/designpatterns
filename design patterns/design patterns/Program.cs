using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns
{
	class Program
	{
		static void Main(string[] args)
		{
			var selection = "circle";

			Shape shape = null;

			if (shape.type == "square")
			{
				shape = new Shape
				{
					type = "square",
					sides = 4,
					area = "l * l"
				};
			}
			else if (shape.type == "triangle")
			{
				shape = new Shape
				{
					type = "triangle",
					sides = 3,
					area = "(1/2) * b * h"
				};
			}
			else if (shape.type == "trapezoid")
			{
				shape = new Shape
				{
					type = "trapezoid",
					sides = 4,
					area = "((a+b)/2) * h"
				};
			}
			else if (shape.type == "circle")
			{
				shape = new Shape
				{
					type = "circle",
					sides = 0,
					area = "pi * r * r"
				};
			}
			else
			{
				Console.WriteLine("Is this even a shape?");
			}
		}
	}
}
