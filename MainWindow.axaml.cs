using Avalonia.Controls;
using System;

namespace StayBehindDemo;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Window_Opened(object? sender, System.EventArgs e)
    {
        ShowInTaskbar = true;
        ShowInTaskbar = false;
        // prevent window borders from being rendered if not in a Linux DE
        if (!OperatingSystem.IsLinux())
        {
            this.ExtendClientAreaToDecorationsHint = false;
            this.SystemDecorations = SystemDecorations.None;
        }
        if (OperatingSystem.IsWindows())
        {
            Win32Interop.KeepWindowAtBottom(this);
        }
        WindowStartupLocation = WindowStartupLocation.Manual;
        Position = new Avalonia.PixelPoint(0, 0);
    }

    private void Window_Loaded(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
    }
}