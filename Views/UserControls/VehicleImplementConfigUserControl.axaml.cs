using AgOpenGPSConfig.ViewModels;
using Avalonia.Controls;
using Avalonia.Input;

namespace AgOpenGPSConfig.Views.UserControls;

public partial class VehicleImplementConfigUserControl : UserControl
{
    public VehicleImplementConfigUserControl()
    {
        InitializeComponent();
    }
    
    private void OnHarvesterClicked(object sender, PointerPressedEventArgs e)
    {
        var viewModel = (VehicleImplementConfigViewModel)DataContext;
        viewModel.SelectedVehicleType = "Harvester";

        var listOfColorsControl = new VehicleImplementConfigListOfColorsUserControl();
        viewModel.CurrentPage = listOfColorsControl;
    }

    private void OnTractorClicked(object sender, PointerPressedEventArgs e)
    {
        var viewModel = (VehicleImplementConfigViewModel)DataContext;
        viewModel.SelectedVehicleType = "Tractor";

        var listOfColorsControl = new VehicleImplementConfigListOfColorsUserControl();
        viewModel.CurrentPage = listOfColorsControl;
    }

    private void OnArticulatedClicked(object sender, PointerPressedEventArgs e)
    {
        var viewModel = (VehicleImplementConfigViewModel)DataContext;
        viewModel.SelectedVehicleType = "Articulated"; 

        var listOfColorsControl = new VehicleImplementConfigListOfColorsUserControl();
        viewModel.CurrentPage = listOfColorsControl;
    }
}