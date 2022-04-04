using SampleApi.EntityFrameworkCore;

namespace SampleApi.Services
{
    public abstract class SampleAppServiceBase
    {
        protected SampleDbContext Context { get; set; }

        public SampleAppServiceBase(SampleDbContext context)
        {
            Context = context;
        }
    }
}
