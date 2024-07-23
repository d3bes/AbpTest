using Abp.Test.Documents;
using Abp.Test.Models;
using AutoMapper;

namespace Abp.Test;

public class TestApplicationAutoMapperProfile : Profile
{
    public TestApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

         CreateMap<Document, DocumentDto>()
            .ForMember(dest => dest.Id,opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.NameAr,opt => opt.MapFrom(src => src.NameAr))
            .ForMember(dest => dest.NameEn,opt => opt.MapFrom(src => src.NameEn))
            .ForMember(dest => dest.DescriptionAr,opt => opt.MapFrom(src => src.DescriptionAr))
            .ForMember(dest => dest.DescriptionEn,opt => opt.MapFrom(src => src.DescriptionEn))
            .ForMember(dest => dest.isSigned,opt => opt.MapFrom(src => src.isSigned))
            .ForMember(dest => dest.path,opt => opt.MapFrom(src => src.path));

             CreateMap<DocumentDto,Document>()
            .ForMember(dest => dest.Id,opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.NameEn,opt => opt.MapFrom(src => src.NameEn))
            .ForMember(dest => dest.DescriptionAr,opt => opt.MapFrom(src => src.DescriptionAr))
            .ForMember(dest => dest.DescriptionEn,opt => opt.MapFrom(src => src.DescriptionEn))
            .ForMember(dest => dest.isSigned,opt => opt.MapFrom(src => src.isSigned))
            .ForMember(dest => dest.path,opt => opt.MapFrom(src => src.path));
    }
}
