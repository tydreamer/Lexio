using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Lexio.Views
{
    public class AddLessonView : UserControl
    {
        public AddLessonView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}