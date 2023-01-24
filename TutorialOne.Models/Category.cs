using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TutorialOne.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Yo, ya gotta gimme a name man")]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage = "Display order only between 1 and 100 ONLY ya nerd!")]
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;

    }
}
