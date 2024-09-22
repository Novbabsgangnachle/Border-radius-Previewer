using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Border_radius_Previewer;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
    {
        dynamicBorder.CornerRadius = new CornerRadius(
            topLeftSlider.Value,
            topRightSlider.Value,
            bottomRightSlider.Value,
            bottomLeftSlider.Value
        );
    }

    private void CssCopy(object sender, RoutedEventArgs e)
    {
        var bordRad = dynamicBorder.CornerRadius;
        string textToCopy = $"border-radius: {Math.Round(bordRad.TopLeft, 2)}px " +
                            $"{Math.Round(bordRad.TopRight, 2)}px " +
                            $"{Math.Round(bordRad.BottomRight, 2)}px " +
                            $"{Math.Round(bordRad.BottomLeft, 2)}px";

        Clipboard.SetText(textToCopy);

        MessageBox.Show("Скопировано в буффер обмена.");
    }
}