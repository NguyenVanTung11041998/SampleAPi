using SampleApi.Models.Pagings;

namespace SampleApi.Models.ClassRooms
{
    public class ClassPagingInputDto : GridParam
    {
        public string Name { get; set; }
        public int? Grade { get; set; }
    }
}
