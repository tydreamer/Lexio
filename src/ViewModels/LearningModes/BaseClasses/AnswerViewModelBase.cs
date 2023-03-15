using Lexio.Models;

namespace Lexio.ViewModels.LearningModes
{
    public abstract class AnswerViewModelBase : LearningModeViewModelBase
    {
        protected AnswerViewModelBase(Lesson lesson) : base(lesson) { }
    }
}