using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Lexio.Views.OpenLesson;

public class LearningModesView : UserControl
{
    public LearningModesView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}