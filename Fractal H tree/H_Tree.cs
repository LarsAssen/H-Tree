using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Fractal_H_tree
{
	class H_Tree
	{
		private int depth = 2;
		public H_Tree()
		{

		}
		public void DrawHTree(double x, double y, double length, int depth, Canvas myCanvas)
		{
			if (depth == 0)
			{
				return;
			}

			var halfLength = length / 2;

			var leftX = x - halfLength;
			var rightX = x + halfLength;

			var topY = y + halfLength;
			var bottomY = y - halfLength;
			
			Line line1 = new Line { X1 = leftX, Y1 = y, X2 = rightX, Y2 = y };
			line1.Stroke = Brushes.Black;
			line1.StrokeThickness = 2;

			Line line2 = new Line { X1 = leftX, Y1 = topY, X2 = leftX, Y2 = bottomY };
			line2.Stroke = Brushes.Black;
			line2.StrokeThickness = 2;
			
			Line line3 = new Line { X1 = rightX, Y1 = topY, X2 = rightX, Y2 = bottomY };
			line3.Stroke = Brushes.Black;
			line3.StrokeThickness = 2;
			
			myCanvas.Children.Add(line1);
			myCanvas.Children.Add(line2);
			myCanvas.Children.Add(line3);

			var nextLength = length / Math.Sqrt(depth + 1);
			var nextDepth = depth - 1;

			DrawHTree(leftX, topY, nextLength, nextDepth, myCanvas);
			DrawHTree(rightX, topY, nextLength, nextDepth, myCanvas);
			DrawHTree(rightX, bottomY, nextLength, nextDepth, myCanvas);
			DrawHTree(leftX, bottomY, nextLength, nextDepth, myCanvas);
		}
	}
}
