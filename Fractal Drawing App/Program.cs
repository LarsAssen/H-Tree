using System;
using System.Collections.Generic;
using System.Drawing;

namespace Fractal_Drawing_App
{
	class Program
	{
		public static void DrawHTree(double x, double y, double length, int depth)
		{
			if(depth == 0)
			{
				return;
			}

			var halfLength = length / 2;

			var leftX = x - halfLength;
			var rightX = x + halfLength;

			var topY = y + halfLength;
			var bottomY = y - halfLength;

			drawLine(leftX, y, rightX, y);
			drawLine(leftX, topY, leftX, bottomY);
			drawLine(rightX, topY, rightX, bottomY);

			var nextLength = length / Math.Sqrt(2);
			var nextDepth = depth - 1;

			DrawHTree(leftX, topY, nextLength, nextDepth);
			DrawHTree(rightX, topY, nextLength, nextDepth);
			DrawHTree(rightX, bottomY, nextLength, nextDepth);
			DrawHTree(leftX, bottomY, nextLength, nextDepth);
		}

		private static void drawLine(double x1, double y1, double x2, double y2)
		{
			Console.WriteLine(to3Decimal(x1) + "," + to3Decimal(y1) + " -" + to3Decimal(x2) + "," + to3Decimal(y2));
		}

		private static double to3Decimal(double x)
		{
			return (int)(x * 1000) / 1000.0;
		}

        static void Main(string[] args)
		{
			DrawHTree(100, 100, 50, 2);
		}
	}
}
