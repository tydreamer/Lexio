using System.Collections.Generic;

namespace Lexio.Models
{
    public class Word
    {
        internal string? Term { get; set; }
        internal string? Definition { get; set; }
        internal List<Word>? Synonyms { get; }
        internal List<Word>? Antonyms { get; }
    }
}