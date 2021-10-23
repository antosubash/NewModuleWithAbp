using AutoMapper;
using ModuleA;

namespace MainApp
{
    public class MainAppApplicationAutoMapperProfile : Profile
    {
        public MainAppApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<TodoOne, TodoOneDto>();
            CreateMap<TodoOneDto, TodoOne>();
        }
    }
}
