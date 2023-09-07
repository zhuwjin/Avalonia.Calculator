using Avalonia.Media;
using ReactiveUI;

namespace Avalonia.Calculator.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public string Greeting => "Welcome to Avalonia!";

    private Color _tintColor = Colors.Black;
    public Color TintColor
    {
        get => _tintColor;
        set => this.RaiseAndSetIfChanged(ref _tintColor, value);
    }

    private string _myText = "Hello";
    public string MyText
    {
        get => _myText;
        set => this.RaiseAndSetIfChanged(ref _myText, value);
    }
}