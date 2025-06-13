namespace BE_PhysGen.Models
{
    public class QuestionDTO
    {
        public Guid TopicId { get; set; }
        public string QuestionText { get; set; }
        public string QuestionType { get; set; } // 'multiple_choice', 'true_false', 'essay'
        public string DifficultyLevel { get; set; } // 'easy', 'medium', 'hard'
        public string? ImageUrl { get; set; }
    }
}
