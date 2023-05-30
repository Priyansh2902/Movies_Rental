using AutoMapper;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using MovieRentalV04.Dtos;
using MovieRentalV04.Models;

namespace MovieRentalV04.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            ////             source  to  target 
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<Movie, MovieDto>();

            Mapper.CreateMap<MembershipType, MembershipTypeDto>();
                    
            Mapper.CreateMap<Genre, GenreDto>();

            Mapper.CreateMap<CustomerDto, Customer>()
                  .ForMember(c => c.Id, opt => opt.Ignore());
            Mapper.CreateMap<MovieDto, Movie>()
                .ForMember(c => c.Id, opt => opt.Ignore());

            
        }


    }
}