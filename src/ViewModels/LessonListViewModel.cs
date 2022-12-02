using System;
using Avalonia.Controls;
using Lexio.Extensions;
using Lexio.Views;

namespace Lexio.ViewModels
{
    public class LessonListViewModel : ViewModelBase
    {
        public LessonListViewModel(Window parentWindow) => this.ParentWindow = parentWindow;
        
        private void OpenAddPage()
        {
            var window = new AddLessonWindow
            {
                DataContext = new AddLessonViewModel()
            };
            
            if(ParentWindow is { } parentWindow)
                window.ShowDialogSafe(parentWindow);
        }
    }
}