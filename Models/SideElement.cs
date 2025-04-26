using System.Collections.Generic;
using System.Collections.ObjectModel;
using Avalonia.Media.Imaging;

namespace AgOpenGPSConfig.Models;

public class SideElement()
{
    public Bitmap IconPath { get; set; } 
    public ObservableCollection<SideElement> Children { get; set; }

    public SideElement(Bitmap iconPath): this()
    {
        IconPath = iconPath;
        Children = new ObservableCollection<SideElement>();
    }
}