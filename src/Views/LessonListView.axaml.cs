using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Lexio.ViewModels;

namespace Lexio.Views
{
    public class LessonListView : UserControl
    {
        public LessonListView()
        {
            InitializeComponent();
            if (DataContext is ViewModelBase viewModel)
                viewModel.AssignedView = this;
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}