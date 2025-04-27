using AgOpenGPSConfig.Views.UserControls;
using Avalonia.Controls;
using ReactiveUI;

namespace AgOpenGPSConfig.ViewModels;

public class VehicleImplementConfigListOfColorsViewModel: ViewModelBase
{
    private UserControl _currentPage;

    public UserControl CurrentPage
    {
        get => _currentPage;
        set => this.RaiseAndSetIfChanged(ref _currentPage, value);
    }

    public VehicleImplementConfigListOfColorsViewModel()
    {
        CurrentPage = new VehicleImplementConfigListOfColorsUserControl();
    }
}