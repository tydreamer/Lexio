using Lexio.Enums;
using Lexio.Extensions;
using Lexio.Interfaces;
using Lexio.Models;
using Lexio.ViewModels.BaseClasses;

namespace Lexio.ViewModels
{
    public class LessonViewModel : LessonViewModelBase, IDiscardableChanges
    {
        public LessonViewModel(Lesson lesson)
        {
            this.CurrentLesson = lesson;
            lesson.VocabularyItems.CalculateIndexReactive(this, true, nameof(AdjustableItemsString));
        }

        private Lesson CurrentLesson { get; }
        private string AdjustableItemsString => CurrentLesson.VocabularyItems.Count == 1 ? "item" : "items";

        public void DiscardChanges()
        {
            CurrentLesson.DiscardChanges();
            MainViewModel?.ReturnHome(false);
        }
        
        protected override void ChangeTolerance(ErrorTolerance newTolerance)
        {
            // Change setting in lesson
        }

        private void SaveChanges()
        {
            CurrentLesson.SaveChanges();
            DataManager.SaveData();
        }

        // private void DebugUnsavedChanges()
        // {
        //     UtilityCollection.Utilities.Log("--------------------------------------------------------------------");
        //     CurrentLesson.DebugUnsavedChanges();
        // }
    }
}