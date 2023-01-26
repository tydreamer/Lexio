using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Lexio.Views
{
    public class LessonView : UserControl
    {
        public LessonView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}