using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TutorialOne.Models
{
    public class CoverType
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Cover Type")]
        [Required(ErrorMessage = "Yo, ya gotta gimme a name man")]
        public string Name { get; set; }
    }
}
