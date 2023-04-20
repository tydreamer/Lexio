using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Lexio.Views.LearningModes;

public partial class SolutionPanelView : UserControl
{
    public SolutionPanelView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}