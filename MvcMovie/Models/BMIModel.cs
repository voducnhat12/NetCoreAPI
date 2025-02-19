using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class BMIModel
    {
        [Required]
        [Range(1, 300, ErrorMessage = "Cân nặng phải từ 1 đến 300 kg")]
        public float Weight { get; set; }

        [Required]
        [Range(0.5, 2, ErrorMessage = "Chiều cao phải từ 0.5 đến 2.5 mét")]
        public float Height { get; set; }

        public float BMI => Weight / (Height * Height);

        public string Result
        {
            get
            {
                if (BMI < 18.5) return "Gầy ";
                if (BMI < 24.9) return "Bình thường";
                if (BMI < 29.9) return "Thừa cân";
                return "Béo phì";
            }
        }
    }
}
