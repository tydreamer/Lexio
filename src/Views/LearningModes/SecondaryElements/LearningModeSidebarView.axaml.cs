using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Lexio.Views.LearningModes
{
    public partial class LearningModeSidebarView : UserControl
    {
        public LearningModeSidebarView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}