using BBX_Studio.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace BBX_Studio.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }
}
