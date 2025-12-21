using System.ComponentModel.DataAnnotations;

namespace DiaryApp.Models
{
    public class DiaryEntry
    {
// key is the unique identifier about the model you are talking about

        //[Key] if name not Id and something like DiaryId
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Content { get; set; } = string.Empty ;

        [Required]
        public DateTime Created {  get; set; } = DateTime.Now ;


    }
}
