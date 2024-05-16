using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using CapitalPlacement_Jayamayuran.Models;

namespace CapitalPlacement_Jayamayuran.DTOs
{
    public class DTOQuetion
    {
        [Required]
     
        public string? Type { get; set; }

        [Required]
     
        public string? Description { get; set; }

        public bool? Internal { get; set; }

        public bool Hide { get; set; }
        public bool enable_other { get; set; }

        public int max_choices { get; set; } = 0;
        public List<Choices> Choices { get; set; } = [];
    }
}
