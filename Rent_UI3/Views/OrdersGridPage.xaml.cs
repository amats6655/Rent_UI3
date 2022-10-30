using Microsoft.UI.Xaml.Controls;

using Rent_UI3.ViewModels;

namespace Rent_UI3.Views;

// TODO: Change the grid as appropriate for your app. Adjust the column definitions on DataGridPage.xaml.
// For more details, see the documentation at https://docs.microsoft.com/windows/communitytoolkit/controls/datagrid.
public sealed partial class OrdersGridPage : Page
{
    public OrdersGridViewModel ViewModel
    {
        get;
    }

    public OrdersGridPage()
    {
        ViewModel = App.GetService<OrdersGridViewModel>();
        InitializeComponent();
    }
}
