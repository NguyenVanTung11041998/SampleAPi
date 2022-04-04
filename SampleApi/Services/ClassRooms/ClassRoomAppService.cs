using Microsoft.EntityFrameworkCore;
using SampleApi.Entities;
using SampleApi.EntityFrameworkCore;
using SampleApi.Models.ClassRooms;
using SampleApi.Models.Pagings;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApi.Services.ClassRooms
{
    public class ClassRoomAppService : SampleAppServiceBase, IClassRoomAppService
    {
        public ClassRoomAppService(SampleDbContext context) : base(context)
        {

        }

        public async Task AddAsync(CreateUpdateClassRoomDto input)
        {
            var classRoomAdd = new ClassRoom
            {
                Grade = input.Grade,
                Name = input.Name
            };

            Context.ClassRooms.Add(classRoomAdd);

            await Context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            bool isExists = await Context.Students.AnyAsync(x => x.ClassId == id);

            if (isExists) return;

            var classRoomDelete = await Context.ClassRooms.FirstOrDefaultAsync(x => x.Id == id);

            if (classRoomDelete != null)
            {
                Context.Remove(classRoomDelete);

                await Context.SaveChangesAsync();
            }
        }

        public async Task<List<ClassRoomDto>> GetAllClassRoomAsync()
        {
            return await Context.ClassRooms.Select(x => new ClassRoomDto
            {
                Grade = x.Grade,
                Id = x.Id,
                Name = x.Name
            }).ToListAsync();
        }

        public async Task<GridResult<ClassRoomDto>> GetAllPagingAsync(ClassPagingInputDto input)
        {
            var query = Context.ClassRooms.Select(x => new ClassRoomDto
            {
                Grade = x.Grade,
                Id = x.Id,
                Name = x.Name
            });

            if (input.Name != null && input.Name.Trim() != string.Empty)
                query = query.Where(x => input.Name.Contains(x.Name));

            if (input.Grade.HasValue)
                query = query.Where(x => x.Grade == input.Grade);

            int totalCount = await query.CountAsync();

            var list = await query.ToListAsync();

            return new GridResult<ClassRoomDto>(totalCount, list);
        }

        public async Task UpdateAsync(int id, CreateUpdateClassRoomDto input)
        {
            var classRoomUpdate = await Context.ClassRooms.FirstOrDefaultAsync(x => x.Id == id);

            if (classRoomUpdate != null)
            {
                classRoomUpdate.Name = input.Name;

                classRoomUpdate.Grade = input.Grade;

                Context.ClassRooms.Update(classRoomUpdate);

                await Context.SaveChangesAsync();
            }
        }
    }
}
