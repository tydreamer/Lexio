using System.Collections.ObjectModel;
using Lexio.Models;

namespace Lexio.Interfaces;

public interface IVocabularyContainer<T> where T : VocabularyItem
{
    ObservableCollection<T> VocabularyItems { get; }
}