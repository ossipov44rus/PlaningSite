using System.ComponentModel.DataAnnotations;

namespace ZadachaFinal2.Models
{
    public abstract class ZadachaTemp
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }
        [Range(1,int.MaxValue, ErrorMessage ="Значение должно быть больше нуля.")]
        public int? EstimatedHours { get; set; }
        public bool? IsDone { get; set; }
    }
}
