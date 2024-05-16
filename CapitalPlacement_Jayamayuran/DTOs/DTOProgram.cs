using CapitalPlacement_Jayamayuran.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CapitalPlacement_Jayamayuran.DTOs
{
    public class DTOProgram
    {
        [Required]
        [DisplayName("Program Title")]
        public required string Program_Title { get; set; }

        [Required]
        [DisplayName("Program Description")]
        public required string Program_Description { get; set; }

        public List<Question>? Questions { get; set; }
    }
}
