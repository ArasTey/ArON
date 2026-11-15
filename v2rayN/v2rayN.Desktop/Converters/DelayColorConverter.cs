using Avalonia.Data.Converters;

namespace v2rayN.Desktop.Converters;

public class DelayColorConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        var delay = value.ToString().ToInt();

        return delay switch
        {
            <= 0 => new SolidColorBrush(Color.Parse("#FF8C8273")),
            <= 300 => new SolidColorBrush(Color.Parse("#FF0E9F82")),
            <= 800 => new SolidColorBrush(Color.Parse("#FFC0923A")),
            _ => new SolidColorBrush(Color.Parse("#FFD96A5E"))
        };
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        return null;
    }
}
