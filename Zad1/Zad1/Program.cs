using System;

namespace Zad1
{
	class Program
	{
		static void Main(string[] args)
		{
			var v1 = new Vector(1, 1, 1);
			var v2 = new Vector(3, 2, 3);

			var v3 = v2 / 3;
			v3.WriteVector();
		}
	}
}
