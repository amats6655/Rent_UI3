using Microsoft.UI.Xaml.Controls;

using Rent_UI3.ViewModels;

namespace Rent_UI3.Views;

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
