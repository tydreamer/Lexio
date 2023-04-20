using ReactiveUI;

namespace Lexio.ViewModels;

public abstract class ViewModelBase : ReactiveObject
{
    protected ViewModelBase()
    {
        MainViewModel = MainWindowViewModel.Instance;
    }
        
    protected MainWindowViewModel? MainViewModel { get;  }
}