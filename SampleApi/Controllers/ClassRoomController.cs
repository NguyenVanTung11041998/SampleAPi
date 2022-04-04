using Microsoft.AspNetCore.Mvc;
using SampleApi.Models.ClassRooms;
using SampleApi.Models.Pagings;
using SampleApi.Services.ClassRooms;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SampleApi.Controllers
{
    [ApiController]
    [Route("api/class-room")]
    public class ClassRoomController : ControllerBase, IClassRoomAppService
    {
        private IClassRoomAppService ClassRoomAppService { get; }

        public ClassRoomController(IClassRoomAppService classRoomAppService)
        {
            ClassRoomAppService = classRoomAppService;
        }

        [HttpGet]
        [Route("all")]
        public async Task<List<ClassRoomDto>> GetAllClassRoomAsync()
        {
            return await ClassRoomAppService.GetAllClassRoomAsync();
        }

        [HttpPost]
        [Route("add")]
        public async Task AddAsync(CreateUpdateClassRoomDto input)
        {
            await ClassRoomAppService.AddAsync(input);
        }

        [HttpPut]
        [Route("update/{id}")]
        public async Task UpdateAsync(int id, CreateUpdateClassRoomDto input)
        {
            await ClassRoomAppService.UpdateAsync(id, input);
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public async Task DeleteAsync(int id)
        {
            await ClassRoomAppService.DeleteAsync(id);
        }

        [HttpPost]
        [Route("paging")]
        public async Task<GridResult<ClassRoomDto>> GetAllPagingAsync(ClassPagingInputDto input)
        {
            return await ClassRoomAppService.GetAllPagingAsync(input);
        }
    }
}
