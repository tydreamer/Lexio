using Avalonia.Controls;
using Lexio.Extensions;
using Lexio.Views;

namespace Lexio.ViewModels
{
    public class LessonListViewModel : ViewModelBase
    {
        private void OpenAddPage()
        {
            var window = new AddLessonWindow
            {
                DataContext = new AddLessonViewModel()
            };
            
            if(AssignedView is Window parentWindow)
                window.ShowDialogSafe(parentWindow);
        }
    }
}