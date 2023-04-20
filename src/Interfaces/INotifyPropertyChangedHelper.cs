using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Lexio.Interfaces;

public interface INotifyPropertyChangedHelper : INotifyPropertyChanged
{
    void NotifyPropertyChanged([CallerMemberName] string propertyName = "");
}