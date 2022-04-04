using SampleApi.Models.ClassRooms;
using SampleApi.Models.Pagings;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SampleApi.Services.ClassRooms
{
    public interface IClassRoomAppService
    {
        Task<List<ClassRoomDto>> GetAllClassRoomAsync();

        Task AddAsync(CreateUpdateClassRoomDto input);

        Task UpdateAsync(int id, CreateUpdateClassRoomDto input);

        Task DeleteAsync(int id);

        Task<GridResult<ClassRoomDto>> GetAllPagingAsync(ClassPagingInputDto input);
    }
}
