using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Lexio.Views.AddLesson
{
    public class AddWordPanel : UserControl
    {
        public AddWordPanel()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}