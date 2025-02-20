using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class ScoreModel
    {
        [Required]
        [Range(0, 10, ErrorMessage = "Điểm A phải từ 0 đến 10")]
        public float ScoreA { get; set; }

        [Required]
        [Range(0, 10, ErrorMessage = "Điểm B phải từ 0 đến 10")]
        public float ScoreB { get; set; }

        [Required]
        [Range(0, 10, ErrorMessage = "Điểm C phải từ 0 đến 10")]
        public float ScoreC { get; set; }

        // Công thức tính điểm môn học
        public float FinalScore => (ScoreA * 0.3f) + (ScoreB * 0.3f) + (ScoreC * 0.4f);

        // Xếp loại theo điểm tổng kết
        public string Grade
        {
            get
            {
                if (FinalScore >= 8) return "Giỏi";
                if (FinalScore >= 6.5) return "Khá";
                if (FinalScore >= 5) return "Trung Bình";
                return "Yếu";
            }
        }
    }
}
