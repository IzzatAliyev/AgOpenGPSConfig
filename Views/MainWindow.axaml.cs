using AgOpenGPSConfig.ViewModels;
using Avalonia.Interactivity;
using Avalonia.ReactiveUI;

namespace AgOpenGPSConfig.Views;

public partial class MainWindow : ReactiveWindow<MainWindowViewModel>
{
    public MainWindow()
    {
        InitializeComponent();
    }
    
    public void OnClick(object sender, RoutedEventArgs e)
    {
    }
}