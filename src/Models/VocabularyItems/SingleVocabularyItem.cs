using System.Collections;

namespace Lexio.Models
{
    public class SingleVocabularyItem : VocabularyItem
    {
        public SingleVocabularyItem(IList? containerCollection = null) : base(containerCollection) { }
        
        internal string? Definition { get; set; }
    }
}