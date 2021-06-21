

using System;

namespace Zad1
{
	public struct Vector : IComparable
	{
		private double x, y, z;

		public Vector(double x, double y, double z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		public void WriteVector()
		{
			Console.WriteLine($"({x}, {y}, {z})");
		}

		public static double Dot(Vector v1, Vector v2) => v1.x * v2.x + v1.y * v2.y + v1.z * v2.z;
		public static Vector Cross(Vector v1, Vector v2) => 
			new Vector(v1.y * v2.z - v1.z * v2.y, v1.z * v2.x - v1.x * v2.z, v1.x * v2.y - v1.y * v2.x);

		public static bool Perpendicular(Vector v1, Vector v2) => Dot(v1, v2) == 0;

		public double Length => Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));

		public static Vector operator +(Vector v1, Vector v2) => new Vector(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
		public static Vector operator -(Vector v1, Vector v2) => new Vector(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
		public static bool operator ==(Vector v1, Vector v2) => v1.x == v2.x && v1.y == v2.y && v1.z == v2.z;
		public static bool operator !=(Vector v1, Vector v2) => v1.x != v2.x || v1.y != v2.y || v1.z != v2.z;
		public static Vector operator *(Vector v, double n) => new Vector(v.x * n, v.y * n, v.z * n);
		public static Vector operator /(Vector v, double n) => new Vector(v.x / n, v.y / n, v.z / n);

		public int CompareTo(object? obj)
		{
			var v2 = (Vector) obj;
			return Length == v2.Length ? 1 : 0;
		}
	}
}