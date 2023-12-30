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
using System.Globalization;

namespace celis_michiel_c_sherp
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}
		private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
		{
			Window window = sender as Window;
			if (window != null)
			{
				double aspectRatio = window.Width / window.Height;
				if (aspectRatio < 4.0 / 3.0) // If the aspect ratio is less than 4:3
				{
					window.Width = window.Height * 4.0 / 3.0; // Adjust the width
				}
				else if (aspectRatio > 16.0 / 9.0) // If the aspect ratio is greater than 16:9
				{
					window.Height = window.Width * 9.0 / 16.0; // Adjust the height
				}
			}
		}
	}
	public class ViewportPercentageConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			double viewportSize = System.Convert.ToDouble(value);
			double percentage = System.Convert.ToDouble(parameter);
			return viewportSize * (percentage / 100);
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
