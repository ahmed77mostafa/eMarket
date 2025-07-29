using AutoMapper;
using DataAccessLayer.DTO.CategoryDTO;
using DataAccessLayer.DTO.FeedbackDTO;
using DataAccessLayer.DTO.ProductDTO;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Mapper
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, RequestCategoryDTO>();
            CreateMap<Category, RespondCategoryDTO>();
            //.ForMember(dest => dest.isFree, src => src.MapFrom(src => src.Price == 0));
            CreateMap<Feedback, RequestFeedbackDTO>();
            CreateMap<Feedback, RespondFeedbackDTO>();
            CreateMap<FeedbackAtProduct , Feedback >();
            CreateMap<Product, RequestProductDTO>();
            CreateMap<RequestProductDTO, Product>();
            CreateMap<Product, RespondProductDTO>();
        }
    }
}
