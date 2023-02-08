using System.Collections.Generic;

namespace Lexio.Interfaces
{
    public interface IContentVerification<T> where T : IContentVerification<T>
    {
        bool MatchesUnsavedContent(IEnumerable<T> collection, out T? identicalItem);
        void EqualizeChangedData();
    }
}