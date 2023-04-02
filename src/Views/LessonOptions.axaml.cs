using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Lexio.Views;

public partial class LessonOptions : UserControl
{
    public LessonOptions()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}