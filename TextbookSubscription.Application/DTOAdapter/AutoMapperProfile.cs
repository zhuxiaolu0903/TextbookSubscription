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
                .ForMember(t => t.TermID, opt => opt.MapFrom(tv => tv.TermNum))
                .ForMember(t => t.Term, opt => opt.MapFrom(tv => tv.TermName));
        }
    }
}
