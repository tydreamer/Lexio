using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Lexio.Views.Dialogs;

public class InformationDialogView : UserControl
{
    public InformationDialogView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}