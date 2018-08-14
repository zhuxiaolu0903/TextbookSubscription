namespace TextbookSubscription.Application.DTOAdapter
{
    using AutoMapper;
    using TextbookSubscription.ViewModels;
    using TextbookSubscription.Domain.Entity;

    public class AutoMapperProfile : Profile
    {
        /// <summary>
        /// 配置映射关系
        /// </summary>
        protected override void Configure()
        {
            //Term => TermView
            CreateMap<Term, TermView>()
                .ForMember(tv => tv.TermID, opt => opt.MapFrom(t => t.TermNum))
                .ForMember(tv => tv.Term, opt => opt.MapFrom(tv => tv.TermName));
            //School=>SchoolView
            CreateMap<School, SchoolView>()
                .ForMember(sv => sv.SchoolID, opt => opt.MapFrom(t => t.SchoolID))
                .ForMember(sv => sv.SchoolName, opt => opt.MapFrom(sv => sv.SchoolName));
        }
    }
}
