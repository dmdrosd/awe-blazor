using Awe.Core.Widget.Contracts.Domain;
using DevExpress.Blazor;

namespace Awe.Platform.Wasm.View.Shared.Page;

public partial class PageList : PageBase<IPageDomainService>
{
    private WeatherForecast[]? _forecasts; 
    public string Alert { get; set; } = "";

    protected override async Task OnInitializedAsync()
    {
        //forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("sample_data/weather.json");

        _forecasts = new WeatherForecast[]
        {
            new()
            {
                Date = DateTime.Now,
                Summary = "EEE",
                TemperatureC = 12
            },
            new()
            {
                Date = DateTime.Now,
                Summary = "NNN",
                TemperatureC = 22
            }
        };
    }

    private void OnRowDoubleClick(GridRowClickEventArgs e)
    {
        Alert = $"The row {e.VisibleIndex} has been double clicked. The row value is '{e.Grid.GetRowValue(e.VisibleIndex, "Date")}'. ";
        NavigateToEdit("1");
    }

    private void NavigateToDetails(string id)
    {
        Nav.NavigateTo($"/app/user/view/{id}");
    }

    private void NavigateToEdit(string id)
    {
        Nav.NavigateTo($"/app/user/edit/{id}");
    }

    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }
        public string? Summary { get; set; }
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }
}