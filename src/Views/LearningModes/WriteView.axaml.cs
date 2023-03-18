using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Lexio.ViewModels.LearningModes;

namespace Lexio.Views.LearningModes
{
    public partial class WriteView : UserControl
    {
        public WriteView()
        {
            InitializeComponent();
            var textbox = this.Get<TextBox>("MainAnswerTextbox");
            textbox.Initialized += (_, _) =>
            {
                textbox.Focus();
                if (this.DataContext is AnswerViewModelBase dataContext)
                    dataContext.ReadyToFocus += (_, _) => textbox.Focus();
            };
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}