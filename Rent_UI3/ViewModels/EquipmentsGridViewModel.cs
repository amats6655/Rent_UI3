using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.ComponentModel;

using Rent_UI3.Contracts.ViewModels;
using Rent_UI3.Core.Contracts.Services;
using Rent_UI3.Core.Models;

namespace Rent_UI3.ViewModels;

public class EquipmentsGridViewModel : ObservableRecipient, INavigationAware
{
    private readonly ISampleDataService _sampleDataService;

    public ObservableCollection<SampleOrder> Source { get; } = new ObservableCollection<SampleOrder>();

    public EquipmentsGridViewModel(ISampleDataService sampleDataService)
    {
        _sampleDataService = sampleDataService;
    }

    public async void OnNavigatedTo(object parameter)
    {
        Source.Clear();

        // TODO: Replace with real data.
        var data = await _sampleDataService.GetGridDataAsync();

        foreach (var item in data)
        {
            Source.Add(item);
        }
    }

    public void OnNavigatedFrom()
    {
    }
}
