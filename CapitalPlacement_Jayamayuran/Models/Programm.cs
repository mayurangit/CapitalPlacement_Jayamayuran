using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CapitalPlacement_Jayamayuran.Models
{
    public class _Programm
    {
        public Guid Program_ID { get; set; }

        [Required]
        [DisplayName("Program Title")]
        public required string Program_Title { get; set;}

        [Required]
        [DisplayName("Program Description")]
        public required string Program_Description { get; set; }

        public List<Question>? Questions { get; set;}
    }
}
