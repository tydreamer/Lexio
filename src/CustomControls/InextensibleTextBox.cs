using System;
using Avalonia.Controls;
using Avalonia.Styling;
using Lexio.Views;

namespace Lexio.CustomControls;

public class InextensibleTextBox : TextBox, IStyleable
{
    public InextensibleTextBox()
    {
        this.LayoutUpdated += (sender, args) => MaxWidth = Bounds.Width;
        
        if (MainWindow.Instance is not { } window)
            return;
        window.PropertyChanged += (sender, args) =>
        {
            if (args.Property == TopLevel.ClientSizeProperty)
                MaxWidth = double.MaxValue;
        };
    }
    
    Type IStyleable.StyleKey => typeof(TextBox);
}