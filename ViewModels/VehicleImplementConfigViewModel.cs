using System.Collections.Generic;
using AgOpenGPSConfig.Views.UserControls;
using Avalonia.Controls;
using Avalonia.Media.Imaging;
using ReactiveUI;

namespace AgOpenGPSConfig.ViewModels;

public class VehicleImplementConfigViewModel: ViewModelBase
{
    private UserControl _currentPage;
    private string _selectedVehicleType;
    private List<Bitmap> _colorList;

    public string SelectedVehicleType
    {
        get => _selectedVehicleType;
        set
        {
            this.RaiseAndSetIfChanged(ref _selectedVehicleType, value);
            UpdateColorList(); 
        }
    }

    public List<Bitmap> ColorList
    {
        get => _colorList;
        set => this.RaiseAndSetIfChanged(ref _colorList, value);
    }

    public UserControl CurrentPage
    {
        get => _currentPage;
        set => this.RaiseAndSetIfChanged(ref _currentPage, value);
    }

    public VehicleImplementConfigViewModel()
    {
        SelectedVehicleType = "Harvester";
        CurrentPage = new VehicleImplementConfigListOfColorsUserControl();
    }

    private void UpdateColorList()
    {
        if (SelectedVehicleType == "Harvester")
        {
            ColorList = new List<Bitmap>
            {
                new ("Assets/AoG.png"),
                new ("Assets/Case.png"),
                new ("Assets/Claas.png"),
                new ("Assets/JohnDeere.png"),
                new ("Assets/NewHolland.png"),
            };
        }
        else if (SelectedVehicleType == "Tractor")
        {
            ColorList = new List<Bitmap>
            {
                new ("Assets/JCB.png"),
                new ("Assets/AoG.png"),
                new ("Assets/Case.png"),
                new ("Assets/Claas.png"),
                new ("Assets/Deutz.png"),
                new ("Assets/Massey.png"),
                new ("Assets/NewHolland.png"), 
                new ("Assets/Same.png"),
                new ("Assets/Ursus.png"),
                new ("Assets/Valtra.png"),
                new ("Assets/JohnDeere.png"),
                new ("Assets/Fendt.png"),
                new ("Assets/Steyr.png"),          
                new ("Assets/Kubota.png"),              
            };
        }
        else if (SelectedVehicleType == "Articulated")
        {
            ColorList = new List<Bitmap>
            {
                new ("Assets/AoG.png"),
                new ("Assets/Challenger.png"),
                new ("Assets/Case.png"),
                new ("Assets/JohnDeere.png"),
                new ("Assets/NewHolland.png"),
                new ("Assets/Holder.png")
            };
        }
    }
}