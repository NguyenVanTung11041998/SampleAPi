using System.ComponentModel.DataAnnotations;

namespace SampleApi.Entities
{
    public class ClassRoom
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public int Grade { get; set; }
    }
}
