using static System.Net.Mime.MediaTypeNames;

namespace BE_PhysGen.Models.Entities
{
    public class Questions
    {
        public Guid QuestionId { get; set; }
        public Guid TopicId { get; set; }
        public string QuestionText { get; set; }
        public string QuestionType { get; set; } // 'multiple_choice', 'true_false', 'essay'
        public string DifficultyLevel { get; set; } // 'easy', 'medium', 'hard'
        public string? ImageUrl { get; set; } // Optional, can be null
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
