using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
namespace NodifyM.Avalonia.ViewModelBase;

public partial class NodifyEditorViewModelBase : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<object?> nodes = new();

    [ObservableProperty]
    private ObservableCollection<object?> selectedNodes = new();

}
