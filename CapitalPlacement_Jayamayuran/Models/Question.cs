using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CapitalPlacement_Jayamayuran.Models
{
    public class Question
    {
        [Required]
        public Guid Qid { get; set; }

        [Required]
        [DisplayName("Type")]
        public string? Type { get; set; }

        [Required]
        [DisplayName("Question")]
        public string? Description { get; set; }

        public bool? Internal { get; set; }

        public bool Hide { get; set; }
        public bool enable_other {  get; set; }

        public int max_choices { get; set; } = 0;
        public List<Choices> Choices { get; set; } = [];

    }



    public class Choices
    {
        public string? Choice { get; set; }
    }
}
