using AutoMapper;
using AutoMapperSample.Model;
using AutoMapperSample.Model.Author;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperSample.Profiles
{
    public class AuthorProfile : Profile
    {
        public AuthorProfile()
        {
            //CreateMap<AuthorDTO, AuthorModel>().ReverseMap();//AuthorDTO 之间 AuthorModel 的相互转换

            //属性名不一致间的转换
            //CreateMap<AuthorModel, AuthorDTO>().ForMember(destination => destination.Address, map => map.MapFrom(source => source.Address1)).ReverseMap();

            //将input 为null 的属性映射之后做自定义处理，比如在 ouput 中改成 No Data
            //CreateMap<AuthorModel, AuthorDTO>().ForMember(destination => destination.Address, opt => opt.NullSubstitute("No data"));

            //属性名不一致间的转换 ，null属性的处理 ，反转
            CreateMap<AuthorModel, AuthorDto>().ForMember(destination => destination.Address, map => { map.MapFrom(source => source.Address1); map.NullSubstitute("No data"); }).ReverseMap();
        }
    }
}
