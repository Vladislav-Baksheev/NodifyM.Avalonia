using Avalonia;
using Avalonia.Styling;
using CommunityToolkit.Mvvm.Input;
using NodifyM.Avalonia.ViewModelBase;

namespace NodifyM.Avalonia.Example;

public partial class MainWindowViewModel : NodifyEditorViewModelBase{
    public MainWindowViewModel()
    {
        Nodes  = new()
        {
            new NodeViewModelBase
            {
                Location = new Point(400, 200),
                Title = "Node 1"
            },
            new NodeViewModelBase
            {
                Title = "Node 2",
                Location = new Point(-100, -100)
            }
        };
    }
    [RelayCommand]
    private void ChangeTheme()
    {
        if (Application.Current.ActualThemeVariant==ThemeVariant.Dark)
        {
            Application.Current.RequestedThemeVariant = ThemeVariant.Light;
        }else
        {
            Application.Current.RequestedThemeVariant = ThemeVariant.Dark;
        }
    }
}
