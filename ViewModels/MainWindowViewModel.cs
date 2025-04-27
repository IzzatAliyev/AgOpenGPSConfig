using System.Collections.ObjectModel;
using System.Linq;
using AgOpenGPSConfig.Models;
using Avalonia.Controls;
using Avalonia.Media.Imaging;
using ReactiveUI;

namespace AgOpenGPSConfig.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public ObservableCollection<SideElement> Nodes { get; set; }
    
    private UserControl _currentPage;
    public UserControl CurrentPage
    {
        get => _currentPage;
        set => this.RaiseAndSetIfChanged(ref _currentPage, value);
    }

    
    private SideElement _selectedNode;
    public SideElement SelectedNode
    {
        get => _selectedNode;
        set
        {
            this.RaiseAndSetIfChanged(ref _selectedNode, value);
            if (value?.Children?.Any() == true)
            {
                SelectedNode = value.Children.First();
            }
            
            if (value?.Page != null)
            {
                CurrentPage = value.Page;
            }
        }
    }

    public MainWindowViewModel()
    {
        var vehicleMenu = new SideElement
        {
            IconPath = new Bitmap("Assets/Con_VehicleMenu.png"),
            Children = [
                new SideElement
                {
                    IconPath = new Bitmap("Assets/ConS_ImplementConfig.png"),
                    Page = new Views.UserControls.VehicleImplementConfigUserControl() 
                },
                new SideElement
                {
                    IconPath = new Bitmap("Assets/ConS_ImplementHitch.png"),
                    Page = new Views.UserControls.VehicleImplementConfigUserControl() 
                },
                new SideElement
                {
                    IconPath = new Bitmap("Assets/ConS_ImplementAntenna.png"),
                }
            ]
        };
        
        var implMenu = new SideElement
        {
            IconPath = new Bitmap("Assets/Con_ImplementMenu.png"),
            Children = [
                new SideElement
                {
                    IconPath = new Bitmap("Assets/ConS_ImplementConfig.png"),
                },
                new SideElement
                {
                    IconPath = new Bitmap("Assets/ConS_ImplementHitch.png"),
                },
                new SideElement
                {
                    IconPath = new Bitmap("Assets/ConS_ImplementPivot.png"),
                },
                new SideElement
                {
                    IconPath = new Bitmap("Assets/ConS_ImplementOffset.png"),
                },
                new SideElement
                {
                    IconPath = new Bitmap("Assets/ConS_ImplementSection.png"),
                },
                new SideElement
                {
                    IconPath = new Bitmap("Assets/ConS_ImplementSettings.png"),
                },
                new SideElement
                {
                    IconPath = new Bitmap("Assets/ConS_ImplementSwitch.png"),
                }
            ]
        };
        
        var sourcesMenu = new SideElement
        {
            IconPath = new Bitmap("Assets/Con_SourcesMenu.png"),
            Children = [
                new SideElement
                {
                    IconPath = new Bitmap("Assets/ConS_SourcesHeading.png"),
                },
                new SideElement
                {
                    IconPath = new Bitmap("Assets/ConS_SourcesRoll.png"),
                }
            ]
        };
        
        var uTurnMenu = new SideElement
        {
            IconPath = new Bitmap("Assets/Con_UTurnMenu.png"),
            Children = []
        };
        
        var modulesMenu = new SideElement
        {
            IconPath = new Bitmap("Assets/Con_ModulesMenu.png"),
            Children = [
                new SideElement
                {
                    IconPath = new Bitmap("Assets/ConS_ModulesMachine.png"),
                },
                new SideElement
                {
                    IconPath = new Bitmap("Assets/ConS_Pins.png"),
                }
            ]
        };
        
        var tramMenu = new SideElement
        {
            IconPath = new Bitmap("Assets/Con_TramMenu.png"),
            Children = []
        };

        var displayMenu = new SideElement
        {
            IconPath = new Bitmap("Assets/Con_Display.png"),
            Children = []
        };
        
        var featureMenu = new SideElement
        {
            IconPath = new Bitmap("Assets/Con_FeatureMenu.png"),
            Children = []
        };
        
        Nodes = [vehicleMenu, implMenu, sourcesMenu, uTurnMenu, modulesMenu, tramMenu, displayMenu, featureMenu];
    }
}