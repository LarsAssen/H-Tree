using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Fractal_H_tree
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private int clicker = 1;
		private H_Tree h_tree= new H_Tree();
		public MainWindow()
		{
            InitializeComponent();
		}

		private void H_Tree_Click(object sender, RoutedEventArgs e)
		{
			if(clicker == 5)
			{
				MessageBox.Show("Max reached");
				return;
			}
			MyCanvas.Children.Clear();
			h_tree.DrawHTree(250, 250, 100, clicker, MyCanvas);
			clicker++;
		}
		private void Clear_Click(object sender, RoutedEventArgs e)
		{
			clicker = 1;
			MyCanvas.Children.Clear();
		}
	}
}
