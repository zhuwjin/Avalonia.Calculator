using System;
using Avalonia.Calculator.ViewModels;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;
using Avalonia.Styling;
using ReactiveUI;

namespace Avalonia.Calculator.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        var app = Application.Current!;
        var theme = app.ActualThemeVariant;
        app.RequestedThemeVariant = theme == ThemeVariant.Dark ? ThemeVariant.Light : ThemeVariant.Dark;
        if (DataContext is MainWindowViewModel model)
        {
            model.TintColor = app.RequestedThemeVariant == ThemeVariant.Light ? Colors.White : Colors.Black;
            model.MyText = app.RequestedThemeVariant == ThemeVariant.Light ? "Colors.White" : "Colors.Black";
        }
    }
}